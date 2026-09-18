namespace Inter_University_Recreation_Facilities_Management_System
{
    partial class manager_AssignSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_AssignSchedule = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.dgv_MaintenanceSchedule = new System.Windows.Forms.DataGridView();
            this.MaintenanceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacilityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaintenanceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_MaintenanceID = new System.Windows.Forms.Label();
            this.lbl_FacilityID = new System.Windows.Forms.Label();
            this.lbl_AccountID = new System.Windows.Forms.Label();
            this.lbl_MaintenanceType = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.cBox_Status = new System.Windows.Forms.ComboBox();
            this.lbl_SelectedMaintenanceID = new System.Windows.Forms.Label();
            this.rb_Installation = new System.Windows.Forms.RadioButton();
            this.rb_Fixing = new System.Windows.Forms.RadioButton();
            this.rb_Dismantlement = new System.Windows.Forms.RadioButton();
            this.txtBox_AccountID = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBox_FacilityID = new System.Windows.Forms.TextBox();
            this.btn_Seacrh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MaintenanceSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AssignSchedule
            // 
            this.lbl_AssignSchedule.AutoSize = true;
            this.lbl_AssignSchedule.Font = new System.Drawing.Font("Leelawadee UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AssignSchedule.Location = new System.Drawing.Point(660, 75);
            this.lbl_AssignSchedule.Name = "lbl_AssignSchedule";
            this.lbl_AssignSchedule.Size = new System.Drawing.Size(464, 81);
            this.lbl_AssignSchedule.TabIndex = 3;
            this.lbl_AssignSchedule.Text = "Assign Schedule";
            // 
            // btn_Back
            // 
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Back.Location = new System.Drawing.Point(15, 15);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(170, 55);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dgv_MaintenanceSchedule
            // 
            this.dgv_MaintenanceSchedule.AllowUserToDeleteRows = false;
            this.dgv_MaintenanceSchedule.AllowUserToResizeColumns = false;
            this.dgv_MaintenanceSchedule.AllowUserToResizeRows = false;
            this.dgv_MaintenanceSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_MaintenanceSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_MaintenanceSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MaintenanceSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaintenanceID,
            this.FacilityID,
            this.AccountID,
            this.MaintenanceType,
            this.Status,
            this.Date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_MaintenanceSchedule.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_MaintenanceSchedule.Location = new System.Drawing.Point(52, 492);
            this.dgv_MaintenanceSchedule.Name = "dgv_MaintenanceSchedule";
            this.dgv_MaintenanceSchedule.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_MaintenanceSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_MaintenanceSchedule.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_MaintenanceSchedule.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_MaintenanceSchedule.RowTemplate.Height = 24;
            this.dgv_MaintenanceSchedule.Size = new System.Drawing.Size(1680, 478);
            this.dgv_MaintenanceSchedule.TabIndex = 5;
            this.dgv_MaintenanceSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MaintenanceSchedule_CellClick);
            // 
            // MaintenanceID
            // 
            this.MaintenanceID.DataPropertyName = "MaintenanceID";
            this.MaintenanceID.HeaderText = "    MaintenanceID";
            this.MaintenanceID.MinimumWidth = 6;
            this.MaintenanceID.Name = "MaintenanceID";
            this.MaintenanceID.ReadOnly = true;
            // 
            // FacilityID
            // 
            this.FacilityID.DataPropertyName = "FacilityID";
            this.FacilityID.HeaderText = "    FacilityID";
            this.FacilityID.MinimumWidth = 6;
            this.FacilityID.Name = "FacilityID";
            this.FacilityID.ReadOnly = true;
            // 
            // AccountID
            // 
            this.AccountID.DataPropertyName = "AccountID";
            this.AccountID.HeaderText = "     AccountID";
            this.AccountID.MinimumWidth = 6;
            this.AccountID.Name = "AccountID";
            this.AccountID.ReadOnly = true;
            // 
            // MaintenanceType
            // 
            this.MaintenanceType.DataPropertyName = "MaintenanceType";
            this.MaintenanceType.HeaderText = "    MaintenanceType";
            this.MaintenanceType.MinimumWidth = 6;
            this.MaintenanceType.Name = "MaintenanceType";
            this.MaintenanceType.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "MaintenanceStatus";
            this.Status.HeaderText = "     Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "MaintenanceDate";
            this.Date.HeaderText = "   Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Update.Location = new System.Drawing.Point(1562, 415);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(170, 55);
            this.btn_Update.TabIndex = 32;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Add.Location = new System.Drawing.Point(1367, 415);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(170, 55);
            this.btn_Add.TabIndex = 33;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.Location = new System.Drawing.Point(1172, 415);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(170, 55);
            this.btn_Clear.TabIndex = 34;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_MaintenanceID
            // 
            this.lbl_MaintenanceID.AutoSize = true;
            this.lbl_MaintenanceID.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaintenanceID.Location = new System.Drawing.Point(45, 218);
            this.lbl_MaintenanceID.Name = "lbl_MaintenanceID";
            this.lbl_MaintenanceID.Size = new System.Drawing.Size(173, 28);
            this.lbl_MaintenanceID.TabIndex = 35;
            this.lbl_MaintenanceID.Text = "Maintenance ID:";
            // 
            // lbl_FacilityID
            // 
            this.lbl_FacilityID.AutoSize = true;
            this.lbl_FacilityID.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FacilityID.Location = new System.Drawing.Point(45, 274);
            this.lbl_FacilityID.Name = "lbl_FacilityID";
            this.lbl_FacilityID.Size = new System.Drawing.Size(111, 28);
            this.lbl_FacilityID.TabIndex = 36;
            this.lbl_FacilityID.Text = "Facilty ID:";
            // 
            // lbl_AccountID
            // 
            this.lbl_AccountID.AutoSize = true;
            this.lbl_AccountID.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AccountID.Location = new System.Drawing.Point(45, 330);
            this.lbl_AccountID.Name = "lbl_AccountID";
            this.lbl_AccountID.Size = new System.Drawing.Size(127, 28);
            this.lbl_AccountID.TabIndex = 37;
            this.lbl_AccountID.Text = "Account ID:";
            // 
            // lbl_MaintenanceType
            // 
            this.lbl_MaintenanceType.AutoSize = true;
            this.lbl_MaintenanceType.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaintenanceType.Location = new System.Drawing.Point(45, 386);
            this.lbl_MaintenanceType.Name = "lbl_MaintenanceType";
            this.lbl_MaintenanceType.Size = new System.Drawing.Size(199, 28);
            this.lbl_MaintenanceType.TabIndex = 38;
            this.lbl_MaintenanceType.Text = "Maintenance Type:";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(45, 442);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(84, 28);
            this.lbl_Status.TabIndex = 39;
            this.lbl_Status.Text = "Status:";
            // 
            // cBox_Status
            // 
            this.cBox_Status.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Status.FormattingEnabled = true;
            this.cBox_Status.Items.AddRange(new object[] {
            "",
            "Unfinished",
            "Finished"});
            this.cBox_Status.Location = new System.Drawing.Point(135, 439);
            this.cBox_Status.Name = "cBox_Status";
            this.cBox_Status.Size = new System.Drawing.Size(264, 36);
            this.cBox_Status.TabIndex = 40;
            // 
            // lbl_SelectedMaintenanceID
            // 
            this.lbl_SelectedMaintenanceID.AutoSize = true;
            this.lbl_SelectedMaintenanceID.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectedMaintenanceID.Location = new System.Drawing.Point(224, 218);
            this.lbl_SelectedMaintenanceID.Name = "lbl_SelectedMaintenanceID";
            this.lbl_SelectedMaintenanceID.Size = new System.Drawing.Size(0, 28);
            this.lbl_SelectedMaintenanceID.TabIndex = 41;
            // 
            // rb_Installation
            // 
            this.rb_Installation.AutoSize = true;
            this.rb_Installation.Font = new System.Drawing.Font("Bahnschrift", 13.8F);
            this.rb_Installation.Location = new System.Drawing.Point(249, 384);
            this.rb_Installation.Name = "rb_Installation";
            this.rb_Installation.Size = new System.Drawing.Size(150, 32);
            this.rb_Installation.TabIndex = 44;
            this.rb_Installation.TabStop = true;
            this.rb_Installation.Text = "Installation";
            this.rb_Installation.UseVisualStyleBackColor = true;
            // 
            // rb_Fixing
            // 
            this.rb_Fixing.AutoSize = true;
            this.rb_Fixing.Font = new System.Drawing.Font("Bahnschrift", 13.8F);
            this.rb_Fixing.Location = new System.Drawing.Point(405, 384);
            this.rb_Fixing.Name = "rb_Fixing";
            this.rb_Fixing.Size = new System.Drawing.Size(95, 32);
            this.rb_Fixing.TabIndex = 45;
            this.rb_Fixing.TabStop = true;
            this.rb_Fixing.Text = "Fixing";
            this.rb_Fixing.UseVisualStyleBackColor = true;
            // 
            // rb_Dismantlement
            // 
            this.rb_Dismantlement.AutoSize = true;
            this.rb_Dismantlement.Font = new System.Drawing.Font("Bahnschrift", 13.8F);
            this.rb_Dismantlement.Location = new System.Drawing.Point(506, 384);
            this.rb_Dismantlement.Name = "rb_Dismantlement";
            this.rb_Dismantlement.Size = new System.Drawing.Size(191, 32);
            this.rb_Dismantlement.TabIndex = 46;
            this.rb_Dismantlement.TabStop = true;
            this.rb_Dismantlement.Text = "Dismantlement";
            this.rb_Dismantlement.UseVisualStyleBackColor = true;
            // 
            // txtBox_AccountID
            // 
            this.txtBox_AccountID.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_AccountID.Location = new System.Drawing.Point(178, 327);
            this.txtBox_AccountID.Name = "txtBox_AccountID";
            this.txtBox_AccountID.Size = new System.Drawing.Size(271, 35);
            this.txtBox_AccountID.TabIndex = 47;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(727, 218);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(64, 28);
            this.lbl_Date.TabIndex = 48;
            this.lbl_Date.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(995, 247);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 35);
            this.dateTimePicker1.TabIndex = 49;
            this.dateTimePicker1.Value = new System.DateTime(2026, 9, 15, 0, 0, 0, 0);
            // 
            // txtBox_FacilityID
            // 
            this.txtBox_FacilityID.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_FacilityID.Location = new System.Drawing.Point(162, 271);
            this.txtBox_FacilityID.Name = "txtBox_FacilityID";
            this.txtBox_FacilityID.Size = new System.Drawing.Size(287, 35);
            this.txtBox_FacilityID.TabIndex = 50;
            // 
            // btn_Seacrh
            // 
            this.btn_Seacrh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Seacrh.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Seacrh.Location = new System.Drawing.Point(977, 415);
            this.btn_Seacrh.Name = "btn_Seacrh";
            this.btn_Seacrh.Size = new System.Drawing.Size(170, 55);
            this.btn_Seacrh.TabIndex = 51;
            this.btn_Seacrh.Text = "Search";
            this.btn_Seacrh.UseVisualStyleBackColor = true;
            this.btn_Seacrh.Click += new System.EventHandler(this.btn_Seacrh_Click);
            // 
            // manager_AssignSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Seacrh);
            this.Controls.Add(this.txtBox_FacilityID);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.txtBox_AccountID);
            this.Controls.Add(this.rb_Dismantlement);
            this.Controls.Add(this.rb_Fixing);
            this.Controls.Add(this.rb_Installation);
            this.Controls.Add(this.lbl_SelectedMaintenanceID);
            this.Controls.Add(this.cBox_Status);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_MaintenanceType);
            this.Controls.Add(this.lbl_AccountID);
            this.Controls.Add(this.lbl_FacilityID);
            this.Controls.Add(this.lbl_MaintenanceID);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.dgv_MaintenanceSchedule);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_AssignSchedule);
            this.Name = "manager_AssignSchedule";
            this.Size = new System.Drawing.Size(1784, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MaintenanceSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AssignSchedule;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DataGridView dgv_MaintenanceSchedule;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_MaintenanceID;
        private System.Windows.Forms.Label lbl_FacilityID;
        private System.Windows.Forms.Label lbl_AccountID;
        private System.Windows.Forms.Label lbl_MaintenanceType;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.ComboBox cBox_Status;
        private System.Windows.Forms.Label lbl_SelectedMaintenanceID;
        private System.Windows.Forms.RadioButton rb_Installation;
        private System.Windows.Forms.RadioButton rb_Fixing;
        private System.Windows.Forms.RadioButton rb_Dismantlement;
        private System.Windows.Forms.TextBox txtBox_AccountID;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaintenanceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacilityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaintenanceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.TextBox txtBox_FacilityID;
        private System.Windows.Forms.Button btn_Seacrh;
    }
}
