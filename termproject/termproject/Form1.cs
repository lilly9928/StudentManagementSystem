using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace termproject
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_teacher_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TeacherForm teacherform = new TeacherForm();
            teacherform.ShowDialog();
        }

        private void btn_stu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StudentForm studentform = new StudentForm();
            studentform.ShowDialog();
        }
    }
}
