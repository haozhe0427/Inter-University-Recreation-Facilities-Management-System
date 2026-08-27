namespace Inter_University_Recreation_Facilities_Management_System
{
    partial class maintenanceStaff_Dashboard
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
            this.btn_ViewSchedule = new System.Windows.Forms.Button();
            this.btn_UpdateStatus = new System.Windows.Forms.Button();
            this.btn_ManageRequest = new System.Windows.Forms.Button();
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
            // btn_ViewSchedule
            // 
            this.btn_ViewSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ViewSchedule.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_ViewSchedule.Location = new System.Drawing.Point(255, 250);
            this.btn_ViewSchedule.Name = "btn_ViewSchedule";
            this.btn_ViewSchedule.Size = new System.Drawing.Size(490, 110);
            this.btn_ViewSchedule.TabIndex = 5;
            this.btn_ViewSchedule.Text = "View Schedule";
            this.btn_ViewSchedule.UseVisualStyleBackColor = true;
            this.btn_ViewSchedule.Click += new System.EventHandler(this.btn_ViewSchedule_Click);
            // 
            // btn_UpdateStatus
            // 
            this.btn_UpdateStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpdateStatus.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_UpdateStatus.Location = new System.Drawing.Point(255, 400);
            this.btn_UpdateStatus.Name = "btn_UpdateStatus";
            this.btn_UpdateStatus.Size = new System.Drawing.Size(490, 110);
            this.btn_UpdateStatus.TabIndex = 6;
            this.btn_UpdateStatus.Text = "Update Maintainance Status";
            this.btn_UpdateStatus.UseVisualStyleBackColor = true;
            this.btn_UpdateStatus.Click += new System.EventHandler(this.btn_UpdateStatus_Click);
            // 
            // btn_ManageRequest
            // 
            this.btn_ManageRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ManageRequest.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_ManageRequest.Location = new System.Drawing.Point(255, 550);
            this.btn_ManageRequest.Name = "btn_ManageRequest";
            this.btn_ManageRequest.Size = new System.Drawing.Size(490, 110);
            this.btn_ManageRequest.TabIndex = 7;
            this.btn_ManageRequest.Text = "Manage Supply / Equipment Request ";
            this.btn_ManageRequest.UseVisualStyleBackColor = true;
            this.btn_ManageRequest.Click += new System.EventHandler(this.btn_ManageRequest_Click);
            // 
            // btn_ManageProfile
            // 
            this.btn_ManageProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ManageProfile.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_ManageProfile.Location = new System.Drawing.Point(255, 700);
            this.btn_ManageProfile.Name = "btn_ManageProfile";
            this.btn_ManageProfile.Size = new System.Drawing.Size(490, 110);
            this.btn_ManageProfile.TabIndex = 8;
            this.btn_ManageProfile.Text = "Manage Profile";
            this.btn_ManageProfile.UseVisualStyleBackColor = true;
            this.btn_ManageProfile.Click += new System.EventHandler(this.btn_ManageProfile_Click);
            // 
            // maintainanceStaff_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ManageProfile);
            this.Controls.Add(this.btn_ManageRequest);
            this.Controls.Add(this.btn_UpdateStatus);
            this.Controls.Add(this.btn_ViewSchedule);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_WelcomeMessage);
            this.Name = "maintainanceStaff_Dashboard";
            this.Size = new System.Drawing.Size(1000, 850);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_WelcomeMessage;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_ViewSchedule;
        private System.Windows.Forms.Button btn_UpdateStatus;
        private System.Windows.Forms.Button btn_ManageRequest;
        private System.Windows.Forms.Button btn_ManageProfile;
    }
}
