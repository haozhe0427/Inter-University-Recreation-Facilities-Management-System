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
        public forgotPassword()
        {
            InitializeComponent();
            this.Resize += (s,e) => Aligned();
        }

        private void Aligned() 
        {
            lbl_ResetPassword.Left = (this.ClientSize.Width - lbl_ResetPassword.Width) / 2;

            int textBoxLeft = (this.ClientSize.Width - txtBox_Email.Width) / 2;

            txtBox_Email.            Left = textBoxLeft;
            lbl_Email.               Left = textBoxLeft;

            txtBox_NewPassword.      Left = textBoxLeft;
            lbl_NewPassword.         Left = textBoxLeft;
            chb_ShowNewPassword.     Left = textBoxLeft;

            txtBox_ConfirmPassword.  Left = textBoxLeft;
            lbl_ConfirmPassword.     Left = textBoxLeft;
            chb_ShowConfirmPassword .Left = textBoxLeft;

            btn_Reset.Left = (this.ClientSize.Width - btn_Reset.Width) / 2;
        }


        public event EventHandler To_Login;
        private void btn_Back_Click(object sender, EventArgs e)
        {
            To_Login?.Invoke(this, EventArgs.Empty);
        }


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

            if (email == "" || newPassword == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (confirmPassword != newPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connStr)) 
            {
                connection.Open();

                // Step 1. Check if the email exists in the database
                string checkQuery = "SELECT COUNT(*) FROM ACCOUNT WHERE Email = @Email";
                int    count      = 0;
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Email", email);
                    count = (int)checkCommand.ExecuteScalar();
                }
                if (count == 0)
                {
                    MessageBox.Show("Email not found.");
                    return;
                }

                // Step 2. Update the password for the given email
                string updateQuery = "UPDATE ACCOUNT SET Password = @NewPassword WHERE Email = @Email";
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection)) 
                {
                    updateCommand.Parameters.AddWithValue("@NewPassword", newPassword);
                    updateCommand.Parameters.AddWithValue("@Email"      , email);
                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password reset successful.");
                        To_Login?.Invoke(this, EventArgs.Empty);
                    }
                    else MessageBox.Show("Password reset failed. Please try again.");
                }
            }
        }
    }
}
