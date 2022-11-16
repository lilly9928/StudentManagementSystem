using System;

namespace termproject
{
    partial class TeacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.plus = new System.Windows.Forms.TabPage();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.text_class = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_grade = new System.Windows.Forms.ComboBox();
            this.text_phone = new System.Windows.Forms.TextBox();
            this.text_school = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_school = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_open2 = new System.Windows.Forms.Button();
            this.text_class2 = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.plus.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.plus);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(67, 62);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(721, 510);
            this.tabControl1.TabIndex = 0;
            // 
            // plus
            // 
            this.plus.AllowDrop = true;
            this.plus.Controls.Add(this.btn_del);
            this.plus.Controls.Add(this.btn_open);
            this.plus.Controls.Add(this.label6);
            this.plus.Controls.Add(this.text_class);
            this.plus.Controls.Add(this.btn_save);
            this.plus.Controls.Add(this.label5);
            this.plus.Controls.Add(this.label4);
            this.plus.Controls.Add(this.label3);
            this.plus.Controls.Add(this.label2);
            this.plus.Controls.Add(this.label1);
            this.plus.Controls.Add(this.combo_grade);
            this.plus.Controls.Add(this.text_phone);
            this.plus.Controls.Add(this.text_school);
            this.plus.Controls.Add(this.text_name);
            this.plus.Controls.Add(this.btn_input);
            this.plus.Controls.Add(this.listView1);
            this.plus.Location = new System.Drawing.Point(4, 22);
            this.plus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plus.Name = "plus";
            this.plus.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plus.Size = new System.Drawing.Size(713, 484);
            this.plus.TabIndex = 0;
            this.plus.Text = "학생등록";
            this.plus.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(407, 408);
            this.btn_del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 18);
            this.btn_del.TabIndex = 16;
            this.btn_del.Text = "삭제";
            this.btn_del.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(306, 12);
            this.btn_open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(98, 22);
            this.btn_open.TabIndex = 15;
            this.btn_open.Text = "파일 불러오기";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "반";
            // 
            // text_class
            // 
            this.text_class.Location = new System.Drawing.Point(25, 13);
            this.text_class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_class.Name = "text_class";
            this.text_class.Size = new System.Drawing.Size(100, 21);
            this.text_class.TabIndex = 13;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(617, 282);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 18);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "저장";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "전화번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "학년";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "학교";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "학생정보 입력";
            // 
            // combo_grade
            // 
            this.combo_grade.FormattingEnabled = true;
            this.combo_grade.Items.AddRange(new object[] {
            "예비초1",
            "초등1",
            "초등2",
            "초등3",
            "초등4",
            "초등5",
            "초등6",
            "중학1",
            "중학2",
            "중학3",
            "고등1",
            "고등2",
            "고등3"});
            this.combo_grade.Location = new System.Drawing.Point(496, 212);
            this.combo_grade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_grade.Name = "combo_grade";
            this.combo_grade.Size = new System.Drawing.Size(140, 20);
            this.combo_grade.TabIndex = 6;
            // 
            // text_phone
            // 
            this.text_phone.Location = new System.Drawing.Point(496, 245);
            this.text_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_phone.Name = "text_phone";
            this.text_phone.Size = new System.Drawing.Size(196, 21);
            this.text_phone.TabIndex = 5;
            // 
            // text_school
            // 
            this.text_school.Location = new System.Drawing.Point(496, 179);
            this.text_school.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_school.Name = "text_school";
            this.text_school.Size = new System.Drawing.Size(140, 21);
            this.text_school.TabIndex = 3;
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(495, 146);
            this.text_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(140, 21);
            this.text_name.TabIndex = 2;
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(536, 282);
            this.btn_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(75, 18);
            this.btn_input.TabIndex = 1;
            this.btn_input.Text = "입력";
            this.btn_input.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_name,
            this.col_school,
            this.col_grade,
            this.col_num});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 38);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(366, 388);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // col_name
            // 
            this.col_name.Name = "col_name";
            this.col_name.Text = "이름";
            this.col_name.Width = 70;
            // 
            // col_school
            // 
            this.col_school.Name = "col_school";
            this.col_school.Text = "학교";
            this.col_school.Width = 100;
            // 
            // col_grade
            // 
            this.col_grade.Text = "학년";
            // 
            // col_num
            // 
            this.col_num.Text = "전화번호";
            this.col_num.Width = 130;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btn_open2);
            this.tabPage2.Controls.Add(this.text_class2);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(713, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "학생관리";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "12-07일";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "체온이 37도 이상인 학생";
            // 
            // btn_open2
            // 
            this.btn_open2.Location = new System.Drawing.Point(532, 40);
            this.btn_open2.Name = "btn_open2";
            this.btn_open2.Size = new System.Drawing.Size(75, 23);
            this.btn_open2.TabIndex = 4;
            this.btn_open2.Text = "불러오기";
            this.btn_open2.UseVisualStyleBackColor = true;
            this.btn_open2.Click += new System.EventHandler(this.btn_open2_Click);
            // 
            // text_class2
            // 
            this.text_class2.Location = new System.Drawing.Point(393, 40);
            this.text_class2.Name = "text_class2";
            this.text_class2.Size = new System.Drawing.Size(133, 21);
            this.text_class2.TabIndex = 3;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(104, 40);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(252, 427);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "학교";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "학년";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "체온";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(422, 577);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(366, 16);
            this.progressBar1.TabIndex = 17;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 613);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeacherForm";
            this.Text = "선생님 페이지";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.plus.ResumeLayout(false);
            this.plus.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage plus;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_school;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.TextBox text_name;

        private System.Windows.Forms.ColumnHeader col_num;
        private System.Windows.Forms.ComboBox combo_grade;
        private System.Windows.Forms.TextBox text_phone;
        private System.Windows.Forms.TextBox text_school;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader col_grade;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_class;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_open2;
        private System.Windows.Forms.TextBox text_class2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

    }
}