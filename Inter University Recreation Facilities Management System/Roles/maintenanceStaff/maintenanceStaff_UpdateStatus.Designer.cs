namespace Inter_University_Recreation_Facilities_Management_System
{
    partial class maintenanceStaff_UpdateStatus
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
            this.lbl_UpdateStatus = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_UpdateStatus
            // 
            this.lbl_UpdateStatus.AutoSize = true;
            this.lbl_UpdateStatus.Font = new System.Drawing.Font("Leelawadee UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UpdateStatus.Location = new System.Drawing.Point(297, 75);
            this.lbl_UpdateStatus.Name = "lbl_UpdateStatus";
            this.lbl_UpdateStatus.Size = new System.Drawing.Size(406, 81);
            this.lbl_UpdateStatus.TabIndex = 4;
            this.lbl_UpdateStatus.Text = "Update Status";
            // 
            // btn_Back
            // 
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Back.Location = new System.Drawing.Point(15, 15);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(170, 55);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // maintainanceStaff_UpdateStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_UpdateStatus);
            this.Name = "maintainanceStaff_UpdateStatus";
            this.Size = new System.Drawing.Size(1000, 850);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UpdateStatus;
        private System.Windows.Forms.Button btn_Back;
    }
}
