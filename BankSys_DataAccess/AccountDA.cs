using System;
using System.Data;
using System.Data.SqlClient;

namespace BankSys_DataAccess
{
    public static class AccountDA
    {
        public static DataTable GetAllAccounts()
        {
            DataTable result = new DataTable();

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT AccountID, Accounts.MemberID, CONCAT(Members.FirstName, ' ', Members.LastName) AS FullName,
                                 Balance, CreatedDate FROM Accounts INNER JOIN Members ON Accounts.MemberID = Members.MemberID;";

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

        public static bool GetAccountByID(int AccountID, ref int MemberID, ref decimal Balance, ref string Password,
            ref string SerialNumber, ref DateTime CreatedDate, ref int UserID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_GetAccountByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountID", AccountID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                MemberID = (int)reader["MemberID"];
                                Balance = (decimal)reader["Balance"];
                                Password = (string)reader["Password"];
                                SerialNumber = (string)reader["SerialNumber"];
                                CreatedDate = (DateTime)reader["CreatedDate"];
                                UserID = (int)reader["UserID"];
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

        public static bool GetAccountBySerialNumber(string SerialNumber, ref int AccountID, ref int MemberID, ref decimal Balance, ref string Password,
            ref DateTime CreatedDate, ref int UserID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT * FROM Accounts WHERE SerialNumber = @SerialNumber;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SerialNumber", SerialNumber);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                AccountID = (int)reader["AccountID"];
                                MemberID = (int)reader["MemberID"];
                                Balance = (decimal)reader["Balance"];
                                Password = (string)reader["Password"];
                                CreatedDate = (DateTime)reader["CreatedDate"];
                                UserID = (int)reader["UserID"];
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

        public static int AddNewAccount(int MemberID, decimal Balance, string Password, string SerialNumber,
            DateTime CreatedDate, int UserID)
        {
            int AccountID = -1;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_AddNewAccount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MemberID", MemberID);
                    command.Parameters.AddWithValue("@Balance", Balance);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@SerialNumber", SerialNumber);
                    command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                    command.Parameters.AddWithValue("@UserID", UserID);

                    SqlParameter outputID = new SqlParameter("@AccountID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        AccountID = (int)command.Parameters["@AccountID"].Value;

                    }
                    catch (Exception ex)
                    {
                        return -1;
                    }
                }

                return AccountID;
            }
        }

        public static bool ChangePassword(int AccountID, string Password)
        {
            int rowsAffected = default;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_UpdateAccountPassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountID", AccountID);
                    command.Parameters.AddWithValue("@Password", Password);

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

        public static bool DeleteAccount(int AccountID)
        {
            int rowsAffected = default;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_DeleteAccount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountID", AccountID);

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

        public static bool IsAccountExists(int AccountID)
        {
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT 1 FROM Accounts WHERE AccountID = @AccountID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountID", AccountID);

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

        public static bool IsAccountExistsByMemberID(int MemberID)
        {
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT 1 FROM Accounts WHERE MemberID = @MemberID";

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

        public static string GetPasswordBySerialNumber(string SerialNumber)
        {
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT Password FROM Accounts WHERE SerialNumber = @SerialNumber";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SerialNumber", SerialNumber);

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

        public static string GetPasswordByAccountID(int AccountID)
        {
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT Password FROM Accounts WHERE AccountID = @AccountID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountID", AccountID);

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

        public static bool DepositToAccount(int AccountID, decimal depositAmount, int UserID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Deposit", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountID", AccountID);
                    command.Parameters.AddWithValue("@Amount", depositAmount);
                    command.Parameters.AddWithValue("@Date", DateTime.Now);
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();

                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        return false;
                    }

                    return (rowsAffected != 0);
                }
            }
        }

        public static bool WithdrawToAccount(int AccountID, decimal withdrawAmount, int UserID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Withdraw", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountID", AccountID);
                    command.Parameters.AddWithValue("@Amount", withdrawAmount);
                    command.Parameters.AddWithValue("@Date", DateTime.Now);
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

                    return (rowsAffected != 0);
                }
            }
        }

        public static bool TransferToAccount(int AccountID, int destinationAccount, decimal transferAmount, int UserID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_Transfer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountID", AccountID);
                    command.Parameters.AddWithValue("@Amount", transferAmount);
                    command.Parameters.AddWithValue("@Date", DateTime.Now);
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@DestinationAccountID", destinationAccount);

                    try
                    {
                        connection.Open();

                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }

                    return (rowsAffected != 0);
                }
            }
        }
    }
}