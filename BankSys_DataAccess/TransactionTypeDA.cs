using System;
using System.Data;
using System.Data.SqlClient;

namespace BankSys_DataAccess
{
    public class TransactionTypeDA
    {
        public static DataTable GetAllTransactionTypes()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT TypeName, Fees FROM TransactionTypes;";

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

        public static bool GetTransactionTypeByID(int ID, ref string TypeName, ref decimal Fees)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT * FROM TransactionTypes WHERE TypeID = @TypeID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                isFound = true;

                                TypeName = (string)reader["TypeName"];
                                Fees = (decimal)reader["Fees"];
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        isFound = false;
                    }

                    return isFound;
                }
            }
        }

        public static bool UpdateTransactionTypeFees(int ID, decimal Fees)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"UPDATE TransactionTypes SET Fees = @Fees WHERE TypeID = @TypeID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
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