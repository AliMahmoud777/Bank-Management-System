using System;
using System.Data;
using System.Data.SqlClient;

namespace BankSys_DataAccess
{
    public static class MemberDA
    {
        public static DataTable GetAllMembers()
        {
            DataTable result = new DataTable();

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT MemberID, FirstName, LastName, Countries.Name AS Country, 
                                 CASE Gender WHEN 0 THEN 'Male'
                                 ELSE 'Female' END AS GenderString
                                 FROM Members INNER JOIN Countries ON Members.CountryID = Countries.CountryID;";

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

        public static bool GetMemberByID(int MemberID, ref string FirstName, ref string LastName, ref bool Gender,
            ref string Email, ref DateTime DateOfBirth, ref string PhoneNumber, ref string Address, ref int CountryID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_GetMemberByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MemberID", MemberID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                FirstName = (string)reader["FirstName"];
                                LastName = (string)reader["LastName"];
                                Gender = (bool)reader["Gender"];
                                Email = Convert.ToString(reader["Email"]);
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                PhoneNumber = (string)reader["PhoneNumber"];
                                Address = (string)reader["Address"];
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

        public static int AddNewMember(string FirstName, string LastName, bool Gender, string Email,
            DateTime DateOfBirth, string PhoneNumber, string Address, int CountryID)
        {
            int MemberID = -1;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_AddNewMember", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    if (Email == null || Email == "")
                    {
                        command.Parameters.AddWithValue("@Email", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Email", Email);
                    }
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@CountryID", CountryID);

                    SqlParameter outputID = new SqlParameter("@MemberID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        MemberID = (int)command.Parameters["@MemberID"].Value;

                    }
                    catch (Exception ex)
                    {
                        return -1;
                    }
                }

                return MemberID;
            }
        }

        public static bool UpdateMember(int MemberID, string FirstName, string LastName, bool Gender, string Email,
            DateTime DateOfBirth, string PhoneNumber, string Address, int CountryID)
        {
            int rowsAffected = default;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_UpdateMember", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MemberID", MemberID);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    if (Email == null || Email == "")
                    {
                        command.Parameters.AddWithValue("@Email", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Email", Email);
                    }
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@CountryID", CountryID);

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

        public static bool DeleteMember(int MemberID)
        {
            int rowsAffected = default;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("usp_DeleteMember", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MemberID", MemberID);

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

        public static bool IsMemberExists(int MemberID)
        {
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString))
            {
                string query = @"SELECT 1 FROM Members WHERE MemberID = @MemberID";

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
    }
}