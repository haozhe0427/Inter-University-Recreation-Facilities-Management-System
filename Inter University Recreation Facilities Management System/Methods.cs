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
        //                                      1b_manager_ManageAccount.cs : SearchAccounts ; ln 116                                       //                                                  
        //----------------------------------------------------------------------------------------------------------------------------------//
        public static DataTable SearchAccount(string accountID, string email, string role, string username, string phoneNumber)
        {
            using (SqlConnection connection = new SqlConnection(database))
            {
                connection.Open();

                var conditions = new List<string>();
                var parameters = new List<SqlParameter>();

                if (!string.IsNullOrEmpty(accountID)) 
                {
                    conditions.Add("AccountID = @AccountID");
                    parameters.Add(new SqlParameter("@AccountID", accountID));
                }
                if (!string.IsNullOrEmpty(email))
                {
                    conditions.Add("Email = @Email");
                    parameters.Add(new SqlParameter("@Email", email));
                }
                if (!string.IsNullOrEmpty(role))
                {
                    conditions.Add("AccountRole = @AccountRole");
                    parameters.Add(new SqlParameter("@AccountRole", role));
                }
                if (!string.IsNullOrEmpty(username))
                {
                    conditions.Add("UserName = @UserName");
                    parameters.Add(new SqlParameter("@UserName", username));
                }
                if (!string.IsNullOrEmpty(phoneNumber))
                {
                    conditions.Add("ContactNumber = @ContactNumber");
                    parameters.Add(new SqlParameter("@ContactNumber", phoneNumber));
                }

                string selectQuery = "SELECT AccountID, Email, AccountRole, UserName, ContactNumber " +
                                     "FROM ACCOUNT WHERE " + string.Join(" AND ", conditions);

                using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection))
                {
                    adapter.SelectCommand.Parameters.AddRange(parameters.ToArray());

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No matching records found.");
                        return LoadAccounts(); // Reload all accounts if no matches found
                    }

                    return dataTable;
                }
            }
        }


        //----------------------------------------------------------------------------------------------------------------------------------//
        //                                      1b_manager_ManageAccount.cs : LoadAccounts ; ln 62                                          //                                                  
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
        //                                        1b_manager_ManageAccount.cs : AddAccount ; ln 151                                         //                                                  
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
                    insertCommand.Parameters.AddWithValue("@AccountID", newAccountID);
                    insertCommand.Parameters.AddWithValue("@Email", email);
                    insertCommand.Parameters.AddWithValue("@Password", defaultPassword);
                    insertCommand.Parameters.AddWithValue("@AccountRole", role);
                    insertCommand.Parameters.AddWithValue("@UserName", username);
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
        //                                        1b_manager_ManageAccount.cs : DeleteAccount ; ln 179                                      //                                                  
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
        //                                        1c_manager_ManageFacility.cs : LoadFacility ; ln 61                                       //                                                  
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
        //                                      1c_manager_ManageFacility.cs : SearchFacility ; ln 120                                      //                                                  
        //----------------------------------------------------------------------------------------------------------------------------------//
        public static DataTable SearchFacility(string facilityName, string facilityType, string facilityStatus, double? rate)
        {
            using (SqlConnection connection = new SqlConnection(database))
            {
                connection.Open();

                var conditions = new List<string>();
                var parameters = new List<SqlParameter>();

                if (!string.IsNullOrEmpty(facilityName))
                {
                    conditions.Add("FacilityName = @FacilityName");
                    parameters.Add(new SqlParameter("@FacilityName", facilityName));
                }

                if (!string.IsNullOrEmpty(facilityType))
                {
                    conditions.Add("FacilityType = @FacilityType");
                    parameters.Add(new SqlParameter("@FacilityType", facilityType));
                }

                if (!string.IsNullOrEmpty(facilityStatus))
                {
                    conditions.Add("FacilityStatus = @FacilityStatus");
                    parameters.Add(new SqlParameter("@FacilityStatus", facilityStatus));
                }

                if (rate.HasValue)
                {
                    conditions.Add("Rate = @Rate");
                    parameters.Add(new SqlParameter("@Rate", rate.Value));
                }

                string selectQuery = "SELECT * FROM FACILITY WHERE " + string.Join(" AND ", conditions);

                using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection))
                {
                    adapter.SelectCommand.Parameters.AddRange(parameters.ToArray());

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No matching records found.");
                        return LoadFacility(); // Reload all facilities if no matches found
                    }

                    return dataTable;
                }
            }
        }


        //----------------------------------------------------------------------------------------------------------------------------------//
        //                                        1c_manager_ManageFacility.cs : AddFacility ; ln 137                                       //                                                  
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
        //                                      1c_manager_ManageFacility.cs : DeleteFacility ; ln 168                                      //                                                  
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
        //                                     1c_manager_ManageFacility.cs : UpdateFacility ; ln 201                                       //                                                  
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


        //----------------------------------------------------------------------------------------------------------------------------------//
        //                                     1d_manager_AssignSchedule.cs : LoadSchedules ; ln 68                                         //                                                  
        //----------------------------------------------------------------------------------------------------------------------------------//
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


        //----------------------------------------------------------------------------------------------------------------------------------//
        //                                     1d_manager_AssignSchedule.cs : SearchSchedules ; ln 127                                      //                                                  
        //----------------------------------------------------------------------------------------------------------------------------------//
        public static DataTable SearchSchedule(string facilityID, string accountID, string maintenanceType, string status)
        {
            using (SqlConnection connection = new SqlConnection(database))
            {
                connection.Open();

                var conditions = new List<string>();
                var parameters = new List<SqlParameter>();

                if (!string.IsNullOrEmpty(facilityID))
                {
                    conditions.Add("FacilityID = @FacilityID");
                    parameters.Add(new SqlParameter("@FacilityID", facilityID));
                }
                if (!string.IsNullOrEmpty(accountID))
                {
                    conditions.Add("AccountID = @AccountID");
                    parameters.Add(new SqlParameter("@AccountID", accountID));
                }
                if (!string.IsNullOrEmpty(maintenanceType))
                {
                    conditions.Add("MaintenanceType = @MaintenanceType");
                    parameters.Add(new SqlParameter("@MaintenanceType", maintenanceType));
                }
                if (!string.IsNullOrEmpty(status))
                {
                    conditions.Add("MaintenanceStatus = @MaintenanceStatus");
                    parameters.Add(new SqlParameter("@MaintenanceStatus", status));
                }

                string selectQuery = "SELECT MaintenanceID, FacilityID, AccountID, MaintenanceType, MaintenanceStatus, MaintenanceDate " +
                                     "FROM MAINTENANCE WHERE " + string.Join(" AND ", conditions);

                using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection))
                {
                    adapter.SelectCommand.Parameters.AddRange(parameters.ToArray());

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No matching records found.");
                        return LoadSchedules(); // Reload all schedules if no matches found
                    }

                    return dataTable;
                }
            }
        }


        //----------------------------------------------------------------------------------------------------------------------------------//
        //                                     1d_manager_AssignSchedule.cs : AssignSchedules ; ln 140                                      //                                                  
        //----------------------------------------------------------------------------------------------------------------------------------//
        public static DataTable AssignSchedule(string facilityID, string accountID, string maintenanceType, DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(database))
            {
                connection.Open();

                string newMaintenanceID = "M00001";
                string getMaxIdQuery = "SELECT TOP 1 MaintenanceID FROM MAINTENANCE " +
                                          "ORDER BY MaintenanceID DESC";

                using (SqlCommand getMaxIdCommand = new SqlCommand(getMaxIdQuery, connection))
                {
                    object result = getMaxIdCommand.ExecuteScalar();
                    if (result != null)
                    {
                        string lastId = result.ToString();
                        int number = int.Parse(lastId.Substring(1));
                        newMaintenanceID = "M" + (number + 1).ToString("D5");
                    }
                }
                string status = "Unfinished";
                string startTime = null;
                string endTime = null;

                string insertQuery = "INSERT INTO MAINTENANCE (MaintenanceID, FacilityID, AccountID, MaintenanceType, " +
                                     "MaintenanceStatus, MaintenanceDate, MaintenanceStartTime, MaintenanceEndTime) " +
                                     "VALUES (@MaintenanceID, @FacilityID, @AccountID, @MaintenanceType, " +
                                     "@MaintenanceStatus, @MaintenanceDate, @MaintenanceStartTime, @MaintenanceEndTime)";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@MaintenanceID", newMaintenanceID);
                    insertCommand.Parameters.AddWithValue("@FacilityID", facilityID);
                    insertCommand.Parameters.AddWithValue("@AccountID", accountID);
                    insertCommand.Parameters.AddWithValue("@MaintenanceType", maintenanceType);
                    insertCommand.Parameters.AddWithValue("@MaintenanceStatus", status);
                    insertCommand.Parameters.AddWithValue("@MaintenanceDate", date);
                    insertCommand.Parameters.AddWithValue("@MaintenanceStartTime", (object)startTime ?? DBNull.Value);
                    insertCommand.Parameters.AddWithValue("@MaintenanceEndTime", (object)endTime ?? DBNull.Value);
                    insertCommand.ExecuteNonQuery();
                }

                string selectQuery = "SELECT MaintenanceID, FacilityID, AccountID, MaintenanceType, MaintenanceStatus, MaintenanceDate " +
                                     "FROM MAINTENANCE ";

                using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }


        //----------------------------------------------------------------------------------------------------------------------------------//
        //                                     1d_manager_AssignSchedule.cs : UpdateSchedules ; ln 167                                      //                                                  
        //----------------------------------------------------------------------------------------------------------------------------------//
        public static DataTable UpdateSchedule(string maintenanceID, string facilityID, string accountID, string maintenanceType, string status, DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(database))
            {
                connection.Open();

                string updateQuery = "UPDATE MAINTENANCE SET " +
                                     "FacilityID = @FacilityID, " +
                                     "AccountID  = @AccountID, " +
                                     "MaintenanceType = @MaintenanceType, " +
                                     "MaintenanceStatus = @MaintenanceStatus, " +
                                     "MaintenanceDate = @MaintenanceDate " +
                                     "WHERE MaintenanceID = @MaintenanceID";

                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@FacilityID", facilityID);
                    updateCommand.Parameters.AddWithValue("@AccountID", accountID);
                    updateCommand.Parameters.AddWithValue("@MaintenanceType", maintenanceType);
                    updateCommand.Parameters.AddWithValue("@MaintenanceStatus", status);
                    updateCommand.Parameters.AddWithValue("@MaintenanceDate", date);
                    updateCommand.Parameters.AddWithValue("@MaintenanceID", maintenanceID);

                    updateCommand.ExecuteNonQuery();
                }

                string selectQuery = "SELECT MaintenanceID, FacilityID, AccountID, MaintenanceType, MaintenanceStatus, MaintenanceDate " +
                                     "FROM MAINTENANCE";

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