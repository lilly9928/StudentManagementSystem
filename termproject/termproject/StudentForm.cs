using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using MyExcelClassLibrary;
using MetroFramework.Forms;

namespace termproject
{
    public partial class StudentForm : MetroForm, IFileIO
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        class Card
        {
            public dynamic StuNum;
            public dynamic Name;
            public dynamic School;
            public dynamic Grade;
            public dynamic Number;
            public dynamic Tem;
        }

        int flag = 0;
        string fname = "";
      
        List<dynamic> cards = new List<dynamic>();

        Excel.Application excelApp = null;
        Excel.Workbook workBook = null;
        Excel.Worksheet workSheet = null;
        Excel.Worksheet teacherworkSheet = null;


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
            excelApp = new Excel.Application();
            workBook = excelApp.Workbooks.Open(fname);

            workSheet = workBook.Sheets[workBook.Sheets.Count];
            if(workSheet.Name!= DateTime.Now.ToString("MM-dd"))
            {
                workSheet = workBook.Worksheets.Add(After: workBook.Sheets[workBook.Sheets.Count]) as Excel.Worksheet;
                workSheet.Name = DateTime.Now.ToString("MM-dd");
                workSheet.Cells[1, 1] = "학생번호";
                workSheet.Cells[1, 2] = "이름";
                workSheet.Cells[1, 3] = "학교";
                workSheet.Cells[1, 4] = "학년";
                workSheet.Cells[1, 5] = "전화번호";
                workSheet.Cells[1, 6] = "체온";
            }
           
            Excel.Range range = workSheet.UsedRange;

            var student = (from card in cards
                           where card.StuNum == text_stunum.Text
                           select new
                           {
                               stunum = card.StuNum,
                               name = card.Name,
                               school = card.School,
                               number = card.Number,
                               grade = card.Grade,
                               Tem = text_tem.Text

                           });

            int i = range.Rows.Count;
            
            foreach (var stu in student)
            { 
              
                    workSheet.Cells[i + 1, 1] = stu.stunum;
                    workSheet.Cells[i + 1, 2] = stu.name;
                    workSheet.Cells[i + 1, 3] = stu.school;
                    workSheet.Cells[i + 1, 4] = stu.grade;
                    workSheet.Cells[i + 1, 5] = stu.number;
                    workSheet.Cells[i + 1, 6] = stu.Tem;
                
            }
            workSheet.Columns.AutoFit();
            flag = 1;

            workBook.SaveAs(fname);
            workBook.Close(true);
            excelApp.Quit();
        }
        public void readData()
        {   
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fname = openFileDialog1.FileName;
                text_class.Text = fname.Split('\\')[fname.Split('\\').Length - 1];

                try
                {
                    excelApp = new Excel.Application();
                    workBook = excelApp.Workbooks.Open(fname);
                    teacherworkSheet = workBook.Worksheets.get_Item(1) as Excel.Worksheet;
                    Excel.Range range = teacherworkSheet.UsedRange;

                    for (int row = 2; row <= range.Rows.Count; row++)
                    {
                        dynamic stnum = (dynamic)(range.Cells[row, 1] as Excel.Range).Value2;
                        dynamic name = (dynamic)(range.Cells[row, 2] as Excel.Range).Value2;
                        dynamic school = (dynamic)(range.Cells[row, 3] as Excel.Range).Value2;
                        dynamic grade = (dynamic)(range.Cells[row, 4] as Excel.Range).Value2;
                        dynamic number = (dynamic)(range.Cells[row, 5] as Excel.Range).Value2;

                        Card card = new Card();
                        card.StuNum = stnum + "";
                        card.Name = name;
                        card.School = school;
                        card.Grade = grade;
                        card.Number = number;
                        card.Tem = "0";

                        cards.Add(card);

                    }
                    workBook.Close(true);
                    excelApp.Quit();
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    ReleaseObject(workSheet);
                    ReleaseObject(workBook);
                    ReleaseObject(excelApp);
                }
            }
        }
        private void btn_open_Click(object sender, EventArgs e)
        {
            try
            {
                readData();
                panel1.Visible = false;
                panel2.Visible = true;
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            } 
       
        }

        private void btn_came_Click(object sender, EventArgs e)
        {
            foreach (var card in cards)
            {
                if (card.StuNum ==text_stunum.Text)
                {
                    panel2.Visible = false;
                    panel3.Visible = true;
                    return;
                    
                }
            }
             MessageBox.Show("학생정보가 없습니다.");
            

        }

        private void btn_savetem_Click(object sender, EventArgs e)
        {
            try
            {
                saveData();
                bool check = CheckClass.isTem37(text_tem.Text);
                MessageBox.Show("등록되었습니다!");

                if (check)
                {
                    MessageBox.Show(" 체온이 높습니다. 귀가해주십시오. ");
                }

                panel3.Visible = false;
                panel2.Visible = true;
                text_stunum.Text = "";
                text_tem.Text = "";


            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            Form1 main = new Form1();
            main.ShowDialog();
        }
    }
}
