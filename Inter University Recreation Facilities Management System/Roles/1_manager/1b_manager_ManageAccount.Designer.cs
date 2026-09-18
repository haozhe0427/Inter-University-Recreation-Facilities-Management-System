namespace Inter_University_Recreation_Facilities_Management_System
{
    partial class manager_ManageAccount
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
            this.lbl_ManageAccount = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.dgv_Account = new System.Windows.Forms.DataGridView();
            this.AccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_AccountID = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txtBox_Email = new System.Windows.Forms.TextBox();
            this.lbl_SelectedAccountID = new System.Windows.Forms.Label();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txtBox_Username = new System.Windows.Forms.TextBox();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.txtBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.rb_Receptionist = new System.Windows.Forms.RadioButton();
            this.rb_MaintenanceStaff = new System.Windows.Forms.RadioButton();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ManageAccount
            // 
            this.lbl_ManageAccount.AutoSize = true;
            this.lbl_ManageAccount.Font = new System.Drawing.Font("Leelawadee UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageAccount.Location = new System.Drawing.Point(650, 75);
            this.lbl_ManageAccount.Name = "lbl_ManageAccount";
            this.lbl_ManageAccount.Size = new System.Drawing.Size(485, 81);
            this.lbl_ManageAccount.TabIndex = 1;
            this.lbl_ManageAccount.Text = "Manage Account";
            // 
            // btn_Back
            // 
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Back.Location = new System.Drawing.Point(15, 15);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(170, 55);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dgv_Account
            // 
            this.dgv_Account.AllowUserToDeleteRows = false;
            this.dgv_Account.AllowUserToResizeColumns = false;
            this.dgv_Account.AllowUserToResizeRows = false;
            this.dgv_Account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Account.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Account.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountID,
            this.Email,
            this.AccountRole,
            this.UserName,
            this.ContactNumber});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Account.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Account.Location = new System.Drawing.Point(52, 493);
            this.dgv_Account.Name = "dgv_Account";
            this.dgv_Account.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Account.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Account.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Account.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Account.RowTemplate.Height = 24;
            this.dgv_Account.Size = new System.Drawing.Size(1680, 478);
            this.dgv_Account.TabIndex = 3;
            this.dgv_Account.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Account_CellClick);
            // 
            // AccountID
            // 
            this.AccountID.DataPropertyName = "AccountID";
            this.AccountID.HeaderText = "    AccountID";
            this.AccountID.MinimumWidth = 6;
            this.AccountID.Name = "AccountID";
            this.AccountID.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "    Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // AccountRole
            // 
            this.AccountRole.DataPropertyName = "AccountRole";
            this.AccountRole.HeaderText = "     AccountRole";
            this.AccountRole.MinimumWidth = 6;
            this.AccountRole.Name = "AccountRole";
            this.AccountRole.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "    UserName";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // ContactNumber
            // 
            this.ContactNumber.DataPropertyName = "ContactNumber";
            this.ContactNumber.HeaderText = "     ContactNumber";
            this.ContactNumber.MinimumWidth = 6;
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            // 
            // lbl_AccountID
            // 
            this.lbl_AccountID.AutoSize = true;
            this.lbl_AccountID.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AccountID.Location = new System.Drawing.Point(45, 218);
            this.lbl_AccountID.Name = "lbl_AccountID";
            this.lbl_AccountID.Size = new System.Drawing.Size(127, 28);
            this.lbl_AccountID.TabIndex = 4;
            this.lbl_AccountID.Text = "Account ID:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(45, 274);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(76, 28);
            this.lbl_Email.TabIndex = 5;
            this.lbl_Email.Text = "Email:";
            // 
            // txtBox_Email
            // 
            this.txtBox_Email.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Email.Location = new System.Drawing.Point(127, 271);
            this.txtBox_Email.Name = "txtBox_Email";
            this.txtBox_Email.Size = new System.Drawing.Size(410, 35);
            this.txtBox_Email.TabIndex = 6;
            // 
            // lbl_SelectedAccountID
            // 
            this.lbl_SelectedAccountID.AutoSize = true;
            this.lbl_SelectedAccountID.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectedAccountID.Location = new System.Drawing.Point(178, 218);
            this.lbl_SelectedAccountID.Name = "lbl_SelectedAccountID";
            this.lbl_SelectedAccountID.Size = new System.Drawing.Size(0, 28);
            this.lbl_SelectedAccountID.TabIndex = 7;
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Role.Location = new System.Drawing.Point(45, 330);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(64, 28);
            this.lbl_Role.TabIndex = 8;
            this.lbl_Role.Text = "Role:";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(45, 386);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(123, 28);
            this.lbl_Username.TabIndex = 9;
            this.lbl_Username.Text = "Username:";
            // 
            // txtBox_Username
            // 
            this.txtBox_Username.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Username.Location = new System.Drawing.Point(174, 383);
            this.txtBox_Username.Name = "txtBox_Username";
            this.txtBox_Username.Size = new System.Drawing.Size(363, 35);
            this.txtBox_Username.TabIndex = 10;
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(45, 442);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(171, 28);
            this.lbl_PhoneNumber.TabIndex = 11;
            this.lbl_PhoneNumber.Text = "Phone Number:";
            // 
            // txtBox_PhoneNumber
            // 
            this.txtBox_PhoneNumber.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_PhoneNumber.Location = new System.Drawing.Point(222, 439);
            this.txtBox_PhoneNumber.Name = "txtBox_PhoneNumber";
            this.txtBox_PhoneNumber.Size = new System.Drawing.Size(315, 35);
            this.txtBox_PhoneNumber.TabIndex = 12;
            // 
            // rb_Receptionist
            // 
            this.rb_Receptionist.AutoSize = true;
            this.rb_Receptionist.Font = new System.Drawing.Font("Bahnschrift", 13.8F);
            this.rb_Receptionist.Location = new System.Drawing.Point(127, 328);
            this.rb_Receptionist.Name = "rb_Receptionist";
            this.rb_Receptionist.Size = new System.Drawing.Size(162, 32);
            this.rb_Receptionist.TabIndex = 13;
            this.rb_Receptionist.TabStop = true;
            this.rb_Receptionist.Text = "Receptionist";
            this.rb_Receptionist.UseVisualStyleBackColor = true;
            // 
            // rb_MaintenanceStaff
            // 
            this.rb_MaintenanceStaff.AutoSize = true;
            this.rb_MaintenanceStaff.Font = new System.Drawing.Font("Bahnschrift", 13.8F);
            this.rb_MaintenanceStaff.Location = new System.Drawing.Point(295, 328);
            this.rb_MaintenanceStaff.Name = "rb_MaintenanceStaff";
            this.rb_MaintenanceStaff.Size = new System.Drawing.Size(217, 32);
            this.rb_MaintenanceStaff.TabIndex = 14;
            this.rb_MaintenanceStaff.TabStop = true;
            this.rb_MaintenanceStaff.Text = "Maintenance Staff";
            this.rb_MaintenanceStaff.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Add.Location = new System.Drawing.Point(1367, 415);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(170, 55);
            this.btn_Add.TabIndex = 15;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.Location = new System.Drawing.Point(1562, 415);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(170, 55);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.Location = new System.Drawing.Point(1172, 415);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(170, 55);
            this.btn_Clear.TabIndex = 17;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Location = new System.Drawing.Point(977, 415);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(170, 55);
            this.btn_Search.TabIndex = 18;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // manager_ManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.rb_MaintenanceStaff);
            this.Controls.Add(this.rb_Receptionist);
            this.Controls.Add(this.txtBox_PhoneNumber);
            this.Controls.Add(this.lbl_PhoneNumber);
            this.Controls.Add(this.txtBox_Username);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Role);
            this.Controls.Add(this.lbl_SelectedAccountID);
            this.Controls.Add(this.txtBox_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_AccountID);
            this.Controls.Add(this.dgv_Account);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_ManageAccount);
            this.Name = "manager_ManageAccount";
            this.Size = new System.Drawing.Size(1784, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ManageAccount;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DataGridView dgv_Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.Label lbl_AccountID;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txtBox_Email;
        private System.Windows.Forms.Label lbl_SelectedAccountID;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txtBox_Username;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.TextBox txtBox_PhoneNumber;
        private System.Windows.Forms.RadioButton rb_Receptionist;
        private System.Windows.Forms.RadioButton rb_MaintenanceStaff;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Search;
    }
}
