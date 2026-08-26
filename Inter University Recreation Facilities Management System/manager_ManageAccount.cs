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
    public partial class manager_ManageAccount : UserControl
    {
        public manager_ManageAccount(User user)
        {
            InitializeComponent();
            this.Resize += (s,e) => Aligned();
        }

        private void Aligned() 
        {
            lbl_ManageAccount.Left = (this.ClientSize.Width - lbl_ManageAccount.Width) / 2;
        }

        public event EventHandler BackRequested;
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            BackRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
