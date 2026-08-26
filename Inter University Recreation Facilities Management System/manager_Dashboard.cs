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
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        public event EventHandler LogoutRequested;
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            LogoutRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
