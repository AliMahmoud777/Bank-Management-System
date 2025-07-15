using System;
using System.Data;
using System.Data.SqlClient;

namespace BankSys_DataAccess
{
    public class TransactionDA
    {
        public static DataTable GetAllTransactions()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT TransactionID, AccountID, Amount, Date, TypeName FROM Transactions
                                 INNER JOIN TransactionTypes ON Transactions.TypeID = TransactionTypes.TypeID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                    catch(Exception ex)
                    {
                        return null;
                    }

                    return dt;
                }
            }
        }

        public static DataTable GetAccountTransactions(int AccountID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT TransactionID, AccountID, Amount, Date, TypeName FROM Transactions
                                 INNER JOIN TransactionTypes ON Transactions.TypeID = TransactionTypes.TypeID
                                 WHERE AccountID = @AccountID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountID", AccountID);
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }

                    return dt;
                }
            }
        }

        public static DataTable GetAllTransfers()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT T.TransactionID, AccountID, Amount, DestinationAccountID, Date
                                 FROM Transactions T INNER JOIN Transfers ON T.TransactionID = Transfers.TransactionID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                    catch(Exception ex)
                    {
                        return null;
                    }

                    return dt;
                }
            }
        }

        public static DataTable GetAccountTransfers(int AccountID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT T.TransactionID, AccountID, Amount, DestinationAccountID, Date
                                 FROM Transactions T INNER JOIN Transfers ON T.TransactionID = Transfers.TransactionID
                                 WHERE @AccountID = AccountID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountID", AccountID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }

                    return dt;
                }
            }
        }
    }
}