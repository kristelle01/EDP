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
            this.grouplogin = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.loginTitle = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.frmusername = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.grouplogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grouplogin
            // 
            this.grouplogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grouplogin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grouplogin.Controls.Add(this.showpass);
            this.grouplogin.Controls.Add(this.btnCancel);
            this.grouplogin.Controls.Add(this.loginTitle);
            this.grouplogin.Controls.Add(this.password);
            this.grouplogin.Controls.Add(this.pass);
            this.grouplogin.Controls.Add(this.frmusername);
            this.grouplogin.Controls.Add(this.username);
            this.grouplogin.Controls.Add(this.btnlogin);
            this.grouplogin.Location = new System.Drawing.Point(226, 85);
            this.grouplogin.Name = "grouplogin";
            this.grouplogin.Size = new System.Drawing.Size(743, 450);
            this.grouplogin.TabIndex = 0;
            this.grouplogin.TabStop = false;
            this.grouplogin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(101, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(249, 51);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // loginTitle
            // 
            this.loginTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginTitle.AutoSize = true;
            this.loginTitle.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.Location = new System.Drawing.Point(26, 40);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(662, 33);
            this.loginTitle.TabIndex = 5;
            this.loginTitle.Text = "ELEMENTARY STUDENT INFORMATION SYSTEM";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(242, 180);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(388, 34);
            this.password.TabIndex = 4;
            // 
            // pass
            // 
            this.pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(96, 183);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(117, 25);
            this.pass.TabIndex = 3;
            this.pass.Text = "Password:";
            // 
            // frmusername
            // 
            this.frmusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.frmusername.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmusername.Location = new System.Drawing.Point(242, 124);
            this.frmusername.Name = "frmusername";
            this.frmusername.Size = new System.Drawing.Size(388, 34);
            this.frmusername.TabIndex = 2;
            this.frmusername.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(96, 127);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(122, 25);
            this.username.TabIndex = 1;
            this.username.Text = "Username:";
            this.username.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlogin.BackColor = System.Drawing.Color.YellowGreen;
            this.btnlogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlogin.Location = new System.Drawing.Point(381, 277);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(249, 51);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.Location = new System.Drawing.Point(249, 219);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(186, 20);
            this.showpass.TabIndex = 7;
            this.showpass.Text = "Show Password Cahracter";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::elemStudentInfo.Properties.Resources.Untitled_design__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1181, 590);
            this.Controls.Add(this.grouplogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grouplogin.ResumeLayout(false);
            this.grouplogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grouplogin;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox frmusername;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox showpass;
    }
}

