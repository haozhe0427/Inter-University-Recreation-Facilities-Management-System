namespace Inter_University_Recreation_Facilities_Management_System
{
    partial class form_Login
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
            this.lbl_Login = new System.Windows.Forms.Label();
            this.txtBox_Username = new System.Windows.Forms.TextBox();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Leelawadee UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.Location = new System.Drawing.Point(371, 56);
            this.lbl_Login.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(241, 106);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "Login";
            this.lbl_Login.Click += new System.EventHandler(this.lbl_Login_Click);
            // 
            // txtBox_Username
            // 
            this.txtBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_Username.Font = new System.Drawing.Font("Leelawadee UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Username.Location = new System.Drawing.Point(145, 245);
            this.txtBox_Username.Margin = new System.Windows.Forms.Padding(0);
            this.txtBox_Username.MaxLength = 35;
            this.txtBox_Username.Name = "txtBox_Username";
            this.txtBox_Username.Size = new System.Drawing.Size(693, 51);
            this.txtBox_Username.TabIndex = 1;
            this.txtBox_Username.TextChanged += new System.EventHandler(this.txtBox_Username_TextChanged);
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_Password.Font = new System.Drawing.Font("Leelawadee UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Password.Location = new System.Drawing.Point(145, 417);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(693, 51);
            this.txtBox_Password.TabIndex = 2;
            this.txtBox_Password.TextChanged += new System.EventHandler(this.txtBox_Password_TextChanged);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(147, 202);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(170, 40);
            this.lbl_Username.TabIndex = 3;
            this.lbl_Username.Text = "Username";
            this.lbl_Username.Click += new System.EventHandler(this.lbl_Username_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(147, 374);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(165, 40);
            this.lbl_Password.TabIndex = 4;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.Click += new System.EventHandler(this.lbl_Password_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(414, 527);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(154, 53);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.txtBox_Password);
            this.Controls.Add(this.txtBox_Username);
            this.Controls.Add(this.lbl_Login);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "form_Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox txtBox_Username;
        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_Login;
    }
}

