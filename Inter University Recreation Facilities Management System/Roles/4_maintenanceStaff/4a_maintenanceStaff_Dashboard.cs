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
|                                        MAINTAINANCE STAFF                                          |  
|====================================================================================================|

1. View facility maintenance schedule (own schedule).
2. Update facility maintenance status.
3. Manage cleaning supplies/equipment request (add, edit, delete).
4. Raise equipment repair or replacement request.
5. Update own profile.

*/

namespace Inter_University_Recreation_Facilities_Management_System
{
    public partial class maintenanceStaff_Dashboard : UserControl
    {
        public maintenanceStaff_Dashboard(User user)
        {
            InitializeComponent();
            this.Resize += (s, e) => Aligned();
            lbl_WelcomeMessage.Text = "Welcome, " + user.UserName + "!";
        }

        private void Aligned()
        {
            lbl_WelcomeMessage.Left = (this.ClientSize.Width - lbl_WelcomeMessage.Width) / 2;

            btn_ViewSchedule.Left   = (this.ClientSize.Width - btn_ViewSchedule.Width) / 2;
            btn_ManageRequest.Left  = (this.ClientSize.Width - btn_ManageRequest.Width) / 2;
            btn_UpdateStatus.Left   = (this.ClientSize.Width - btn_UpdateStatus.Width) / 2;
            btn_ManageProfile.Left  = (this.ClientSize.Width - btn_ManageProfile.Width) / 2;
        }

        public event EventHandler To_Login;
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            To_Login?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler To_ViewSchedule;
        private void btn_ViewSchedule_Click(object sender, EventArgs e)
        {
            Aligned();

            To_ViewSchedule?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler To_UpdateStatus;
        private void btn_UpdateStatus_Click(object sender, EventArgs e)
        {
            Aligned();

            To_UpdateStatus?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler To_ManageRequest;
        private void btn_ManageRequest_Click(object sender, EventArgs e)
        {
            Aligned();

            To_ManageRequest?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler To_ManageProfile;
        private void btn_ManageProfile_Click(object sender, EventArgs e)
        {
            Aligned();

            To_ManageProfile?.Invoke(this, EventArgs.Empty);
        }
    }
}
