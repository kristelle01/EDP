namespace elemStudentInfo
{
    partial class LoginForm
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
            grouplogin = new System.Windows.Forms.GroupBox();
            forgotpass = new System.Windows.Forms.LinkLabel();
            label1 = new System.Windows.Forms.Label();
            showpass = new System.Windows.Forms.CheckBox();
            btnCancel = new System.Windows.Forms.Button();
            loginTitle = new System.Windows.Forms.Label();
            frmpassword = new System.Windows.Forms.TextBox();
            pass = new System.Windows.Forms.Label();
            frmusername = new System.Windows.Forms.TextBox();
            username = new System.Windows.Forms.Label();
            btnlogin = new System.Windows.Forms.Button();
            grouplogin.SuspendLayout();
            SuspendLayout();
            // 
            // grouplogin
            // 
            grouplogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            grouplogin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            grouplogin.Controls.Add(forgotpass);
            grouplogin.Controls.Add(label1);
            grouplogin.Controls.Add(showpass);
            grouplogin.Controls.Add(btnCancel);
            grouplogin.Controls.Add(loginTitle);
            grouplogin.Controls.Add(frmpassword);
            grouplogin.Controls.Add(pass);
            grouplogin.Controls.Add(frmusername);
            grouplogin.Controls.Add(username);
            grouplogin.Controls.Add(btnlogin);
            grouplogin.Location = new System.Drawing.Point(149, 106);
            grouplogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grouplogin.Name = "grouplogin";
            grouplogin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grouplogin.Size = new System.Drawing.Size(579, 460);
            grouplogin.TabIndex = 0;
            grouplogin.TabStop = false;
            grouplogin.Enter += groupBox1_Enter;
            // 
            // forgotpass
            // 
            forgotpass.AutoSize = true;
            forgotpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            forgotpass.Location = new System.Drawing.Point(232, 406);
            forgotpass.Name = "forgotpass";
            forgotpass.Size = new System.Drawing.Size(145, 20);
            forgotpass.TabIndex = 9;
            forgotpass.TabStop = true;
            forgotpass.Text = "Forgot Password?";
            forgotpass.LinkClicked += forgotpass_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(143, 64);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(297, 28);
            label1.TabIndex = 8;
            label1.Text = "INFORMATION SYSTEM";
            // 
            // showpass
            // 
            showpass.AutoSize = true;
            showpass.Location = new System.Drawing.Point(159, 276);
            showpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            showpass.Name = "showpass";
            showpass.Size = new System.Drawing.Size(199, 24);
            showpass.TabIndex = 7;
            showpass.Text = "Show Password Character";
            showpass.UseVisualStyleBackColor = true;
            showpass.CheckedChanged += showpass_CheckedChanged;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancel.BackColor = System.Drawing.Color.LightCoral;
            btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCancel.Location = new System.Drawing.Point(45, 328);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(233, 64);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // loginTitle
            // 
            loginTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            loginTitle.AutoSize = true;
            loginTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold);
            loginTitle.Location = new System.Drawing.Point(113, 22);
            loginTitle.Name = "loginTitle";
            loginTitle.Size = new System.Drawing.Size(377, 33);
            loginTitle.TabIndex = 5;
            loginTitle.Text = "ELEMENTARY STUDENT ";
            loginTitle.Click += loginTitle_Click;
            // 
            // frmpassword
            // 
            frmpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            frmpassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            frmpassword.Location = new System.Drawing.Point(159, 226);
            frmpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            frmpassword.Name = "frmpassword";
            frmpassword.Size = new System.Drawing.Size(388, 30);
            frmpassword.TabIndex = 4;
            frmpassword.TextChanged += password_TextChanged;
            // 
            // pass
            // 
            pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            pass.AutoSize = true;
            pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            pass.Location = new System.Drawing.Point(41, 235);
            pass.Name = "pass";
            pass.Size = new System.Drawing.Size(97, 23);
            pass.TabIndex = 3;
            pass.Text = "Password:";
            // 
            // frmusername
            // 
            frmusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            frmusername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            frmusername.Location = new System.Drawing.Point(159, 156);
            frmusername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            frmusername.Name = "frmusername";
            frmusername.Size = new System.Drawing.Size(388, 30);
            frmusername.TabIndex = 2;
            frmusername.TextChanged += textBox1_TextChanged_1;
            // 
            // username
            // 
            username.Anchor = System.Windows.Forms.AnchorStyles.None;
            username.AutoSize = true;
            username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            username.Location = new System.Drawing.Point(41, 165);
            username.Name = "username";
            username.Size = new System.Drawing.Size(102, 23);
            username.TabIndex = 1;
            username.Text = "Username:";
            username.Click += label1_Click;
            // 
            // btnlogin
            // 
            btnlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnlogin.BackColor = System.Drawing.Color.YellowGreen;
            btnlogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnlogin.ForeColor = System.Drawing.SystemColors.ControlText;
            btnlogin.Location = new System.Drawing.Point(314, 328);
            btnlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new System.Drawing.Size(233, 64);
            btnlogin.TabIndex = 0;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__1_;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(869, 644);
            Controls.Add(grouplogin);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            grouplogin.ResumeLayout(false);
            grouplogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grouplogin;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox frmusername;
        private System.Windows.Forms.TextBox frmpassword;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel forgotpass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

