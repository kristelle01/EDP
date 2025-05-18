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
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            grade = new System.Windows.Forms.Button();
            teacher = new System.Windows.Forms.Button();
            subject = new System.Windows.Forms.Button();
            student = new System.Windows.Forms.Button();
            studentInfo = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Bisque;
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1234, 86);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.SaddleBrown;
            label1.Location = new System.Drawing.Point(12, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(668, 57);
            label1.TabIndex = 0;
            label1.Text = "Student Information System";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Bisque;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(grade);
            panel2.Controls.Add(teacher);
            panel2.Controls.Add(subject);
            panel2.Controls.Add(student);
            panel2.Controls.Add(studentInfo);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 86);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(205, 612);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.Location = new System.Drawing.Point(12, 106);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(173, 64);
            button1.TabIndex = 5;
            button1.Text = "Enrollment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // grade
            // 
            grade.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            grade.Location = new System.Drawing.Point(12, 450);
            grade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grade.Name = "grade";
            grade.Size = new System.Drawing.Size(173, 64);
            grade.TabIndex = 4;
            grade.Text = "Grade";
            grade.UseVisualStyleBackColor = true;
            // 
            // teacher
            // 
            teacher.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            teacher.Location = new System.Drawing.Point(12, 361);
            teacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            teacher.Name = "teacher";
            teacher.Size = new System.Drawing.Size(173, 64);
            teacher.TabIndex = 3;
            teacher.Text = "Teacher";
            teacher.UseVisualStyleBackColor = true;
            teacher.Click += teacher_Click;
            // 
            // subject
            // 
            subject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            subject.Location = new System.Drawing.Point(12, 277);
            subject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            subject.Name = "subject";
            subject.Size = new System.Drawing.Size(173, 64);
            subject.TabIndex = 2;
            subject.Text = "Subject";
            subject.UseVisualStyleBackColor = true;
            subject.Click += subject_Click;
            // 
            // student
            // 
            student.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            student.Location = new System.Drawing.Point(12, 195);
            student.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            student.Name = "student";
            student.Size = new System.Drawing.Size(173, 64);
            student.TabIndex = 1;
            student.Text = "Student";
            student.UseVisualStyleBackColor = true;
            // 
            // studentInfo
            // 
            studentInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            studentInfo.Location = new System.Drawing.Point(12, 21);
            studentInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            studentInfo.Name = "studentInfo";
            studentInfo.Size = new System.Drawing.Size(173, 64);
            studentInfo.TabIndex = 0;
            studentInfo.Text = "Student Information";
            studentInfo.UseVisualStyleBackColor = true;
            studentInfo.Click += studentInfo_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__2_;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1234, 698);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button studentInfo;
        private System.Windows.Forms.Button teacher;
        private System.Windows.Forms.Button subject;
        private System.Windows.Forms.Button student;
        private System.Windows.Forms.Button grade;
        private System.Windows.Forms.Button button1;
    }
}