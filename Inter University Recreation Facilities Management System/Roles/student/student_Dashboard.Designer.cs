namespace Inter_University_Recreation_Facilities_Management_System
{
    partial class student_Dashboard
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
            this.btn_SearchFacility = new System.Windows.Forms.Button();
            this.btn_Payment = new System.Windows.Forms.Button();
            this.btn_SendReview = new System.Windows.Forms.Button();
            this.btn_ManageProfile = new System.Windows.Forms.Button();
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
            // btn_SearchFacility
            // 
            this.btn_SearchFacility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SearchFacility.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_SearchFacility.Location = new System.Drawing.Point(255, 250);
            this.btn_SearchFacility.Name = "btn_SearchFacility";
            this.btn_SearchFacility.Size = new System.Drawing.Size(490, 110);
            this.btn_SearchFacility.TabIndex = 4;
            this.btn_SearchFacility.Text = "Search Facility";
            this.btn_SearchFacility.UseVisualStyleBackColor = true;
            this.btn_SearchFacility.Click += new System.EventHandler(this.btn_SearchFacility_Click);
            // 
            // btn_Payment
            // 
            this.btn_Payment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Payment.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Payment.Location = new System.Drawing.Point(255, 400);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.Size = new System.Drawing.Size(490, 110);
            this.btn_Payment.TabIndex = 5;
            this.btn_Payment.Text = "Payment";
            this.btn_Payment.UseVisualStyleBackColor = true;
            this.btn_Payment.Click += new System.EventHandler(this.btn_Payment_Click);
            // 
            // btn_SendReview
            // 
            this.btn_SendReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SendReview.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_SendReview.Location = new System.Drawing.Point(255, 550);
            this.btn_SendReview.Name = "btn_SendReview";
            this.btn_SendReview.Size = new System.Drawing.Size(490, 110);
            this.btn_SendReview.TabIndex = 6;
            this.btn_SendReview.Text = "Send Review";
            this.btn_SendReview.UseVisualStyleBackColor = true;
            this.btn_SendReview.Click += new System.EventHandler(this.btn_SendReview_Click);
            // 
            // btn_ManageProfile
            // 
            this.btn_ManageProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ManageProfile.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_ManageProfile.Location = new System.Drawing.Point(255, 700);
            this.btn_ManageProfile.Name = "btn_ManageProfile";
            this.btn_ManageProfile.Size = new System.Drawing.Size(490, 110);
            this.btn_ManageProfile.TabIndex = 7;
            this.btn_ManageProfile.Text = "Manage Profile";
            this.btn_ManageProfile.UseVisualStyleBackColor = true;
            this.btn_ManageProfile.Click += new System.EventHandler(this.btn_ManageProfile_Click);
            // 
            // student_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ManageProfile);
            this.Controls.Add(this.btn_SendReview);
            this.Controls.Add(this.btn_Payment);
            this.Controls.Add(this.btn_SearchFacility);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_WelcomeMessage);
            this.Name = "student_Dashboard";
            this.Size = new System.Drawing.Size(1000, 850);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_WelcomeMessage;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_SearchFacility;
        private System.Windows.Forms.Button btn_Payment;
        private System.Windows.Forms.Button btn_SendReview;
        private System.Windows.Forms.Button btn_ManageProfile;
    }
}
