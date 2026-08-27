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
|                                           RECEPTIONIST                                             |
|====================================================================================================|

1. Manage Student account (add, delete student).
2. Search for existing bookings by student name or facility code.
3. Accept booking from the students (update facility availability, generate bill).
4. Accept payment from the students and generate receipt.
5. View review/rating from the students for each of the facilities.

*/

namespace Inter_University_Recreation_Facilities_Management_System
{
    public partial class receptionist_Dashboard : UserControl
    {
        public receptionist_Dashboard(User user)
        {
            InitializeComponent();
            this.Resize += (s, e) => Aligned();
            lbl_WelcomeMessage.Text = "Welcome, " + user.UserName + "!";
        }

        private void Aligned()
        {
            lbl_WelcomeMessage.Left = (this.ClientSize.Width - lbl_WelcomeMessage.Width) / 2;

            btn_ManageAccount.Left = (this.ClientSize.Width - btn_ManageAccount.Width) / 2;
            btn_ManageBooking.Left = (this.ClientSize.Width - btn_ManageBooking.Width) / 2;
            btn_ManagePayment.Left = (this.ClientSize.Width - btn_ManagePayment.Width) / 2;
            btn_ViewRating.Left    = (this.ClientSize.Width - btn_ViewRating.Width) / 2;
        }

        public event EventHandler To_Login;
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            To_Login?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler To_ManageAccount;
        private void btn_ManageAccount_Click(object sender, EventArgs e)
        {
            Aligned();

            To_ManageAccount?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler To_ManageBooking;
        private void btn_ManageBooking_Click(object sender, EventArgs e)
        {
            Aligned();

            To_ManageBooking?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler To_ManagePayment;
        private void btn_ManagePayment_Click(object sender, EventArgs e)
        {
            Aligned();

            To_ManagePayment?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler To_ViewRating;
        private void btn_ViewRating_Click(object sender, EventArgs e)
        {
            Aligned();

            To_ViewRating?.Invoke(this, EventArgs.Empty);
        }
    }
}
