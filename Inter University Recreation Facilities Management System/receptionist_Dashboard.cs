using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        public event EventHandler LogoutRequested;
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            LogoutRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
