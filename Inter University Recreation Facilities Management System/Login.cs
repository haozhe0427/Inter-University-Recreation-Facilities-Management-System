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
        public Login()
        {
            InitializeComponent();
            this.Resize += (s, e) => Aligned();
        }

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

        public event EventHandler<User> LoginSuccessful;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string query = "SELECT Email, Password, AccountRole, UserName, ContactNumber " +
                               "FROM ACCOUNT " +
                               "WHERE UserName = @UserName AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", txtBox_Username.Text);
                    command.Parameters.AddWithValue("@Password", txtBox_Password.Text);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader()) 
                    {
                        if (reader.Read())
                        {
                            User loggedInUser = new User(
                                reader["Email"].ToString(),
                                reader["Password"].ToString(),
                                reader["AccountRole"].ToString(),
                                reader["UserName"].ToString(),
                                reader["ContactNumber"].ToString()
                                );

                            LoginSuccessful?.Invoke(this, loggedInUser);
                        }
                        else { MessageBox.Show("Invalid username or password."); }
                    }
                }
            }
        }
    }
}
