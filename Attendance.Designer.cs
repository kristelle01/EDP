namespace elemStudentInfo
{
    partial class Attendance
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
            sub = new System.Windows.Forms.Label();
            btndelete = new System.Windows.Forms.Button();
            btnupdate = new System.Windows.Forms.Button();
            btnadd = new System.Windows.Forms.Button();
            txtstatus = new System.Windows.Forms.TextBox();
            status = new System.Windows.Forms.Label();
            txtclassID = new System.Windows.Forms.TextBox();
            classID = new System.Windows.Forms.Label();
            txtstudentID = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtattendanceID = new System.Windows.Forms.TextBox();
            clasID = new System.Windows.Forms.Label();
            txtclassname = new System.Windows.Forms.TextBox();
            classname = new System.Windows.Forms.Label();
            txtstuname = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            txtattDate = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(sub);
            panel1.Location = new System.Drawing.Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 74);
            panel1.TabIndex = 5;
            // 
            // sub
            // 
            sub.AutoSize = true;
            sub.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold);
            sub.ForeColor = System.Drawing.Color.Firebrick;
            sub.Location = new System.Drawing.Point(204, 9);
            sub.Name = "sub";
            sub.Size = new System.Drawing.Size(286, 57);
            sub.TabIndex = 0;
            sub.Text = "Attendance";
            // 
            // btndelete
            // 
            btndelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btndelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btndelete.Location = new System.Drawing.Point(458, 276);
            btndelete.Name = "btndelete";
            btndelete.Size = new System.Drawing.Size(116, 37);
            btndelete.TabIndex = 26;
            btndelete.Text = "DELETE";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btnupdate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnupdate.Location = new System.Drawing.Point(301, 276);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new System.Drawing.Size(116, 37);
            btnupdate.TabIndex = 25;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnadd
            // 
            btnadd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btnadd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnadd.Location = new System.Drawing.Point(147, 276);
            btnadd.Name = "btnadd";
            btnadd.Size = new System.Drawing.Size(116, 37);
            btnadd.TabIndex = 24;
            btnadd.Text = "ADD";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // txtstatus
            // 
            txtstatus.Location = new System.Drawing.Point(163, 223);
            txtstatus.Name = "txtstatus";
            txtstatus.Size = new System.Drawing.Size(143, 27);
            txtstatus.TabIndex = 23;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            status.Location = new System.Drawing.Point(32, 227);
            status.Name = "status";
            status.Size = new System.Drawing.Size(60, 23);
            status.TabIndex = 22;
            status.Text = "Status";
            // 
            // txtclassID
            // 
            txtclassID.Location = new System.Drawing.Point(163, 181);
            txtclassID.Name = "txtclassID";
            txtclassID.Size = new System.Drawing.Size(143, 27);
            txtclassID.TabIndex = 21;
            // 
            // classID
            // 
            classID.AutoSize = true;
            classID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            classID.Location = new System.Drawing.Point(28, 185);
            classID.Name = "classID";
            classID.Size = new System.Drawing.Size(72, 23);
            classID.TabIndex = 20;
            classID.Text = "Class ID";
            // 
            // txtstudentID
            // 
            txtstudentID.Location = new System.Drawing.Point(163, 139);
            txtstudentID.Name = "txtstudentID";
            txtstudentID.Size = new System.Drawing.Size(143, 27);
            txtstudentID.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(28, 143);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 23);
            label1.TabIndex = 18;
            label1.Text = "Student ID";
            // 
            // txtattendanceID
            // 
            txtattendanceID.Location = new System.Drawing.Point(163, 100);
            txtattendanceID.Name = "txtattendanceID";
            txtattendanceID.Size = new System.Drawing.Size(143, 27);
            txtattendanceID.TabIndex = 17;
            // 
            // clasID
            // 
            clasID.AutoSize = true;
            clasID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            clasID.Location = new System.Drawing.Point(28, 100);
            clasID.Name = "clasID";
            clasID.Size = new System.Drawing.Size(125, 23);
            clasID.TabIndex = 16;
            clasID.Text = "Attendance ID";
            // 
            // txtclassname
            // 
            txtclassname.Location = new System.Drawing.Point(484, 180);
            txtclassname.Name = "txtclassname";
            txtclassname.Size = new System.Drawing.Size(143, 27);
            txtclassname.TabIndex = 32;
            // 
            // classname
            // 
            classname.AutoSize = true;
            classname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            classname.Location = new System.Drawing.Point(337, 184);
            classname.Name = "classname";
            classname.Size = new System.Drawing.Size(101, 23);
            classname.TabIndex = 31;
            classname.Text = "Class Name";
            // 
            // txtstuname
            // 
            txtstuname.Location = new System.Drawing.Point(484, 138);
            txtstuname.Name = "txtstuname";
            txtstuname.Size = new System.Drawing.Size(143, 27);
            txtstuname.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(333, 142);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(126, 23);
            label3.TabIndex = 29;
            label3.Text = "Student Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(333, 100);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(145, 23);
            label4.TabIndex = 27;
            label4.Text = "Attendance Date";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(11, 320);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(667, 184);
            dataGridView1.TabIndex = 33;
            // 
            // txtattDate
            // 
            txtattDate.Location = new System.Drawing.Point(484, 96);
            txtattDate.Name = "txtattDate";
            txtattDate.Size = new System.Drawing.Size(143, 27);
            txtattDate.TabIndex = 35;
            // 
            // Attendance
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Bisque;
            ClientSize = new System.Drawing.Size(689, 509);
            Controls.Add(txtattDate);
            Controls.Add(dataGridView1);
            Controls.Add(txtclassname);
            Controls.Add(classname);
            Controls.Add(txtstuname);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btnadd);
            Controls.Add(txtstatus);
            Controls.Add(status);
            Controls.Add(txtclassID);
            Controls.Add(classID);
            Controls.Add(txtstudentID);
            Controls.Add(label1);
            Controls.Add(txtattendanceID);
            Controls.Add(clasID);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Attendance";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Attendance";
            Load += Attendance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label sub;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox txtclassID;
        private System.Windows.Forms.Label classID;
        private System.Windows.Forms.TextBox txtstudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtattendanceID;
        private System.Windows.Forms.Label clasID;
        private System.Windows.Forms.TextBox txtclassname;
        private System.Windows.Forms.Label classname;
        private System.Windows.Forms.TextBox txtstuname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtattDate;
    }
}