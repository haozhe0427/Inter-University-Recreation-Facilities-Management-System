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
    public partial class forgotPassword : UserControl
    {
        public forgotPassword()
        {
            InitializeComponent();
            this.Resize += (s,e) => Aligned();
        }
        private void Aligned() 
        {
            lbl_ResetPassword.Left = (this.ClientSize.Width - lbl_ResetPassword.Width) / 2;
        }

        public event EventHandler To_Login;
        private void btn_Back_Click(object sender, EventArgs e)
        {
            To_Login?.Invoke(this, EventArgs.Empty);
        }
    }
}
