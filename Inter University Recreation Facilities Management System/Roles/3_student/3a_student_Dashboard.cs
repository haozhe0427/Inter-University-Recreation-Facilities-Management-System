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
|                                             STUDENT                                                |
|====================================================================================================|

1. Search for available facility
2. View facility details (type, location, rate).
3. Perform booking of facility (add, edit, delete). 
   Bill, payment and receipt will be handled by reception.
4. Send review /rating for the facility.
5. Update own profile.

*/

namespace Inter_University_Recreation_Facilities_Management_System
{
    public partial class student_Dashboard : UserControl
    {
        public student_Dashboard(User user)
        {
            InitializeComponent();
            this.Resize += (s, e) => Aligned();
            lbl_WelcomeMessage.Text = "Welcome, " + user.UserName + "!";
        }

        private void Aligned()
        {
            lbl_WelcomeMessage.Left = (this.ClientSize.Width - lbl_WelcomeMessage.Width) / 2;

            btn_SearchFacility.Left = (this.ClientSize.Width - btn_SearchFacility.Width) / 2;
            btn_Payment.Left        = (this.ClientSize.Width - btn_Payment.Width) / 2;
            btn_SendReview.Left     = (this.ClientSize.Width - btn_SendReview.Width) / 2;
            btn_ManageProfile.Left  = (this.ClientSize.Width - btn_ManageProfile.Width) / 2;
        }

        public event EventHandler To_Login;
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            To_Login?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler To_SearchFacility;
        private void btn_SearchFacility_Click(object sender, EventArgs e)
        {
            Aligned();

            To_SearchFacility?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler To_Payment;
        private void btn_Payment_Click(object sender, EventArgs e)
        {
            Aligned();

            To_Payment?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler To_SendReview;
        private void btn_SendReview_Click(object sender, EventArgs e)
        {
            Aligned();

            To_SendReview?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler To_ManageProfile;
        private void btn_ManageProfile_Click(object sender, EventArgs e)
        {
            Aligned();

            To_ManageProfile?.Invoke(this, EventArgs.Empty);
        }
    }
}
