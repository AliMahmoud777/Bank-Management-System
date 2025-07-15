using System;
using System.Configuration;
using DotNetEnv;

namespace BankSys_DataAccess
{
    public static class DataAccessSettings
    {
        public static readonly string connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
    }
}