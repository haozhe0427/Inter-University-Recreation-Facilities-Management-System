namespace Inter_University_Recreation_Facilities_Management_System
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chb_ShowPassword = new System.Windows.Forms.CheckBox();
            this.lbl_Register = new System.Windows.Forms.Label();
            this.lbl_ForgotPassword = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.txtBox_Username = new System.Windows.Forms.TextBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chb_ShowPassword
            // 
            this.chb_ShowPassword.AutoSize = true;
            this.chb_ShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chb_ShowPassword.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.chb_ShowPassword.Location = new System.Drawing.Point(163, 516);
            this.chb_ShowPassword.Name = "chb_ShowPassword";
            this.chb_ShowPassword.Size = new System.Drawing.Size(170, 27);
            this.chb_ShowPassword.TabIndex = 17;
            this.chb_ShowPassword.Text = "Show Password";
            this.chb_ShowPassword.UseVisualStyleBackColor = true;
            this.chb_ShowPassword.CheckedChanged += new System.EventHandler(this.chb_ShowPassword_CheckedChanged);
            // 
            // lbl_Register
            // 
            this.lbl_Register.AutoSize = true;
            this.lbl_Register.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_Register.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Register.Location = new System.Drawing.Point(380, 650);
            this.lbl_Register.Name = "lbl_Register";
            this.lbl_Register.Size = new System.Drawing.Size(241, 23);
            this.lbl_Register.TabIndex = 16;
            this.lbl_Register.Text = "No Account ? Register Here";
            this.lbl_Register.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_Register_MouseClick);
            // 
            // lbl_ForgotPassword
            // 
            this.lbl_ForgotPassword.AutoSize = true;
            this.lbl_ForgotPassword.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_ForgotPassword.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ForgotPassword.Location = new System.Drawing.Point(684, 517);
            this.lbl_ForgotPassword.Name = "lbl_ForgotPassword";
            this.lbl_ForgotPassword.Size = new System.Drawing.Size(163, 23);
            this.lbl_ForgotPassword.TabIndex = 15;
            this.lbl_ForgotPassword.Text = "Forgot Password?";
            this.lbl_ForgotPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_ForgotPassword_MouseClick);
            // 
            // btn_Login
            // 
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Login.Location = new System.Drawing.Point(333, 594);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(335, 53);
            this.btn_Login.TabIndex = 14;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Password.Location = new System.Drawing.Point(156, 420);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(165, 40);
            this.lbl_Password.TabIndex = 13;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Username.Location = new System.Drawing.Point(156, 248);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(170, 40);
            this.lbl_Username.TabIndex = 12;
            this.lbl_Username.Text = "Username";
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_Password.Font = new System.Drawing.Font("Leelawadee UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtBox_Password.Location = new System.Drawing.Point(154, 463);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(693, 51);
            this.txtBox_Password.TabIndex = 11;
            this.txtBox_Password.UseSystemPasswordChar = true;
            // 
            // txtBox_Username
            // 
            this.txtBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_Username.Font = new System.Drawing.Font("Leelawadee UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Username.Location = new System.Drawing.Point(154, 291);
            this.txtBox_Username.Margin = new System.Windows.Forms.Padding(0);
            this.txtBox_Username.MaxLength = 35;
            this.txtBox_Username.Name = "txtBox_Username";
            this.txtBox_Username.Size = new System.Drawing.Size(693, 51);
            this.txtBox_Username.TabIndex = 10;
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Leelawadee UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.Location = new System.Drawing.Point(380, 102);
            this.lbl_Login.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(241, 106);
            this.lbl_Login.TabIndex = 9;
            this.lbl_Login.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chb_ShowPassword);
            this.Controls.Add(this.lbl_Register);
            this.Controls.Add(this.lbl_ForgotPassword);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.txtBox_Password);
            this.Controls.Add(this.txtBox_Username);
            this.Controls.Add(this.lbl_Login);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1000, 774);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chb_ShowPassword;
        private System.Windows.Forms.Label lbl_Register;
        private System.Windows.Forms.Label lbl_ForgotPassword;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.TextBox txtBox_Username;
        private System.Windows.Forms.Label lbl_Login;
    }
}
