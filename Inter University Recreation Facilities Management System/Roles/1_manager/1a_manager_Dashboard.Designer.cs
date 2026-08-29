namespace Inter_University_Recreation_Facilities_Management_System
{
    partial class manager_Dashboard
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
            this.btn_ManageFacility = new System.Windows.Forms.Button();
            this.btn_AssignSchedule = new System.Windows.Forms.Button();
            this.btn_Request = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_WelcomeMessage
            // 
            this.lbl_WelcomeMessage.AutoSize = true;
            this.lbl_WelcomeMessage.Font = new System.Drawing.Font("Leelawadee UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WelcomeMessage.Location = new System.Drawing.Point(344, 75);
            this.lbl_WelcomeMessage.Name = "lbl_WelcomeMessage";
            this.lbl_WelcomeMessage.Size = new System.Drawing.Size(312, 81);
            this.lbl_WelcomeMessage.TabIndex = 0;
            this.lbl_WelcomeMessage.Text = "Welcome, ";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Logout.Location = new System.Drawing.Point(15, 15);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(170, 55);
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_ManageAccount
            // 
            this.btn_ManageAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ManageAccount.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_ManageAccount.Location = new System.Drawing.Point(256, 250);
            this.btn_ManageAccount.Name = "btn_ManageAccount";
            this.btn_ManageAccount.Size = new System.Drawing.Size(490, 110);
            this.btn_ManageAccount.TabIndex = 2;
            this.btn_ManageAccount.Text = "Manage Account";
            this.btn_ManageAccount.UseVisualStyleBackColor = true;
            this.btn_ManageAccount.Click += new System.EventHandler(this.btn_ManageAccount_Click);
            // 
            // btn_ManageFacility
            // 
            this.btn_ManageFacility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ManageFacility.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_ManageFacility.Location = new System.Drawing.Point(256, 400);
            this.btn_ManageFacility.Name = "btn_ManageFacility";
            this.btn_ManageFacility.Size = new System.Drawing.Size(490, 110);
            this.btn_ManageFacility.TabIndex = 3;
            this.btn_ManageFacility.Text = "Manage Facility";
            this.btn_ManageFacility.UseVisualStyleBackColor = true;
            this.btn_ManageFacility.Click += new System.EventHandler(this.btn_ManageFacility_Click);
            // 
            // btn_AssignSchedule
            // 
            this.btn_AssignSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AssignSchedule.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_AssignSchedule.Location = new System.Drawing.Point(256, 550);
            this.btn_AssignSchedule.Name = "btn_AssignSchedule";
            this.btn_AssignSchedule.Size = new System.Drawing.Size(490, 110);
            this.btn_AssignSchedule.TabIndex = 4;
            this.btn_AssignSchedule.Text = "Assign Maintainance Schedule";
            this.btn_AssignSchedule.UseVisualStyleBackColor = true;
            this.btn_AssignSchedule.Click += new System.EventHandler(this.btn_AssignSchedule_Click);
            // 
            // btn_Request
            // 
            this.btn_Request.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Request.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Request.Location = new System.Drawing.Point(256, 700);
            this.btn_Request.Name = "btn_Request";
            this.btn_Request.Size = new System.Drawing.Size(490, 110);
            this.btn_Request.TabIndex = 5;
            this.btn_Request.Text = "Equipment Repair / Replace Request";
            this.btn_Request.UseVisualStyleBackColor = true;
            this.btn_Request.Click += new System.EventHandler(this.btn_Request_Click);
            // 
            // manager_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Request);
            this.Controls.Add(this.btn_AssignSchedule);
            this.Controls.Add(this.btn_ManageFacility);
            this.Controls.Add(this.btn_ManageAccount);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_WelcomeMessage);
            this.Name = "manager_Dashboard";
            this.Size = new System.Drawing.Size(1000, 850);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_WelcomeMessage;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_ManageAccount;
        private System.Windows.Forms.Button btn_ManageFacility;
        private System.Windows.Forms.Button btn_AssignSchedule;
        private System.Windows.Forms.Button btn_Request;
    }
}
