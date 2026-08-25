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
    public partial class form_Login : Form
    {
        //--------------------------------------------------------------------------------//
        //                                   METHODS                                      //      
        //--------------------------------------------------------------------------------//
        private void Aligned()
        {
            // Center the title
            lbl_Login.Left           = (this.ClientSize.Width - lbl_Login.Width) / 2;

            // Center the textboxes, then align their labels to the same left edge
            int textBoxLeft          = (this.ClientSize.Width - txtBox_Username.Width) / 2;

            txtBox_Username.Left     = textBoxLeft;
            lbl_Username.Left        = textBoxLeft;

            txtBox_Password.Left     = textBoxLeft;
            lbl_Password.Left        = textBoxLeft;

            chb_ShowPassword.Left    = textBoxLeft;

            // Align the "Forgot Password" label to the right edge of the password textbox
            lbl_ForgotPassword.Left  = txtBox_Password.Right - lbl_ForgotPassword.Width;

            // Center the button
            btn_Login.Left           = (this.ClientSize.Width - btn_Login.Width) / 2;
            lbl_Register.Left        = (this.ClientSize.Width - lbl_Register.Width) / 2;
        }



        //--------------------------------------------------------------------------------//
        //                                   FORM                                         //
        //--------------------------------------------------------------------------------//
        public form_Login()
        {
            InitializeComponent();
            // Set the minimum size of the form to its initial size
            this.MinimumSize = this.Size; 
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Aligned();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Aligned();
        }



        //--------------------------------------------------------------------------------//
        //                                  ELEMENT                                       //
        //--------------------------------------------------------------------------------//

        // 1. Login label
        private void lbl_Login_Click(object sender, EventArgs e)
        {
            Aligned();
        }

        // 2. Username label
        private void lbl_Username_Click(object sender, EventArgs e)
        {
            Aligned();
        }

        // 3. Username textbox
        private void txtBox_Username_TextChanged(object sender, EventArgs e)
        {
            Aligned();
        }

        // 4. Password label
        private void lbl_Password_Click(object sender, EventArgs e)
        {
            Aligned();
        }

        // 5. Password textbox
        private void txtBox_Password_TextChanged(object sender, EventArgs e)
        {
            Aligned();
        }

        // 6. Show password checkbox
        private void chb_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            Aligned();
                                            
            if (chb_ShowPassword.Checked) { txtBox_Password.UseSystemPasswordChar = false; }
            else { txtBox_Password.UseSystemPasswordChar = true; }
        }

        // 7. Forgot password label
        private void lbl_ForgotPassword_Click(object sender, EventArgs e)
        {
            Aligned();
        }

        // 8. Login button
        private void btn_Login_Click(object sender, EventArgs e)
        {
            Aligned();

            string connStr = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connStr)) 
            {
                string query = "SELECT COUNT(*) FROM ACCOUNT " +
                               "WHERE UserName = @UserName AND " +
                               "Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection)) 
                { 
                    command.Parameters.AddWithValue("@UserName", txtBox_Username.Text);
                    command.Parameters.AddWithValue("@Password", txtBox_Password.Text);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0) { MessageBox.Show("Login successful!"); }
                    else { MessageBox.Show("Invalid username or password."); }
                }
            }

        }

        // 9. Register label
        private void lbl_Register_Click(object sender, EventArgs e)
        {

        }
    }
}
