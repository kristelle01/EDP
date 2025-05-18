namespace elemStudentInfo
{
    partial class Subject
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
            this.sub = new System.Windows.Forms.Label();
            this.subID = new System.Windows.Forms.Label();
            this.txtsubID = new System.Windows.Forms.TextBox();
            this.txtsubname = new System.Windows.Forms.TextBox();
            this.subname = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sub);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 74);
            this.panel1.TabIndex = 3;
            // 
            // sub
            // 
            this.sub.AutoSize = true;
            this.sub.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sub.ForeColor = System.Drawing.Color.Firebrick;
            this.sub.Location = new System.Drawing.Point(101, 9);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(219, 57);
            this.sub.TabIndex = 0;
            this.sub.Text = "Subjects";
            // 
            // subID
            // 
            this.subID.AutoSize = true;
            this.subID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subID.Location = new System.Drawing.Point(26, 100);
            this.subID.Name = "subID";
            this.subID.Size = new System.Drawing.Size(93, 23);
            this.subID.TabIndex = 4;
            this.subID.Text = "Subject ID";
            // 
            // txtsubID
            // 
            this.txtsubID.Location = new System.Drawing.Point(160, 96);
            this.txtsubID.Name = "txtsubID";
            this.txtsubID.Size = new System.Drawing.Size(160, 27);
            this.txtsubID.TabIndex = 5;
            // 
            // txtsubname
            // 
            this.txtsubname.Location = new System.Drawing.Point(160, 143);
            this.txtsubname.Name = "txtsubname";
            this.txtsubname.Size = new System.Drawing.Size(160, 27);
            this.txtsubname.TabIndex = 7;
            // 
            // subname
            // 
            this.subname.AutoSize = true;
            this.subname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subname.Location = new System.Drawing.Point(26, 144);
            this.subname.Name = "subname";
            this.subname.Size = new System.Drawing.Size(122, 23);
            this.subname.TabIndex = 6;
            this.subname.Text = "Subject Name";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.SandyBrown;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnadd.Location = new System.Drawing.Point(14, 210);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(105, 41);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.SandyBrown;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnupdate.Location = new System.Drawing.Point(160, 210);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(105, 41);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.SandyBrown;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndelete.Location = new System.Drawing.Point(296, 210);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(105, 41);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(391, 239);
            this.dataGridView1.TabIndex = 11;
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(413, 511);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtsubname);
            this.Controls.Add(this.subname);
            this.Controls.Add(this.txtsubID);
            this.Controls.Add(this.subID);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Subject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.Subject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label sub;
        private System.Windows.Forms.Label subID;
        private System.Windows.Forms.TextBox txtsubID;
        private System.Windows.Forms.TextBox txtsubname;
        private System.Windows.Forms.Label subname;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
