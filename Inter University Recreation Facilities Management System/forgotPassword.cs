using System;
using System.Windows.Forms;

namespace Inter_University_Recreation_Facilities_Management_System
{
    public partial class forgotPassword : UserControl
    {
        public forgotPassword()
        {
            InitializeComponent();
            this.Resize += (s, e) => Aligned();
        }


        private void Aligned()
        {
            lbl_ResetPassword.Left = (this.ClientSize.Width - lbl_ResetPassword.Width) / 2;

            int textBoxLeft = (this.ClientSize.Width - txtBox_Email.Width) / 2;

            txtBox_Email.Left = textBoxLeft;
            lbl_Email.Left    = textBoxLeft;

            txtBox_NewPassword.Left  = textBoxLeft;
            lbl_NewPassword.Left     = textBoxLeft;
            chb_ShowNewPassword.Left = textBoxLeft;

            txtBox_ConfirmPassword.Left  = textBoxLeft;
            lbl_ConfirmPassword.Left     = textBoxLeft;
            chb_ShowConfirmPassword.Left = textBoxLeft;

            btn_Reset.Left = (this.ClientSize.Width - btn_Reset.Width) / 2;
        }


        public event EventHandler To_Login;
        private void btn_Back_Click(object sender, EventArgs e)
        {
            To_Login?.Invoke(this, EventArgs.Empty);
        }


        private void chb_ShowNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtBox_NewPassword.UseSystemPasswordChar = !chb_ShowNewPassword.Checked;
        }


        private void chb_ShowConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtBox_ConfirmPassword.UseSystemPasswordChar = !chb_ShowConfirmPassword.Checked;
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