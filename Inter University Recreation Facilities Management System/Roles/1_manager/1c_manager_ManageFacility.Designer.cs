namespace Inter_University_Recreation_Facilities_Management_System
{
    partial class manager_ManageFacility
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
            this.lbl_ManageFacility = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.dgv_Facility = new System.Windows.Forms.DataGridView();
            this.FacilityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacilityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacilityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacilityStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_FacilityID = new System.Windows.Forms.Label();
            this.lbl_FacilityName = new System.Windows.Forms.Label();
            this.lbl_FacilityType = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_Rate = new System.Windows.Forms.Label();
            this.lbl_SelectedFacilityID = new System.Windows.Forms.Label();
            this.txtBox_FacilityName = new System.Windows.Forms.TextBox();
            this.txtBox_Rate = new System.Windows.Forms.TextBox();
            this.rb_Indoor = new System.Windows.Forms.RadioButton();
            this.rb_Outdoor = new System.Windows.Forms.RadioButton();
            this.cBox_Status = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Facility)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ManageFacility
            // 
            this.lbl_ManageFacility.AutoSize = true;
            this.lbl_ManageFacility.Font = new System.Drawing.Font("Leelawadee UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageFacility.Location = new System.Drawing.Point(668, 75);
            this.lbl_ManageFacility.Name = "lbl_ManageFacility";
            this.lbl_ManageFacility.Size = new System.Drawing.Size(449, 81);
            this.lbl_ManageFacility.TabIndex = 2;
            this.lbl_ManageFacility.Text = "Manage Facility";
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
            // dgv_Facility
            // 
            this.dgv_Facility.AllowUserToDeleteRows = false;
            this.dgv_Facility.AllowUserToResizeColumns = false;
            this.dgv_Facility.AllowUserToResizeRows = false;
            this.dgv_Facility.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Facility.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Facility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Facility.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FacilityID,
            this.FacilityName,
            this.FacilityType,
            this.FacilityStatus,
            this.Rate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Facility.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Facility.Location = new System.Drawing.Point(52, 492);
            this.dgv_Facility.Name = "dgv_Facility";
            this.dgv_Facility.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Facility.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Facility.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Facility.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Facility.RowTemplate.Height = 24;
            this.dgv_Facility.Size = new System.Drawing.Size(1680, 478);
            this.dgv_Facility.TabIndex = 4;
            this.dgv_Facility.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Facility_CellClick);
            // 
            // FacilityID
            // 
            this.FacilityID.DataPropertyName = "FacilityID";
            this.FacilityID.HeaderText = "    FacilityID";
            this.FacilityID.MinimumWidth = 6;
            this.FacilityID.Name = "FacilityID";
            this.FacilityID.ReadOnly = true;
            // 
            // FacilityName
            // 
            this.FacilityName.DataPropertyName = "FacilityName";
            this.FacilityName.HeaderText = "    FacilityName";
            this.FacilityName.MinimumWidth = 6;
            this.FacilityName.Name = "FacilityName";
            this.FacilityName.ReadOnly = true;
            // 
            // FacilityType
            // 
            this.FacilityType.DataPropertyName = "FacilityType";
            this.FacilityType.HeaderText = "     FacilityType";
            this.FacilityType.MinimumWidth = 6;
            this.FacilityType.Name = "FacilityType";
            this.FacilityType.ReadOnly = true;
            // 
            // FacilityStatus
            // 
            this.FacilityStatus.DataPropertyName = "FacilityStatus";
            this.FacilityStatus.HeaderText = "    FacilityStatus";
            this.FacilityStatus.MinimumWidth = 6;
            this.FacilityStatus.Name = "FacilityStatus";
            this.FacilityStatus.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "     Rate";
            this.Rate.MinimumWidth = 6;
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // lbl_FacilityID
            // 
            this.lbl_FacilityID.AutoSize = true;
            this.lbl_FacilityID.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FacilityID.Location = new System.Drawing.Point(45, 218);
            this.lbl_FacilityID.Name = "lbl_FacilityID";
            this.lbl_FacilityID.Size = new System.Drawing.Size(127, 28);
            this.lbl_FacilityID.TabIndex = 18;
            this.lbl_FacilityID.Text = "Account ID:";
            // 
            // lbl_FacilityName
            // 
            this.lbl_FacilityName.AutoSize = true;
            this.lbl_FacilityName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FacilityName.Location = new System.Drawing.Point(45, 274);
            this.lbl_FacilityName.Name = "lbl_FacilityName";
            this.lbl_FacilityName.Size = new System.Drawing.Size(157, 28);
            this.lbl_FacilityName.TabIndex = 19;
            this.lbl_FacilityName.Text = "Facility Name:";
            // 
            // lbl_FacilityType
            // 
            this.lbl_FacilityType.AutoSize = true;
            this.lbl_FacilityType.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FacilityType.Location = new System.Drawing.Point(45, 330);
            this.lbl_FacilityType.Name = "lbl_FacilityType";
            this.lbl_FacilityType.Size = new System.Drawing.Size(143, 28);
            this.lbl_FacilityType.TabIndex = 20;
            this.lbl_FacilityType.Text = "Facility Type:";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(45, 386);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(164, 28);
            this.lbl_Status.TabIndex = 21;
            this.lbl_Status.Text = "Facility Status:";
            // 
            // lbl_Rate
            // 
            this.lbl_Rate.AutoSize = true;
            this.lbl_Rate.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rate.Location = new System.Drawing.Point(45, 442);
            this.lbl_Rate.Name = "lbl_Rate";
            this.lbl_Rate.Size = new System.Drawing.Size(103, 28);
            this.lbl_Rate.TabIndex = 22;
            this.lbl_Rate.Text = "Rate: RM";
            // 
            // lbl_SelectedFacilityID
            // 
            this.lbl_SelectedFacilityID.AutoSize = true;
            this.lbl_SelectedFacilityID.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectedFacilityID.Location = new System.Drawing.Point(178, 218);
            this.lbl_SelectedFacilityID.Name = "lbl_SelectedFacilityID";
            this.lbl_SelectedFacilityID.Size = new System.Drawing.Size(0, 28);
            this.lbl_SelectedFacilityID.TabIndex = 23;
            // 
            // txtBox_FacilityName
            // 
            this.txtBox_FacilityName.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_FacilityName.Location = new System.Drawing.Point(208, 271);
            this.txtBox_FacilityName.Name = "txtBox_FacilityName";
            this.txtBox_FacilityName.Size = new System.Drawing.Size(271, 35);
            this.txtBox_FacilityName.TabIndex = 18;
            // 
            // txtBox_Rate
            // 
            this.txtBox_Rate.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Rate.Location = new System.Drawing.Point(154, 439);
            this.txtBox_Rate.Name = "txtBox_Rate";
            this.txtBox_Rate.Size = new System.Drawing.Size(325, 35);
            this.txtBox_Rate.TabIndex = 24;
            // 
            // rb_Indoor
            // 
            this.rb_Indoor.AutoSize = true;
            this.rb_Indoor.Font = new System.Drawing.Font("Bahnschrift", 13.8F);
            this.rb_Indoor.Location = new System.Drawing.Point(208, 326);
            this.rb_Indoor.Name = "rb_Indoor";
            this.rb_Indoor.Size = new System.Drawing.Size(100, 32);
            this.rb_Indoor.TabIndex = 25;
            this.rb_Indoor.TabStop = true;
            this.rb_Indoor.Text = "Indoor";
            this.rb_Indoor.UseVisualStyleBackColor = true;
            // 
            // rb_Outdoor
            // 
            this.rb_Outdoor.AutoSize = true;
            this.rb_Outdoor.Font = new System.Drawing.Font("Bahnschrift", 13.8F);
            this.rb_Outdoor.Location = new System.Drawing.Point(314, 326);
            this.rb_Outdoor.Name = "rb_Outdoor";
            this.rb_Outdoor.Size = new System.Drawing.Size(117, 32);
            this.rb_Outdoor.TabIndex = 26;
            this.rb_Outdoor.TabStop = true;
            this.rb_Outdoor.Text = "Outdoor";
            this.rb_Outdoor.UseVisualStyleBackColor = true;
            // 
            // cBox_Status
            // 
            this.cBox_Status.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Status.FormattingEnabled = true;
            this.cBox_Status.Items.AddRange(new object[] {
            "",
            "Open",
            "Close"});
            this.cBox_Status.Location = new System.Drawing.Point(215, 383);
            this.cBox_Status.Name = "cBox_Status";
            this.cBox_Status.Size = new System.Drawing.Size(264, 36);
            this.cBox_Status.TabIndex = 27;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.Location = new System.Drawing.Point(1367, 415);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(170, 55);
            this.btn_Delete.TabIndex = 28;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Add.Location = new System.Drawing.Point(1172, 415);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(170, 55);
            this.btn_Add.TabIndex = 29;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.Location = new System.Drawing.Point(977, 415);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(170, 55);
            this.btn_Clear.TabIndex = 30;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Update.Location = new System.Drawing.Point(1562, 415);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(170, 55);
            this.btn_Update.TabIndex = 31;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // manager_ManageFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.cBox_Status);
            this.Controls.Add(this.rb_Outdoor);
            this.Controls.Add(this.rb_Indoor);
            this.Controls.Add(this.txtBox_Rate);
            this.Controls.Add(this.txtBox_FacilityName);
            this.Controls.Add(this.lbl_SelectedFacilityID);
            this.Controls.Add(this.lbl_Rate);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_FacilityType);
            this.Controls.Add(this.lbl_FacilityName);
            this.Controls.Add(this.lbl_FacilityID);
            this.Controls.Add(this.dgv_Facility);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_ManageFacility);
            this.Name = "manager_ManageFacility";
            this.Size = new System.Drawing.Size(1784, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Facility)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ManageFacility;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.DataGridView dgv_Facility;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacilityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacilityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacilityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacilityStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.Label lbl_FacilityID;
        private System.Windows.Forms.Label lbl_FacilityName;
        private System.Windows.Forms.Label lbl_FacilityType;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_Rate;
        private System.Windows.Forms.Label lbl_SelectedFacilityID;
        private System.Windows.Forms.TextBox txtBox_FacilityName;
        private System.Windows.Forms.TextBox txtBox_Rate;
        private System.Windows.Forms.RadioButton rb_Indoor;
        private System.Windows.Forms.RadioButton rb_Outdoor;
        private System.Windows.Forms.ComboBox cBox_Status;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Update;
    }
}
