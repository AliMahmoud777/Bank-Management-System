using System;
using System.Data;
using System.Data.SqlClient;

namespace BankSys_DataAccess
{
    public static class CountryDA
    {
        public static DataTable GetAllCountries()
        {
            DataTable result = new DataTable();

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT Name FROM Countries;";

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
        public static bool GetCountryByID(int CountryID, ref string Name)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_GetCountryByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CountryID", CountryID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                Name = (string)reader["Name"];
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

        public static bool GetCountryByName(string Name, ref int CountryID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT * FROM Countries WHERE Name = @Name;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", Name);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                CountryID = (int)reader["CountryID"];
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
    }
}
