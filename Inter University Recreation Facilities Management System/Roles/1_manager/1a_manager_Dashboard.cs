using Inter_University_Recreation_Facilities_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 
|====================================================================================================|
|                                           MANAGER                                                  |
|====================================================================================================|

1. Manage user accounts(add, delete Reception & Maintenance Staff).
2. Manage Sports and Recreation facilities information for each of the participated University 
   (add, edit, delete – facility type, rate, etc).
3. Assign maintenance schedule and assign maintenance staff 
   to handle routine maintenance of the facilities.
4. View and approve equipment repair or replacement request from the Maintenance Staff.

*/

namespace Inter_University_Recreation_Facilities_Management_System
{
    public partial class manager_Dashboard : UserControl
    {
        public manager_Dashboard(User user)
        {
            InitializeComponent();
            this.Resize += (s, e) => Aligned();
            lbl_WelcomeMessage.Text = "Welcome, " + user.UserName + "!";
        }


        private void Aligned() 
        {
            lbl_WelcomeMessage.Left = (this.ClientSize.Width - lbl_WelcomeMessage.Width) / 2;

            btn_ManageAccount. Left = (this.ClientSize.Width - btn_ManageAccount. Width) / 2;
            btn_ManageFacility.Left = (this.ClientSize.Width - btn_ManageFacility.Width) / 2;
            btn_AssignSchedule.Left = (this.ClientSize.Width - btn_AssignSchedule.Width) / 2;
            btn_Request.       Left = (this.ClientSize.Width - btn_Request.       Width) / 2;
        }


        // Logout and return to the login page.
        public event EventHandler To_Login;
        private void btn_Logout_Click(object sender, EventArgs e)
        { To_Login?.Invoke(this, EventArgs.Empty); }


        // Manage user accounts
        // (add, delete Reception & Maintenance Staff).
        public event EventHandler To_ManageAccount;
        private void btn_ManageAccount_Click(object sender, EventArgs e)
        { To_ManageAccount?.Invoke(this, EventArgs.Empty); }


        // Manage Sports and Recreation facilities information for each of the participated University 
        // (add, edit, delete – facility type, rate, etc).
        public event EventHandler To_ManageFacility;
        private void btn_ManageFacility_Click(object sender, EventArgs e)
        { To_ManageFacility?.Invoke(this, EventArgs.Empty); }


        // Assign maintenance schedule and assign maintenance staff to handle routine maintenance of the facilities.
        public event EventHandler To_AssignSchedule;
        private void btn_AssignSchedule_Click(object sender, EventArgs e)
        { To_AssignSchedule?.Invoke(this, EventArgs.Empty); }


        // View and approve equipment repair or replacement request from the Maintenance Staff.
        public event EventHandler To_EquipmentRequest;
        private void btn_Request_Click(object sender, EventArgs e)
        { To_EquipmentRequest?.Invoke(this, EventArgs.Empty); }
    }
}