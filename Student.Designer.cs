namespace elemStudentInfo
{
    partial class Student
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
            stu = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(stu);
            panel1.Location = new System.Drawing.Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 74);
            panel1.TabIndex = 2;
            // 
            // stu
            // 
            stu.AutoSize = true;
            stu.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            stu.ForeColor = System.Drawing.Color.Firebrick;
            stu.Location = new System.Drawing.Point(11, 9);
            stu.Name = "stu";
            stu.Size = new System.Drawing.Size(198, 57);
            stu.TabIndex = 0;
            stu.Text = "Student";
            // 
            // Student
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Bisque;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Student";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Student";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label stu;
    }
}