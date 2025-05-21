namespace elemStudentInfo
{
    partial class Enrollment
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
            enroll = new System.Windows.Forms.Label();
            enrollmentId = new System.Windows.Forms.Label();
            studentID = new System.Windows.Forms.Label();
            classID = new System.Windows.Forms.Label();
            txtenrollmentID = new System.Windows.Forms.TextBox();
            txtstudentID = new System.Windows.Forms.TextBox();
            txtclassID = new System.Windows.Forms.TextBox();
            btnroll = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            txtstatus = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(enroll);
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 74);
            panel1.TabIndex = 1;
            // 
            // enroll
            // 
            enroll.AutoSize = true;
            enroll.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            enroll.ForeColor = System.Drawing.Color.Firebrick;
            enroll.Location = new System.Drawing.Point(11, 9);
            enroll.Name = "enroll";
            enroll.Size = new System.Drawing.Size(287, 57);
            enroll.TabIndex = 0;
            enroll.Text = "Enrollment";
            enroll.Click += enroll_Click;
            // 
            // enrollmentId
            // 
            enrollmentId.AutoSize = true;
            enrollmentId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            enrollmentId.Location = new System.Drawing.Point(24, 101);
            enrollmentId.Name = "enrollmentId";
            enrollmentId.Size = new System.Drawing.Size(121, 23);
            enrollmentId.TabIndex = 2;
            enrollmentId.Text = "Enrollment ID";
            // 
            // studentID
            // 
            studentID.AutoSize = true;
            studentID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            studentID.Location = new System.Drawing.Point(24, 148);
            studentID.Name = "studentID";
            studentID.Size = new System.Drawing.Size(97, 23);
            studentID.TabIndex = 3;
            studentID.Text = "Student ID";
            // 
            // classID
            // 
            classID.AutoSize = true;
            classID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            classID.Location = new System.Drawing.Point(413, 102);
            classID.Name = "classID";
            classID.Size = new System.Drawing.Size(72, 23);
            classID.TabIndex = 4;
            classID.Text = "Class ID";
            // 
            // txtenrollmentID
            // 
            txtenrollmentID.Location = new System.Drawing.Point(151, 97);
            txtenrollmentID.Name = "txtenrollmentID";
            txtenrollmentID.Size = new System.Drawing.Size(125, 27);
            txtenrollmentID.TabIndex = 6;
            // 
            // txtstudentID
            // 
            txtstudentID.Location = new System.Drawing.Point(151, 147);
            txtstudentID.Name = "txtstudentID";
            txtstudentID.Size = new System.Drawing.Size(125, 27);
            txtstudentID.TabIndex = 7;
            // 
            // txtclassID
            // 
            txtclassID.Location = new System.Drawing.Point(502, 101);
            txtclassID.Name = "txtclassID";
            txtclassID.Size = new System.Drawing.Size(125, 27);
            txtclassID.TabIndex = 8;
            // 
            // btnroll
            // 
            btnroll.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btnroll.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnroll.Location = new System.Drawing.Point(286, 196);
            btnroll.Name = "btnroll";
            btnroll.Size = new System.Drawing.Size(142, 38);
            btnroll.TabIndex = 10;
            btnroll.Text = "ENROLL";
            btnroll.UseVisualStyleBackColor = false;
            btnroll.Click += btnroll_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(1, 256);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(689, 194);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtstatus
            // 
            txtstatus.Location = new System.Drawing.Point(502, 148);
            txtstatus.Name = "txtstatus";
            txtstatus.Size = new System.Drawing.Size(125, 27);
            txtstatus.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(413, 149);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 23);
            label1.TabIndex = 12;
            label1.Text = "Status";
            // 
            // Enrollment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Bisque;
            ClientSize = new System.Drawing.Size(694, 453);
            Controls.Add(txtstatus);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnroll);
            Controls.Add(txtclassID);
            Controls.Add(txtstudentID);
            Controls.Add(txtenrollmentID);
            Controls.Add(classID);
            Controls.Add(studentID);
            Controls.Add(enrollmentId);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Enrollment";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Enrollment";
            Load += Enrollment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label enroll;
        private System.Windows.Forms.Label enrollmentId;
        private System.Windows.Forms.Label studentID;
        private System.Windows.Forms.Label classID;
        private System.Windows.Forms.TextBox txtenrollmentID;
        private System.Windows.Forms.TextBox txtstudentID;
        private System.Windows.Forms.TextBox txtclassID;
        private System.Windows.Forms.Button btnroll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Label label1;
    }
}