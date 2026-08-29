using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inter_University_Recreation_Facilities_Management_System
{
    public partial class Login : UserControl
    {
        private void Aligned()
        {
            // Center the title
            lbl_Login.Left = (this.ClientSize.Width - lbl_Login.Width) / 2;

            // Center the textboxes, then align their labels to the same left edge
            int textBoxLeft = (this.ClientSize.Width - txtBox_Username.Width) / 2;

            txtBox_Username.Left = textBoxLeft;
            lbl_Username.Left = textBoxLeft;

            txtBox_Password.Left = textBoxLeft;
            lbl_Password.Left = textBoxLeft;

            chb_ShowPassword.Left = textBoxLeft;

            // Align the "Forgot Password" label to the right edge of the password textbox
            lbl_ForgotPassword.Left = txtBox_Password.Right - lbl_ForgotPassword.Width;

            // Center the button
            btn_Login.Left = (this.ClientSize.Width - btn_Login.Width) / 2;
            lbl_Register.Left = (this.ClientSize.Width - lbl_Register.Width) / 2;
        }


        public Login()
        {
            InitializeComponent();
            this.Resize += (s, e) => Aligned();
            
        }


        public event EventHandler<User> CredentialsValid;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username     = txtBox_Username.Text;
            string password     = txtBox_Password.Text;
            User   loggedInUser = Methods.CredentialValidation(username, password);

            if (loggedInUser != null ) CredentialsValid?.Invoke(this, loggedInUser);
        }


        public event EventHandler To_ResetPassword;
        private void lbl_ForgotPassword_MouseClick(object sender, MouseEventArgs e)
        { To_ResetPassword?.Invoke(this, EventArgs.Empty); }


        public event EventHandler To_RegisterAccount;
        private void lbl_Register_MouseClick(object sender, MouseEventArgs e)
        { To_RegisterAccount?.Invoke(this, EventArgs.Empty); }


        private void chb_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_ShowPassword.Checked) 
                 txtBox_Password.UseSystemPasswordChar = false;
            else txtBox_Password.UseSystemPasswordChar = true;
        }
    }
}
