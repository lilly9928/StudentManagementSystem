﻿
namespace termproject
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_stu = new System.Windows.Forms.Button();
            this.btn_teacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_stu
            // 
            this.btn_stu.Location = new System.Drawing.Point(148, 225);
            this.btn_stu.Name = "btn_stu";
            this.btn_stu.Size = new System.Drawing.Size(174, 37);
            this.btn_stu.TabIndex = 1;
            this.btn_stu.Text = "학생";
            this.btn_stu.UseVisualStyleBackColor = true;
            this.btn_stu.Click += new System.EventHandler(this.btn_stu_Click);
            // 
            // btn_teacher
            // 
            this.btn_teacher.Location = new System.Drawing.Point(148, 168);
            this.btn_teacher.Name = "btn_teacher";
            this.btn_teacher.Size = new System.Drawing.Size(174, 39);
            this.btn_teacher.TabIndex = 0;
            this.btn_teacher.Text = "선생님";
            this.btn_teacher.UseVisualStyleBackColor = true;
            this.btn_teacher.Click += new System.EventHandler(this.btn_teacher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 404);
            this.Controls.Add(this.btn_stu);
            this.Controls.Add(this.btn_teacher);
            this.Name = "Form1";
            this.Text = "학생관리프로그램";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_teacher;
        private System.Windows.Forms.Button btn_stu;
    }
}

