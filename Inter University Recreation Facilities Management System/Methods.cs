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
        //----------------------------------------------------------------------------------------------------------------------------------//
        //                                                     CONNECTION STRING                                                            //
        //----------------------------------------------------------------------------------------------------------------------------------//
        static string database = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        
        
        //----------------------------------------------------------------------------------------------------------------------------------//
        //                                          Login.cs : CredentialValidaton ; ln 55                                                  //                                                  
        //----------------------------------------------------------------------------------------------------------------------------------//
        public static User CredentialValidation(String username, String password)
        {
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.");
                return null;
            }

            using (SqlConnection connection = new SqlConnection(database))
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


        //----------------------------------------------------------------------------------------------------------------------------------//
        //                                          forgorPassword.cs : ResetPassword ; ln 70                                               //                                                  
        //----------------------------------------------------------------------------------------------------------------------------------//
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

            using (SqlConnection connection = new SqlConnection(database))
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


        //----------------------------------------------------------------------------------------------------------------------------------//
        //                                      1a_manager_ManageAccount.cs : LoadAccounts ; ln 68                                          //                                                  
        //----------------------------------------------------------------------------------------------------------------------------------//
        public static DataTable LoadAccounts()
        {
            using (SqlConnection connection = new SqlConnection(database))
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


        //----------------------------------------------------------------------------------------------------------------------------------//
        //                                        1a_manager_ManageAccount.cs : AddAccount ; ln 134                                         //                                                  
        //----------------------------------------------------------------------------------------------------------------------------------//
        public static DataTable AddAccount(string email, string username, string role, string phoneNumber) 
        {
            using (SqlConnection connection = new SqlConnection(database)) 
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


        //----------------------------------------------------------------------------------------------------------------------------------//
        //                                        1a_manager_ManageAccount.cs : DeleteAccount ; ln 162                                      //                                                  
        //----------------------------------------------------------------------------------------------------------------------------------//
        public static DataTable DeleteAccount(string accountID) 
        {
            using (SqlConnection connection = new SqlConnection(database)) 
            {
                connection.Open();

                string deleteQuery = "DELETE FROM ACCOUNT " +
                                     "WHERE AccountID = @AccountID";

                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection)) 
                {
                    deleteCommand.Parameters.AddWithValue("@AccountID", accountID);
                    deleteCommand.ExecuteNonQuery();
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


        //----------------------------------------------------------------------------------------------------------------------------------//
        //                                        1b_manager_ManageFacility.cs : LoadFacility ; ln 61                                       //                                                  
        //----------------------------------------------------------------------------------------------------------------------------------//
        public static DataTable LoadFacility() 
        {
            using (SqlConnection connection = new SqlConnection(database)) 
            {
                connection.Open();

                string query = "SELECT * FROM FACILITY";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection)) 
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }



        //----------------------------------------------------------------------------------------------------------------------------------//
        //                                        1b_manager_ManageFacility.cs : AddFacility ; ln 137                                       //                                                  
        //----------------------------------------------------------------------------------------------------------------------------------//
        public static DataTable AddFacility(string facility_name, string facility_type, string facility_status, double facility_rate) 
        {
            using (SqlConnection connection = new SqlConnection(database)) 
            {
                connection.Open();

                string newFacilityID = "F001";
                string getMaxIdQuery = "SELECT TOP 1 FacilityID FROM FACILITY " +
                                       "ORDER BY FacilityID DESC";

                using (SqlCommand getMaxIdcommand = new SqlCommand(getMaxIdQuery, connection)) 
                {
                    object result = getMaxIdcommand.ExecuteScalar();
                    if (result != null) 
                    {
                        string lastId = result.ToString();
                        int number = int.Parse(lastId.Substring(1));
                        newFacilityID = "F" + (number + 1).ToString("D3");
                    }
                }

                string insertQuery = "INSERT INTO FACILITY (FacilityID, FacilityName, FacilityType, FacilityStatus, Rate) " +
                                     "VALUES (@FacilityID, @FacilityName, @FacilityType, @FacilityStatus, @Rate)";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection)) 
                {
                    insertCommand.Parameters.AddWithValue("@FacilityID", newFacilityID);
                    insertCommand.Parameters.AddWithValue("@FacilityName", facility_name);
                    insertCommand.Parameters.AddWithValue("@FacilityType", facility_type);
                    insertCommand.Parameters.AddWithValue("@FacilityStatus", facility_status);
                    insertCommand.Parameters.AddWithValue("@Rate", facility_rate);

                    insertCommand.ExecuteNonQuery();
                }

                string selectQuery = "SELECT * FROM FACILITY";

                using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection)) 
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }


        //----------------------------------------------------------------------------------------------------------------------------------//
        //                                      1b_manager_ManageFacility.cs : DeleteFacility ; ln 168                                      //                                                  
        //----------------------------------------------------------------------------------------------------------------------------------//
        public static DataTable DeleteFacility(string facilityID) 
        {
            using (SqlConnection connection = new SqlConnection(database)) 
            {
                connection.Open();

                string deleteQuery = "DELETE * FROM FACILITY " +
                                     "WHERE FaclityID = @FacilityID";

                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection)) 
                {
                    deleteCommand.Parameters.AddWithValue("@FacilityID", facilityID);
                    deleteCommand.ExecuteNonQuery();
                }

                string selectQuery = "SELECT * FROM FACILITY";

                using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection)) 
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }


        //----------------------------------------------------------------------------------------------------------------------------------//
        //                                     1b_manager_ManageFacility.cs : UpdateFacility ; ln 201                                       //                                                  
        //----------------------------------------------------------------------------------------------------------------------------------//
        public static DataTable UpdateFacility(string facility_id, string facility_name, string facility_type, string facility_status, double facility_rate) 
        {
            using (SqlConnection connection = new SqlConnection(database)) 
            {
                connection.Open();

                string updateQuery = "UPDATE FACILITY " +
                                     "SET " +
                                     "FacilityName     = @FacilityName, " +
                                     "FacilityType     = @Facilitytype, " +
                                     "FacilityStatus   = @FacilityStatus, " +
                                     "Rate             = @Rate " +
                                     "WHERE FacilityID = @FacilityID";

                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection)) 
                {
                    updateCommand.Parameters.AddWithValue("@FacilityName", facility_name);
                    updateCommand.Parameters.AddWithValue("@FacilityType", facility_type);
                    updateCommand.Parameters.AddWithValue("@FacilityStatus", facility_status);
                    updateCommand.Parameters.AddWithValue("@Rate", facility_rate);
                    updateCommand.Parameters.AddWithValue("@FacilityID", facility_id);

                    updateCommand.ExecuteNonQuery();
                }

                string selectQuery = "SELECT * FROM FACILITY";

                using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection)) 
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }


        public static DataTable LoadSchedules()
        {
            using (SqlConnection connection = new SqlConnection(database))
            {
                connection.Open();

                string query = "SELECT MaintenanceID, FacilityID, AccountID, MaintenanceType, MaintenanceStatus, MaintenanceDate " +
                               "FROM MAINTENANCE ";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }
}