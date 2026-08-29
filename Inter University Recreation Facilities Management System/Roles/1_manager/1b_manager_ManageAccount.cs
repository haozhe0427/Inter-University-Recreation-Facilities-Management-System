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

            lbl_SelectedAccountID.Left = lbl_AccountID.Left + 10;
            lbl_SelectedAccountID.Top  = lbl_AccountID.Top -
                                         (lbl_SelectedAccountID.Height - lbl_AccountID.Height) / 2;

            txtBox_Email.Left = lbl_Email.Right + 10;
            txtBox_Email.Top  = lbl_Email.Top - 
                                (txtBox_Email.Height - lbl_Email.Height) / 2;

            rb_Receptionist.Left = lbl_Role.Left + 70;
            rb_Receptionist.Top  = lbl_Role.Top - 
                                   (rb_Receptionist.Height - lbl_Role.Height) / 2;

            rb_MaintenanceStaff.Left = rb_Receptionist.Right + 10; // gap after "Receptionist" text, not a fixed offset
            rb_MaintenanceStaff.Top  = rb_Receptionist.Top - 
                                       (rb_MaintenanceStaff.Height - rb_Receptionist.Height) / 2;

            txtBox_Username.Left = lbl_Username.Right + 10;
            txtBox_Username.Top  = lbl_Username.Top - 
                                   (txtBox_Username.Height - lbl_Username.Height) / 2;

            txtBox_PhoneNumber.Left = lbl_PhoneNumber.Right + 10;
            txtBox_PhoneNumber.Top  = lbl_PhoneNumber.Top - 
                                      (txtBox_PhoneNumber.Height - lbl_PhoneNumber.Height) / 2;
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
    }
}
