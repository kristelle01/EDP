namespace elemStudentInfo
{
    partial class Grade
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
            gr = new System.Windows.Forms.Label();
            grID = new System.Windows.Forms.Label();
            txtgradeID = new System.Windows.Forms.TextBox();
            txtstudentID = new System.Windows.Forms.TextBox();
            stuID = new System.Windows.Forms.Label();
            txtgrade = new System.Windows.Forms.TextBox();
            gra = new System.Windows.Forms.Label();
            txtsubID = new System.Windows.Forms.TextBox();
            subID = new System.Windows.Forms.Label();
            getgrade = new System.Windows.Forms.Button();
            btnadd = new System.Windows.Forms.Button();
            btndelete = new System.Windows.Forms.Button();
            btnupdate = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(gr);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 74);
            panel1.TabIndex = 5;
            // 
            // gr
            // 
            gr.AutoSize = true;
            gr.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold);
            gr.ForeColor = System.Drawing.Color.Firebrick;
            gr.Location = new System.Drawing.Point(11, 9);
            gr.Name = "gr";
            gr.Size = new System.Drawing.Size(169, 57);
            gr.TabIndex = 0;
            gr.Text = "Grade";
            // 
            // grID
            // 
            grID.AutoSize = true;
            grID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            grID.Location = new System.Drawing.Point(24, 92);
            grID.Name = "grID";
            grID.Size = new System.Drawing.Size(87, 25);
            grID.TabIndex = 6;
            grID.Text = "Grade ID";
            // 
            // txtgradeID
            // 
            txtgradeID.Location = new System.Drawing.Point(152, 92);
            txtgradeID.Name = "txtgradeID";
            txtgradeID.Size = new System.Drawing.Size(155, 27);
            txtgradeID.TabIndex = 7;
            // 
            // txtstudentID
            // 
            txtstudentID.Location = new System.Drawing.Point(152, 140);
            txtstudentID.Name = "txtstudentID";
            txtstudentID.Size = new System.Drawing.Size(155, 27);
            txtstudentID.TabIndex = 9;
            // 
            // stuID
            // 
            stuID.AutoSize = true;
            stuID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            stuID.Location = new System.Drawing.Point(24, 140);
            stuID.Name = "stuID";
            stuID.Size = new System.Drawing.Size(103, 25);
            stuID.TabIndex = 8;
            stuID.Text = "Student ID";
            // 
            // txtgrade
            // 
            txtgrade.Location = new System.Drawing.Point(498, 141);
            txtgrade.Name = "txtgrade";
            txtgrade.Size = new System.Drawing.Size(155, 27);
            txtgrade.TabIndex = 13;
            // 
            // gra
            // 
            gra.AutoSize = true;
            gra.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            gra.Location = new System.Drawing.Point(370, 141);
            gra.Name = "gra";
            gra.Size = new System.Drawing.Size(63, 25);
            gra.TabIndex = 12;
            gra.Text = "Grade";
            // 
            // txtsubID
            // 
            txtsubID.Location = new System.Drawing.Point(498, 93);
            txtsubID.Name = "txtsubID";
            txtsubID.Size = new System.Drawing.Size(155, 27);
            txtsubID.TabIndex = 11;
            // 
            // subID
            // 
            subID.AutoSize = true;
            subID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            subID.Location = new System.Drawing.Point(370, 93);
            subID.Name = "subID";
            subID.Size = new System.Drawing.Size(99, 25);
            subID.TabIndex = 10;
            subID.Text = "Subject ID";
            // 
            // getgrade
            // 
            getgrade.BackColor = System.Drawing.SystemColors.AppWorkspace;
            getgrade.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            getgrade.Location = new System.Drawing.Point(29, 195);
            getgrade.Name = "getgrade";
            getgrade.Size = new System.Drawing.Size(151, 38);
            getgrade.TabIndex = 14;
            getgrade.Text = "GET GRADE";
            getgrade.UseVisualStyleBackColor = false;
            getgrade.Click += getgrade_Click;
            // 
            // btnadd
            // 
            btnadd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btnadd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnadd.Location = new System.Drawing.Point(218, 195);
            btnadd.Name = "btnadd";
            btnadd.Size = new System.Drawing.Size(151, 38);
            btnadd.TabIndex = 15;
            btnadd.Text = "ADD";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btndelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btndelete.Location = new System.Drawing.Point(621, 195);
            btndelete.Name = "btndelete";
            btndelete.Size = new System.Drawing.Size(151, 38);
            btndelete.TabIndex = 17;
            btndelete.Text = "DELETE";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click_1;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btnupdate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnupdate.Location = new System.Drawing.Point(415, 195);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new System.Drawing.Size(151, 38);
            btnupdate.TabIndex = 16;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(6, 248);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(788, 259);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Grade
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Bisque;
            ClientSize = new System.Drawing.Size(800, 515);
            Controls.Add(dataGridView1);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btnadd);
            Controls.Add(getgrade);
            Controls.Add(txtgrade);
            Controls.Add(gra);
            Controls.Add(txtsubID);
            Controls.Add(subID);
            Controls.Add(txtstudentID);
            Controls.Add(stuID);
            Controls.Add(txtgradeID);
            Controls.Add(grID);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Grade";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Grade";
            Load += Grade_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label gr;
        private System.Windows.Forms.Label grID;
        private System.Windows.Forms.TextBox txtgradeID;
        private System.Windows.Forms.TextBox txtstudentID;
        private System.Windows.Forms.Label stuID;
        private System.Windows.Forms.TextBox txtgrade;
        private System.Windows.Forms.Label gra;
        private System.Windows.Forms.TextBox txtsubID;
        private System.Windows.Forms.Label subID;
        private System.Windows.Forms.Button getgrade;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}