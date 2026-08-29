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

namespace Inter_University_Recreation_Facilities_Management_System
{
    public partial class forgotPassword : UserControl
    {
        private void Aligned()
        {
            lbl_ResetPassword.Left = (this.ClientSize.Width - lbl_ResetPassword.Width) / 2;

            int textBoxLeft = (this.ClientSize.Width - txtBox_Email.Width) / 2;

            txtBox_Email.Left = textBoxLeft;
            lbl_Email.Left = textBoxLeft;

            txtBox_NewPassword.Left = textBoxLeft;
            lbl_NewPassword.Left = textBoxLeft;
            chb_ShowNewPassword.Left = textBoxLeft;

            txtBox_ConfirmPassword.Left = textBoxLeft;
            lbl_ConfirmPassword.Left = textBoxLeft;
            chb_ShowConfirmPassword.Left = textBoxLeft;

            btn_Reset.Left = (this.ClientSize.Width - btn_Reset.Width) / 2;
        }


        public forgotPassword()
        {
            InitializeComponent();
            this.Resize += (s,e) => Aligned();
        }

        
        public event EventHandler To_Login;
        private void btn_Back_Click(object sender, EventArgs e)
        { To_Login?.Invoke(this, EventArgs.Empty); }


        private void chb_ShowNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_ShowNewPassword.Checked) 
                 txtBox_NewPassword.UseSystemPasswordChar = false;
            else txtBox_NewPassword.UseSystemPasswordChar = true;
        }


        private void chb_ShowConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_ShowConfirmPassword.Checked) 
                 txtBox_ConfirmPassword.UseSystemPasswordChar = false;
            else txtBox_ConfirmPassword.UseSystemPasswordChar = true;
        }


        private void btn_Reset_Click(object sender, EventArgs e)
        {
            string email           = txtBox_Email.Text;
            string newPassword     = txtBox_NewPassword.Text;
            string confirmPassword = txtBox_ConfirmPassword.Text;
            bool   success         = Methods.ResetPassword(email, newPassword, confirmPassword);

            if (success) To_Login?.Invoke(this, EventArgs.Empty);
        }
    }
}
