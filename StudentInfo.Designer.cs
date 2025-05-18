namespace elemStudentInfo
{
    partial class StudentInfo
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
            titleinfo = new System.Windows.Forms.Label();
            sid = new System.Windows.Forms.Label();
            txtid = new System.Windows.Forms.TextBox();
            txtfname = new System.Windows.Forms.TextBox();
            fname = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            delete = new System.Windows.Forms.Button();
            update = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            txtstatus = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtgender = new System.Windows.Forms.TextBox();
            birth = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtbirth = new System.Windows.Forms.TextBox();
            txtlname = new System.Windows.Forms.TextBox();
            lname = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(titleinfo);
            panel1.Location = new System.Drawing.Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 74);
            panel1.TabIndex = 0;
            // 
            // titleinfo
            // 
            titleinfo.AutoSize = true;
            titleinfo.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            titleinfo.ForeColor = System.Drawing.Color.Firebrick;
            titleinfo.Location = new System.Drawing.Point(11, 9);
            titleinfo.Name = "titleinfo";
            titleinfo.Size = new System.Drawing.Size(500, 57);
            titleinfo.TabIndex = 0;
            titleinfo.Text = "Student Information ";
            // 
            // sid
            // 
            sid.AutoSize = true;
            sid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            sid.Location = new System.Drawing.Point(12, 22);
            sid.Name = "sid";
            sid.Size = new System.Drawing.Size(84, 20);
            sid.TabIndex = 1;
            sid.Text = "Student ID";
            // 
            // txtid
            // 
            txtid.Location = new System.Drawing.Point(163, 19);
            txtid.Name = "txtid";
            txtid.Size = new System.Drawing.Size(222, 27);
            txtid.TabIndex = 2;
            txtid.TextChanged += txtid_TextChanged;
            // 
            // txtfname
            // 
            txtfname.Location = new System.Drawing.Point(163, 66);
            txtfname.Name = "txtfname";
            txtfname.Size = new System.Drawing.Size(222, 27);
            txtfname.TabIndex = 4;
            txtfname.TextChanged += textBox1_TextChanged;
            // 
            // fname
            // 
            fname.AutoSize = true;
            fname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            fname.Location = new System.Drawing.Point(12, 69);
            fname.Name = "fname";
            fname.Size = new System.Drawing.Size(145, 20);
            fname.TabIndex = 3;
            fname.Text = "Student First Nmae";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(delete);
            groupBox1.Controls.Add(update);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtstatus);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtgender);
            groupBox1.Controls.Add(birth);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtbirth);
            groupBox1.Controls.Add(txtlname);
            groupBox1.Controls.Add(lname);
            groupBox1.Controls.Add(txtfname);
            groupBox1.Controls.Add(sid);
            groupBox1.Controls.Add(fname);
            groupBox1.Controls.Add(txtid);
            groupBox1.Location = new System.Drawing.Point(4, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(794, 220);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // delete
            // 
            delete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            delete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            delete.Location = new System.Drawing.Point(618, 161);
            delete.Name = "delete";
            delete.Size = new System.Drawing.Size(136, 39);
            delete.TabIndex = 15;
            delete.Text = "DELETE";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // update
            // 
            update.BackColor = System.Drawing.SystemColors.AppWorkspace;
            update.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            update.Location = new System.Drawing.Point(391, 161);
            update.Name = "update";
            update.Size = new System.Drawing.Size(136, 39);
            update.TabIndex = 14;
            update.Text = "UPDATE";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.Location = new System.Drawing.Point(163, 161);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(136, 39);
            button1.TabIndex = 13;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtstatus
            // 
            txtstatus.Location = new System.Drawing.Point(532, 115);
            txtstatus.Name = "txtstatus";
            txtstatus.Size = new System.Drawing.Size(222, 27);
            txtstatus.TabIndex = 12;
            txtstatus.TextChanged += txtstatus_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(400, 118);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 20);
            label1.TabIndex = 11;
            label1.Text = "Status";
            // 
            // txtgender
            // 
            txtgender.Location = new System.Drawing.Point(532, 69);
            txtgender.Name = "txtgender";
            txtgender.Size = new System.Drawing.Size(222, 27);
            txtgender.TabIndex = 10;
            txtgender.TextChanged += txtgender_TextChanged;
            // 
            // birth
            // 
            birth.AutoSize = true;
            birth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            birth.Location = new System.Drawing.Point(400, 25);
            birth.Name = "birth";
            birth.Size = new System.Drawing.Size(100, 20);
            birth.TabIndex = 7;
            birth.Text = "Birth of Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(400, 72);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 20);
            label3.TabIndex = 9;
            label3.Text = "Gender";
            // 
            // txtbirth
            // 
            txtbirth.Location = new System.Drawing.Point(532, 22);
            txtbirth.Name = "txtbirth";
            txtbirth.Size = new System.Drawing.Size(222, 27);
            txtbirth.TabIndex = 8;
            txtbirth.TextChanged += txtbirth_TextChanged;
            // 
            // txtlname
            // 
            txtlname.Location = new System.Drawing.Point(163, 112);
            txtlname.Name = "txtlname";
            txtlname.Size = new System.Drawing.Size(222, 27);
            txtlname.TabIndex = 6;
            txtlname.TextChanged += txtlname_TextChanged;
            // 
            // lname
            // 
            lname.AutoSize = true;
            lname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lname.Location = new System.Drawing.Point(12, 115);
            lname.Name = "lname";
            lname.Size = new System.Drawing.Size(143, 20);
            lname.TabIndex = 5;
            lname.Text = "Student Last Nmae";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(4, 297);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(795, 223);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // StudentInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Bisque;
            ClientSize = new System.Drawing.Size(800, 523);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentInfo";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Form1";
            Load += StudentInfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleinfo;
        private System.Windows.Forms.Label sid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.Label birth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbirth;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}