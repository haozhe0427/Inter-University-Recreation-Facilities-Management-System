using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
|====================================================================================================|
|                   Manage user accounts (add, delete Reception & Maintenance Staff).                |
|====================================================================================================|
*/


namespace Inter_University_Recreation_Facilities_Management_System
{
    
    public partial class manager_ManageAccount : UserControl
    {
        private void Aligned()
        {
            lbl_ManageAccount.Left = (this.ClientSize.Width - lbl_ManageAccount.Width) / 2;
            int dgv_ManageAccount  = (this.ClientSize.Width - dgv_Account      .Width) / 2;

            dgv_Account.    Left = dgv_ManageAccount;
            lbl_AccountID.  Left = dgv_ManageAccount;
            lbl_Email.      Left = dgv_ManageAccount;
            lbl_Role.       Left = dgv_ManageAccount;
            lbl_Username.   Left = dgv_ManageAccount;
            lbl_PhoneNumber.Left = dgv_ManageAccount;

            lbl_SelectedAccountID.Left = lbl_AccountID.Left + 110;
            lbl_SelectedAccountID.Top  = lbl_AccountID.Top - (lbl_SelectedAccountID.Height - lbl_AccountID.Height) / 2;

            txtBox_Email.Left = lbl_Email.Right + 10;
            txtBox_Email.Top  = lbl_Email.Top - (txtBox_Email.Height - lbl_Email.Height) / 2;

            rb_Receptionist.Left = lbl_Role.Left + 70;
            rb_Receptionist.Top  = lbl_Role.Top - (rb_Receptionist.Height - lbl_Role.Height) / 2;

            rb_MaintenanceStaff.Left = rb_Receptionist.Right + 10; // gap after "Receptionist" text, not a fixed offset
            rb_MaintenanceStaff.Top  = rb_Receptionist.Top - (rb_MaintenanceStaff.Height - rb_Receptionist.Height) / 2;

            txtBox_Username.Left = lbl_Username.Right + 10;
            txtBox_Username.Top  = lbl_Username.Top - (txtBox_Username.Height - lbl_Username.Height) / 2;

            txtBox_PhoneNumber.Left = lbl_PhoneNumber.Right + 10;
            txtBox_PhoneNumber.Top  = lbl_PhoneNumber.Top - (txtBox_PhoneNumber.Height - lbl_PhoneNumber.Height) / 2;

            btn_Delete.Left = dgv_Account.Right - btn_Delete.Width;
            btn_Add.   Left = btn_Delete. Left  - btn_Add.   Width - 10;
            btn_Clear. Left = btn_Add.    Left  - btn_Clear. Width - 10;
            btn_Search.Left = btn_Clear.  Left - btn_Search. Width - 10;
        }


        private void LoadAccounts() 
        {
            DataTable dataTable = Methods.LoadAccounts();

            dgv_Account.AutoGenerateColumns = false;
            dgv_Account.DataSource          = dataTable;
        }


        public manager_ManageAccount(User user)
        {
            InitializeComponent();
            this.Resize += (s,e) => Aligned();
            LoadAccounts();
        }


        public event EventHandler To_Dashboard;
        private void btn_Back_Click(object sender, EventArgs e)
        { To_Dashboard?.Invoke(this, EventArgs.Empty); }


        private void dgv_Account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow selectedRow = dgv_Account.Rows[e.RowIndex];

            lbl_SelectedAccountID.Text = selectedRow.Cells["AccountID"    ].Value.ToString();
            txtBox_Email.         Text = selectedRow.Cells["Email"        ].Value.ToString();
            txtBox_Username.      Text = selectedRow.Cells["UserName"     ].Value.ToString();
            txtBox_PhoneNumber.   Text = selectedRow.Cells["ContactNumber"].Value.ToString();

            string role = selectedRow.Cells["AccountRole"].Value.ToString();
            rb_Receptionist.    Checked = (role == "Receptionist"     );
            rb_MaintenanceStaff.Checked = (role == "Maintenance Staff");
        }


        private void btn_Search_Click(object sender, EventArgs e)
        {
            string accountID = lbl_SelectedAccountID.Text;
            string email = txtBox_Email.Text;
            
            string role = null;
            if      (rb_Receptionist.Checked    ) role = "Receptionist";
            else if (rb_MaintenanceStaff.Checked) role = "Maintenance Staff";

            string username    = txtBox_Username.Text;
            string phoneNumber = txtBox_PhoneNumber.Text;

            if (accountID == "" && email == "" && role == null && username == "" && phoneNumber == "")
            {
                MessageBox.Show("Please fill at least one search criteria."); return;
            }

            DataTable result = Methods.SearchAccount(accountID, email, role, username, phoneNumber);
            dgv_Account.DataSource = result;
        }


        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lbl_SelectedAccountID.Text = string.Empty;
            txtBox_Email.         Text = string.Empty;

            if (rb_Receptionist.Checked || rb_MaintenanceStaff.Checked) 
            {
                rb_Receptionist.    Checked = false;
                rb_MaintenanceStaff.Checked = false;
            }
           
            txtBox_Username.      Text = string.Empty;
            txtBox_PhoneNumber.   Text = string.Empty;

            LoadAccounts();
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            string email       = txtBox_Email.Text;
            string username    = txtBox_Username.Text;
            string phoneNumber = txtBox_PhoneNumber.Text;

            string role = null;
            if      (rb_Receptionist.    Checked) role = "Receptionist";
            else if (rb_MaintenanceStaff.Checked) role = "Maintenance Staff";

            if (email == "" || username == "" || phoneNumber == "" || role == null) 
            {
                MessageBox.Show("Please fill in all fields and select a role"); return;
            }

            DataTable updatedAccounts = Methods.AddAccount(email, username, role, phoneNumber);
            dgv_Account.DataSource = updatedAccounts;

            MessageBox.Show("Account added successfully.");
            btn_Clear_Click(sender, e);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string accountID = lbl_SelectedAccountID.Text;

            if (string.IsNullOrEmpty(accountID)) 
            {
                MessageBox.Show("Please select an account from the list first.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure want to delete account " + accountID,
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (confirm != DialogResult.Yes) return;

            try
            {
                DataTable updatedAccounts = Methods.DeleteAccount(accountID);
                dgv_Account.DataSource = updatedAccounts;

                MessageBox.Show("Account deleted successfully.");
                btn_Clear_Click(sender, e);
            }
            catch (SqlException ex) 
            { MessageBox.Show("Could not delete this account " + ex.Message); }
        }
    }
}