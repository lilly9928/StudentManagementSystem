using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using MyExcelClassLibrary;
using System.Threading.Tasks;
using System.Threading;
using MetroFramework.Forms;

namespace termproject
{
    public partial class TeacherForm : MetroForm, IFileIO
    {
        
        class Card
        {
            public dynamic Name;
            public dynamic School;
            public dynamic Grade;
            public dynamic Number;

        }

        class hCard
        {
            public dynamic Name;
            public dynamic School;
            public dynamic Grade;
            public dynamic Tem;

        }
        public TeacherForm()
        {
            InitializeComponent();

        }

        // 필요한것들
        string fname = "";
        int flag = 0;
        delegate void ProgvarCall(int var);
       

        Excel.Application excelApp = null;
        Excel.Workbook workBook = null;
        Excel.Worksheet workSheet = null;

        List<dynamic> cards = new List<dynamic>();
        List<dynamic> hcards = new List<dynamic>();
        private void clear_text()
        {
            text_name.Text = "";
            text_phone.Text = "";
            text_school.Text = "";
        }
       
        /*파일 인터페이스*/
        public void ReleaseObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null; throw ex;
            }
            finally
            {
                GC.Collect();
            }


        }
        public void saveData()
        {
            if (text_class.Text == "")
            {
                MessageBox.Show("반이름을 입력해주세요");
                return;
            }
            
            if (listView1.Items.Count != 0)
            {
                List<Card> cards = new List<Card>();

                try
                {
                    fname = text_class.Text;
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string path = Path.Combine(desktopPath,fname +".xlsx");

                    excelApp = new Excel.Application();
                    if (flag == 1) // 파일을 열어서 수정하는 경우 
                    {
                        workBook = excelApp.Workbooks.Open(path);
                    }
                    else  workBook = excelApp.Workbooks.Add();
                  
                    workSheet = workBook.Worksheets.get_Item(1) as Excel.Worksheet;
                    workSheet.Name = text_class.Text;

                    workSheet.Cells[1, 1] = "학생번호";
                    workSheet.Cells[1, 2] = "이름";
                    workSheet.Cells[1, 3] = "학교";
                    workSheet.Cells[1, 4] = "학년";
                    workSheet.Cells[1, 5] = "전화번호";

                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        cards.Add(new Card()
                        {
                            Name = listView1.Items[i].SubItems[0].Text,
                            School = listView1.Items[i].SubItems[1].Text,
                            Grade = listView1.Items[i].SubItems[2].Text,
                            Number = listView1.Items[i].SubItems[3].Text
                        });

                    }

                    for (int i = 0; i < cards.Count; i++)
                    {
                        Card card = cards[i];

                        workSheet.Cells[2 + i, 1] = ""+i;
                        workSheet.Cells[2 + i, 2] = card.Name;
                        workSheet.Cells[2 + i, 3] = card.School;
                        workSheet.Cells[2 + i, 4] = card.Grade;
                        workSheet.Cells[2 + i, 5] = card.Number;
                    }

                    workSheet.Columns.AutoFit();
                    if (flag == 1){
                        workBook.SaveAs(path);
                    }else workBook.SaveAs(path, Excel.XlFileFormat.xlWorkbookDefault);
                    workBook.Close(true);
                    excelApp.Quit();

                    MessageBox.Show("저장되었습니다!");

                }
                finally
                {
                    ReleaseObject(workSheet);
                    ReleaseObject(workBook);
                    ReleaseObject(excelApp);

                }

            }
        }
        public void readData()
        {
            try
            {
                listView1.Items.Clear();
                cards.Clear();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fname = openFileDialog1.FileName;

                    excelApp = new Excel.Application();
                    workBook = excelApp.Workbooks.Open(fname);
                    workSheet = workBook.Worksheets.get_Item(1) as Excel.Worksheet;

                    Excel.Range range = workSheet.UsedRange;
                    text_class.Text = workSheet.Name;

                    for (int row = 2; row <= range.Rows.Count; row++)
                    {
                        dynamic name = (dynamic)(range.Cells[row, 2] as Excel.Range).Value2;
                        dynamic school = (dynamic)(range.Cells[row, 3] as Excel.Range).Value2;
                        dynamic grade = (dynamic)(range.Cells[row, 4] as Excel.Range).Value2;
                        dynamic number = (dynamic)(range.Cells[row, 5] as Excel.Range).Value2;
                        Card card = new Card();
                        card.Name = name;
                        card.School = school;
                        card.Grade = grade;
                        card.Number = number;

                        cards.Add(card);

                    }

                    workBook.Close(true);
                    excelApp.Quit();
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = 90;
                    Thread thread1 = new Thread(new ThreadStart(ThreadGOGO));
                    thread1.Start();

                    foreach (dynamic i in cards)
                    {
                        ListViewItem items = new ListViewItem(i.Name);
                        items.SubItems.Add(i.School);
                        items.SubItems.Add(i.Grade);
                        items.SubItems.Add("" + i.Number);

                        listView1.Items.Add(items);
                    }

                    progressBar1.Value = 0;

                }
                 else throw new Exception("취소되었습니다.");
            }
            finally
            {
                ReleaseObject(workBook);
                ReleaseObject(workSheet);
                ReleaseObject(excelApp);
            }
        }
        public void readData2()
        {
            try
            {
                listView2.Items.Clear();
                hcards.Clear();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fname = openFileDialog1.FileName;

                    excelApp = new Excel.Application();
                    workBook = excelApp.Workbooks.Open(fname);
                    workSheet = workBook.Sheets[workBook.Sheets.Count];
                    string classname = workBook.Sheets[1].Name;

                    Excel.Range range = workSheet.UsedRange;
                    text_class2.Text = classname+"반"+workSheet.Name;

                    for (int row = 2; row <= range.Rows.Count; row++)
                    {
                       
                        dynamic name = (dynamic)(range.Cells[row, 2] as Excel.Range).Value2;
                        dynamic school = (dynamic)(range.Cells[row, 3] as Excel.Range).Value2;
                        dynamic grade = (dynamic)(range.Cells[row, 4] as Excel.Range).Value2;
                        dynamic tem = (dynamic)(range.Cells[row, 6] as Excel.Range).Value2;

                            hCard card = new hCard();
                            card.Name = name;
                            card.School = school;
                            card.Grade = grade;
                            card.Tem = tem;

                            hcards.Add(card);
                    }
                    workBook.Close(true);
                    excelApp.Quit();

                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = 90;
                    Thread thread1 = new Thread(new ThreadStart(ThreadGOGO));
                    thread1.Start();
                    foreach (dynamic i in hcards.FindAll(e=>(e.Tem>37)).ToArray())
                    {
                        ListViewItem items = new ListViewItem(i.Name);
                        items.SubItems.Add(i.School);
                        items.SubItems.Add(i.Grade);
                        items.SubItems.Add("" + i.Tem);

                        listView2.Items.Add(items);
                    }
                    progressBar1.Value = 0;

                }
                else throw new Exception("취소되었습니다.");
            }
            finally
            {
                ReleaseObject(workBook);
                ReleaseObject(workSheet);
                ReleaseObject(excelApp);
            }
        }
        private void ThreadGOGO()
        {
           
            progressBar1.Invoke(new ProgvarCall(ProgValueSetting), new object[] { 90 });
          
        }
        private void ProgValueSetting(int var)
        {
            progressBar1.Value = var;
        }

      



        //끝

        //버튼이벤트들
        private void btn_input_Click(object sender, EventArgs e)
        {
            if (text_name.Text != "" && text_school.Text != "" & combo_grade.Text != "" && text_phone.Text != "")
            {
                try
                {
                    Int32.Parse(text_phone.Text);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                    return;
                }
                
                ListViewItem items = new ListViewItem(text_name.Text);
                items.SubItems.Add(text_school.Text);
                items.SubItems.Add(combo_grade.Text);
                items.SubItems.Add(text_phone.Text);

                listView1.Items.Add(items);

                clear_text();
            }
            else MessageBox.Show("학생 정보, 반 이름을 입력해주세요!");
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null)
            {
                if (listView1.SelectedItems.Count != 0)
                {
                    int i = listView1.FocusedItem.Index;
                    listView1.Items.RemoveAt(i);
                    MessageBox.Show("삭제 완료!");
                    clear_text();
                    if (listView1.SelectedItems.Count == 0) flag = 0;
                    else flag = 1;
                }
                else MessageBox.Show("데이터를 선택해주세요");
            }
            else
                MessageBox.Show("데이터를 선택해주세요");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            try
            {
            
                saveData();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                if (MessageBox.Show("기록을 저장하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {

                        saveData();
                       
                      

                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                }
                else
                {
                    try
                    {
                      
                        readData();
                        flag = 1;



                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }

                }

            }
            else
            {
                try
                {
                  
                    readData();
                    flag = 1;


                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }

        }

        private void TeacherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            Form1 main = new Form1();
            main.ShowDialog();
        }

        private void btn_open2_Click(object sender, EventArgs e)
        {
            readData2();
        }
    }
}
