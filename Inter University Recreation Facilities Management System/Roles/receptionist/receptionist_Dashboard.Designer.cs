namespace Inter_University_Recreation_Facilities_Management_System
{
    partial class receptionist_Dashboard
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
            this.lbl_WelcomeMessage = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_ManageAccount = new System.Windows.Forms.Button();
            this.btn_ManageBooking = new System.Windows.Forms.Button();
            this.btn_ManagePayment = new System.Windows.Forms.Button();
            this.btn_ViewRating = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_WelcomeMessage
            // 
            this.lbl_WelcomeMessage.AutoSize = true;
            this.lbl_WelcomeMessage.Font = new System.Drawing.Font("Leelawadee UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WelcomeMessage.Location = new System.Drawing.Point(344, 75);
            this.lbl_WelcomeMessage.Name = "lbl_WelcomeMessage";
            this.lbl_WelcomeMessage.Size = new System.Drawing.Size(312, 81);
            this.lbl_WelcomeMessage.TabIndex = 1;
            this.lbl_WelcomeMessage.Text = "Welcome, ";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Logout.Location = new System.Drawing.Point(15, 15);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(170, 55);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_ManageAccount
            // 
            this.btn_ManageAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ManageAccount.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_ManageAccount.Location = new System.Drawing.Point(255, 250);
            this.btn_ManageAccount.Name = "btn_ManageAccount";
            this.btn_ManageAccount.Size = new System.Drawing.Size(490, 110);
            this.btn_ManageAccount.TabIndex = 3;
            this.btn_ManageAccount.Text = "Manage Account";
            this.btn_ManageAccount.UseVisualStyleBackColor = true;
            this.btn_ManageAccount.Click += new System.EventHandler(this.btn_ManageAccount_Click);
            // 
            // btn_ManageBooking
            // 
            this.btn_ManageBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ManageBooking.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_ManageBooking.Location = new System.Drawing.Point(255, 400);
            this.btn_ManageBooking.Name = "btn_ManageBooking";
            this.btn_ManageBooking.Size = new System.Drawing.Size(490, 110);
            this.btn_ManageBooking.TabIndex = 4;
            this.btn_ManageBooking.Text = "Manage Booking";
            this.btn_ManageBooking.UseVisualStyleBackColor = true;
            this.btn_ManageBooking.Click += new System.EventHandler(this.btn_ManageBooking_Click);
            // 
            // btn_ManagePayment
            // 
            this.btn_ManagePayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ManagePayment.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_ManagePayment.Location = new System.Drawing.Point(255, 550);
            this.btn_ManagePayment.Name = "btn_ManagePayment";
            this.btn_ManagePayment.Size = new System.Drawing.Size(490, 110);
            this.btn_ManagePayment.TabIndex = 5;
            this.btn_ManagePayment.Text = "Manage Payment";
            this.btn_ManagePayment.UseVisualStyleBackColor = true;
            this.btn_ManagePayment.Click += new System.EventHandler(this.btn_ManagePayment_Click);
            // 
            // btn_ViewRating
            // 
            this.btn_ViewRating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ViewRating.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_ViewRating.Location = new System.Drawing.Point(255, 700);
            this.btn_ViewRating.Name = "btn_ViewRating";
            this.btn_ViewRating.Size = new System.Drawing.Size(490, 110);
            this.btn_ViewRating.TabIndex = 6;
            this.btn_ViewRating.Text = "View Rating";
            this.btn_ViewRating.UseVisualStyleBackColor = true;
            this.btn_ViewRating.Click += new System.EventHandler(this.btn_ViewRating_Click);
            // 
            // receptionist_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ViewRating);
            this.Controls.Add(this.btn_ManagePayment);
            this.Controls.Add(this.btn_ManageBooking);
            this.Controls.Add(this.btn_ManageAccount);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_WelcomeMessage);
            this.Name = "receptionist_Dashboard";
            this.Size = new System.Drawing.Size(1000, 850);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_WelcomeMessage;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_ManageAccount;
        private System.Windows.Forms.Button btn_ManageBooking;
        private System.Windows.Forms.Button btn_ManagePayment;
        private System.Windows.Forms.Button btn_ViewRating;
    }
}
