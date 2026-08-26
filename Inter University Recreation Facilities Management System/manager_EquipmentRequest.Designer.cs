namespace Inter_University_Recreation_Facilities_Management_System
{
    partial class manager_EquipmentRequest
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
            this.lbl_EquipmentRequest = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_EquipmentRequest
            // 
            this.lbl_EquipmentRequest.AutoSize = true;
            this.lbl_EquipmentRequest.Font = new System.Drawing.Font("Leelawadee UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EquipmentRequest.Location = new System.Drawing.Point(153, 75);
            this.lbl_EquipmentRequest.Name = "lbl_EquipmentRequest";
            this.lbl_EquipmentRequest.Size = new System.Drawing.Size(694, 81);
            this.lbl_EquipmentRequest.TabIndex = 2;
            this.lbl_EquipmentRequest.Text = "Repair / Replace Request";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Logout.Location = new System.Drawing.Point(15, 15);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(170, 55);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Back";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // manager_EquipmentRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_EquipmentRequest);
            this.Name = "manager_EquipmentRequest";
            this.Size = new System.Drawing.Size(1000, 850);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_EquipmentRequest;
        private System.Windows.Forms.Button btn_Logout;
    }
}
