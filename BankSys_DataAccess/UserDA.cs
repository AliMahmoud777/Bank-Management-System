using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace BankSys_DataAccess
{
    public class UserDA
    {
        public static DataTable GetAllUsers()
        {
            DataTable result = new DataTable();

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT UserID, Users.MemberID, Username, CONCAT(Members.FirstName, ' ', Members.LastName) AS FullName, 
                                 Permissions FROM Users INNER JOIN Members ON Users.MemberID = Members.MemberID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                result.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                }

                return result;
            }
        }

        public static bool GetUserByID(int UserID, ref int MemberID, ref string Username, ref string Password,
            ref int Permissions, ref string ImagePath)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_GetUserByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                MemberID = (int)reader["MemberID"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                Permissions = Convert.ToInt32(reader["Permissions"]);
                                ImagePath = Convert.ToString(reader["ImagePath"]);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }

                return isFound;
            }
        }

        public static bool GetUserByUsername(string Username, ref int UserID, ref int MemberID, ref string Password,
            ref int Permissions, ref string ImagePath)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT * FROM Users WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", Username);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                UserID = (int)reader["UserID"];
                                MemberID = (int)reader["MemberID"];
                                Password = (string)reader["Password"];
                                Permissions = Convert.ToInt32(reader["Permissions"]);
                                ImagePath = Convert.ToString(reader["ImagePath"]);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }

                return isFound;
            }
        }

        public static int AddNewUser(int MemberID, string Username, string Password, int Permissions, string ImagePath)
        {
            int UserID = -1;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_AddNewUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MemberID", MemberID);
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Permissions", Permissions);
                    if (ImagePath == null || ImagePath == "")
                    {
                        command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    }

                    SqlParameter outputID = new SqlParameter("@UserID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        UserID = (int)command.Parameters["@UserID"].Value;

                    }
                    catch (Exception ex)
                    {
                        return -1;
                    }
                }

                return UserID;
            }
        }

        public static bool UpdateUser(int UserID, string Username, string Password, int Permissions,
            string ImagePath)
        {
            int rowsAffected = default;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_UpdateUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Permissions", Permissions);
                    if (ImagePath == null || ImagePath == "")
                    {
                        command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    }

                    try
                    {
                        connection.Open();

                        rowsAffected = command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }

                return (rowsAffected != 0);
            }
        }

        public static bool DeleteUser(int UserID)
        {
            int rowsAffected = default;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_DeleteUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();

                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }

                return (rowsAffected != 0);
            }
        }

        public static bool IsUserExists(int UserID)
        {
            using(SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT 1 FROM Users WHERE UserID = @UserID";

                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null)
                            return true;
                        else
                            return false;
                    }
                    catch(Exception ex)
                    {
                        return false;
                    }
                }
            }
        }

        public static bool IsUserExists(string Username)
        {
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT 1 FROM Users WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", Username);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null)
                            return true;
                        else
                            return false;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }

        public static bool IsUserExistsByMemberID(int MemberID)
        {
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT 1 FROM Users WHERE MemberID = @MemberID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", MemberID);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null)
                            return true;
                        else
                            return false;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }

        public static string GetPasswordByUsername(string Username)
        {
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT Password FROM Users WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", Username);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null)
                            return result.ToString();
                        else
                            return null;
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                }
            }
        }

        public static bool ChangePermissions(int UserID, int Permissions)
        {
            using(SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"UPDATE Users SET Permissions = @Permissions WHERE UserID = @UserID;";

                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(@"UserID", UserID);
                    command.Parameters.AddWithValue("@Permissions", Permissions);

                    try
                    {
                        connection.Open();

                        if (command.ExecuteNonQuery() != 0)
                            return true;
                        else
                            return false;
                    }
                    catch(Exception ex)
                    {
                        return false;
                    }
                }
            }
        }

        public static void AddToLogRegistry(int UserID)
        {
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"INSERT INTO LogRegistry Values(@UserID, @Date);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@Date", DateTime.Now);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        return;
                    }
                }
            }
        }

        public static DataTable GetAllLogs()
        {
            DataTable result = new DataTable();

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT LogID, LogRegistry.UserID, Username, Date FROM LogRegistry
                                 INNER JOIN Users ON LogRegistry.UserID = Users.UserID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                result.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }

                    return result;
                }
            }
        }
    }
}