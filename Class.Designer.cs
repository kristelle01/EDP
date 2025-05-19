namespace elemStudentInfo
{
    partial class Class
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
            clasID = new System.Windows.Forms.Label();
            txtclassID = new System.Windows.Forms.TextBox();
            txtclassname = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtsubID = new System.Windows.Forms.TextBox();
            subID = new System.Windows.Forms.Label();
            txtteachID = new System.Windows.Forms.TextBox();
            teachID = new System.Windows.Forms.Label();
            btnadd = new System.Windows.Forms.Button();
            btnupdate = new System.Windows.Forms.Button();
            btndelete = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(sub);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 74);
            panel1.TabIndex = 4;
            // 
            // sub
            // 
            sub.AutoSize = true;
            sub.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold);
            sub.ForeColor = System.Drawing.Color.Firebrick;
            sub.Location = new System.Drawing.Point(204, 9);
            sub.Name = "sub";
            sub.Size = new System.Drawing.Size(205, 57);
            sub.TabIndex = 0;
            sub.Text = "Classes";
            // 
            // clasID
            // 
            clasID.AutoSize = true;
            clasID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            clasID.Location = new System.Drawing.Point(32, 104);
            clasID.Name = "clasID";
            clasID.Size = new System.Drawing.Size(72, 23);
            clasID.TabIndex = 5;
            clasID.Text = "Class ID";
            // 
            // txtclassID
            // 
            txtclassID.Location = new System.Drawing.Point(139, 100);
            txtclassID.Name = "txtclassID";
            txtclassID.Size = new System.Drawing.Size(143, 27);
            txtclassID.TabIndex = 6;
            // 
            // txtclassname
            // 
            txtclassname.Location = new System.Drawing.Point(139, 143);
            txtclassname.Name = "txtclassname";
            txtclassname.Size = new System.Drawing.Size(143, 27);
            txtclassname.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(32, 147);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(101, 23);
            label1.TabIndex = 7;
            label1.Text = "Class Name";
            // 
            // txtsubID
            // 
            txtsubID.Location = new System.Drawing.Point(423, 143);
            txtsubID.Name = "txtsubID";
            txtsubID.Size = new System.Drawing.Size(143, 27);
            txtsubID.TabIndex = 12;
            // 
            // subID
            // 
            subID.AutoSize = true;
            subID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            subID.Location = new System.Drawing.Point(316, 147);
            subID.Name = "subID";
            subID.Size = new System.Drawing.Size(93, 23);
            subID.TabIndex = 11;
            subID.Text = "Subject ID";
            // 
            // txtteachID
            // 
            txtteachID.Location = new System.Drawing.Point(423, 100);
            txtteachID.Name = "txtteachID";
            txtteachID.Size = new System.Drawing.Size(143, 27);
            txtteachID.TabIndex = 10;
            // 
            // teachID
            // 
            teachID.AutoSize = true;
            teachID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            teachID.Location = new System.Drawing.Point(316, 104);
            teachID.Name = "teachID";
            teachID.Size = new System.Drawing.Size(93, 23);
            teachID.TabIndex = 9;
            teachID.Text = "Teacher ID";
            // 
            // btnadd
            // 
            btnadd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btnadd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnadd.Location = new System.Drawing.Point(139, 191);
            btnadd.Name = "btnadd";
            btnadd.Size = new System.Drawing.Size(116, 37);
            btnadd.TabIndex = 13;
            btnadd.Text = "ADD";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btnupdate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnupdate.Location = new System.Drawing.Point(293, 191);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new System.Drawing.Size(116, 37);
            btnupdate.TabIndex = 14;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btndelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btndelete.Location = new System.Drawing.Point(450, 191);
            btndelete.Name = "btndelete";
            btndelete.Size = new System.Drawing.Size(116, 37);
            btndelete.TabIndex = 15;
            btndelete.Text = "DELETE";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(8, 243);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(602, 198);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Class
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Bisque;
            ClientSize = new System.Drawing.Size(617, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btnadd);
            Controls.Add(txtsubID);
            Controls.Add(subID);
            Controls.Add(txtteachID);
            Controls.Add(teachID);
            Controls.Add(txtclassname);
            Controls.Add(label1);
            Controls.Add(txtclassID);
            Controls.Add(clasID);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Class";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Class";
            Load += Class_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label sub;
        private System.Windows.Forms.Label clasID;
        private System.Windows.Forms.TextBox txtclassID;
        private System.Windows.Forms.TextBox txtclassname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsubID;
        private System.Windows.Forms.Label subID;
        private System.Windows.Forms.TextBox txtteachID;
        private System.Windows.Forms.Label teachID;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}