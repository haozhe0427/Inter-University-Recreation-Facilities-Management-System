using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inter_University_Recreation_Facilities_Management_System
{
    public class Methods
    {
        static string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;


        public static User CredentialValidation(String username, String password)
        {
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.");
                return null;
            }

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string query = "SELECT Email, Password, AccountRole, UserName, ContactNumber " +
                               "FROM ACCOUNT " +
                               "WHERE UserName = @UserName AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User(
                                reader["Email"        ].ToString(),
                                reader["Password"     ].ToString(),
                                reader["AccountRole"  ].ToString(),
                                reader["UserName"     ].ToString(),
                                reader["ContactNumber"].ToString()
                                );
                        }

                        MessageBox.Show("Invalid username or password.");
                        return null;
                    }
                }
            }
        }


        public static bool ResetPassword(string email, string newPassword, string confirmPassword)
        {
            if (email == "" || newPassword == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            if (confirmPassword != newPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return false;
            }

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM ACCOUNT WHERE Email = @Email";
                int count;
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Email", email);
                    count = (int)checkCommand.ExecuteScalar();
                }
                if (count == 0)
                {
                    MessageBox.Show("Email not found.");
                    return false;
                }

                string updateQuery = "UPDATE ACCOUNT SET Password = @NewPassword WHERE Email = @Email";
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@NewPassword", newPassword);
                    updateCommand.Parameters.AddWithValue("@Email", email);

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password reset successful.");
                        return true;
                    }

                    MessageBox.Show("Password reset failed. Please try again.");
                    return false;
                }
            }
        }


        public static DataTable LoadAccounts()
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();

                string query = "SELECT AccountID, Email, AccountRole, UserName, ContactNumber " +
                               "FROM ACCOUNT " +
                               "WHERE AccountRole IN ('Receptionist', 'Maintenance Staff')";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }


        public static DataTable AddAccount(string email, string username, string role, string phoneNumber) 
        {
            using (SqlConnection connection = new SqlConnection(connStr)) 
            {
                connection.Open();

                string newAccountID  = "A00001";
                string getMaxIdQuery = "SELECT TOP 1 AccountID FROM ACCOUNT " +
                                       "ORDER BY AccountID DESC";

                using (SqlCommand getMaxIdCommand = new SqlCommand(getMaxIdQuery, connection)) 
                {
                    object result = getMaxIdCommand.ExecuteScalar();
                    if (result != null) 
                    {
                        string lastId = result.ToString();
                        int    number = int.Parse(lastId.Substring(1));
                        newAccountID  = "A" + (number + 1).ToString("D5");
                    }
                }
                string defaultPassword = newAccountID + "@password";

                string insertQuery = "INSERT INTO ACCOUNT (AccountID, Email, Password, AccountRole, UserName, ContactNumber)" +
                                     "VALUES (@AccountID, @Email, @Password, @AccountRole, @UserName, @ContactNumber)";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection)) 
                {
                    insertCommand.Parameters.AddWithValue("@AccountID",     newAccountID);
                    insertCommand.Parameters.AddWithValue("@Email",         email);
                    insertCommand.Parameters.AddWithValue("@Password",      defaultPassword);
                    insertCommand.Parameters.AddWithValue("@AccountRole",   role);
                    insertCommand.Parameters.AddWithValue("@UserName",      username);
                    insertCommand.Parameters.AddWithValue("@ContactNumber", phoneNumber);

                    insertCommand.ExecuteNonQuery();
                }

                string selectQuery = "SELECT AccountID, Email, AccountRole, UserName, ContactNumber " +
                                     "FROM ACCOUNT " +
                                     "WHERE AccountRole IN ('Receptionist', 'Maintenance Staff')";

                using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }
}
