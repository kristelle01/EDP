namespace elemStudentInfo
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.teacher = new System.Windows.Forms.Button();
            this.subject = new System.Windows.Forms.Button();
            this.student = new System.Windows.Forms.Button();
            this.studentInfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 75);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(668, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Information System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.teacher);
            this.panel2.Controls.Add(this.subject);
            this.panel2.Controls.Add(this.student);
            this.panel2.Controls.Add(this.studentInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 515);
            this.panel2.TabIndex = 1;
            // 
            // teacher
            // 
            this.teacher.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.teacher.Location = new System.Drawing.Point(16, 221);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(173, 51);
            this.teacher.TabIndex = 3;
            this.teacher.Text = "Teacher";
            this.teacher.UseVisualStyleBackColor = true;
            // 
            // subject
            // 
            this.subject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.subject.Location = new System.Drawing.Point(16, 154);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(173, 51);
            this.subject.TabIndex = 2;
            this.subject.Text = "Subject";
            this.subject.UseVisualStyleBackColor = true;
            // 
            // student
            // 
            this.student.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.Location = new System.Drawing.Point(16, 88);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(173, 51);
            this.student.TabIndex = 1;
            this.student.Text = "Student";
            this.student.UseVisualStyleBackColor = true;
            // 
            // studentInfo
            // 
            this.studentInfo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentInfo.Location = new System.Drawing.Point(16, 21);
            this.studentInfo.Name = "studentInfo";
            this.studentInfo.Size = new System.Drawing.Size(173, 51);
            this.studentInfo.TabIndex = 0;
            this.studentInfo.Text = "Student Information";
            this.studentInfo.UseVisualStyleBackColor = true;
            this.studentInfo.Click += new System.EventHandler(this.studentInfo_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::elemStudentInfo.Properties.Resources.Untitled_design__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1181, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button studentInfo;
        private System.Windows.Forms.Button teacher;
        private System.Windows.Forms.Button subject;
        private System.Windows.Forms.Button student;
    }
}