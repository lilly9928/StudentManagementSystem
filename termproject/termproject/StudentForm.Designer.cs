
namespace termproject
{
    partial class StudentForm
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
            this.text_class = new System.Windows.Forms.TextBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.text_stunum = new System.Windows.Forms.TextBox();
            this.btn_came = new System.Windows.Forms.Button();
            this.text_tem = new System.Windows.Forms.TextBox();
            this.btn_savetem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_class
            // 
            this.text_class.Location = new System.Drawing.Point(18, 60);
            this.text_class.Name = "text_class";
            this.text_class.Size = new System.Drawing.Size(121, 21);
            this.text_class.TabIndex = 0;
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_open.ForeColor = System.Drawing.Color.Black;
            this.btn_open.Location = new System.Drawing.Point(159, 58);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "열기";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // text_stunum
            // 
            this.text_stunum.Location = new System.Drawing.Point(23, 56);
            this.text_stunum.Name = "text_stunum";
            this.text_stunum.Size = new System.Drawing.Size(121, 21);
            this.text_stunum.TabIndex = 2;
            // 
            // btn_came
            // 
            this.btn_came.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_came.Location = new System.Drawing.Point(164, 54);
            this.btn_came.Name = "btn_came";
            this.btn_came.Size = new System.Drawing.Size(75, 23);
            this.btn_came.TabIndex = 3;
            this.btn_came.Text = "출석";
            this.btn_came.UseVisualStyleBackColor = false;
            this.btn_came.Click += new System.EventHandler(this.btn_came_Click);
            // 
            // text_tem
            // 
            this.text_tem.Location = new System.Drawing.Point(23, 58);
            this.text_tem.Name = "text_tem";
            this.text_tem.Size = new System.Drawing.Size(121, 21);
            this.text_tem.TabIndex = 4;
            // 
            // btn_savetem
            // 
            this.btn_savetem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_savetem.Location = new System.Drawing.Point(164, 56);
            this.btn_savetem.Name = "btn_savetem";
            this.btn_savetem.Size = new System.Drawing.Size(75, 23);
            this.btn_savetem.TabIndex = 5;
            this.btn_savetem.Text = "등록";
            this.btn_savetem.UseVisualStyleBackColor = false;
            this.btn_savetem.Click += new System.EventHandler(this.btn_savetem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.text_stunum);
            this.panel2.Controls.Add(this.btn_came);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 196);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.btn_savetem);
            this.panel3.Controls.Add(this.text_tem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(20, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 196);
            this.panel3.TabIndex = 8;
            this.panel3.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_open);
            this.panel1.Controls.Add(this.text_class);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 196);
            this.panel1.TabIndex = 9;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 276);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "StudentForm";
            this.Text = "학생 페이지";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentForm_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox text_class;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox text_stunum;
        private System.Windows.Forms.Button btn_came;
        private System.Windows.Forms.TextBox text_tem;
        private System.Windows.Forms.Button btn_savetem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}