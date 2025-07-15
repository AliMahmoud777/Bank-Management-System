using System;
using System.Data;
using BankSys_DataAccess;

namespace BankSys_Business
{
    public class CountryBusiness
    {
        public int CountryID { get; set; }
        public string Name { get; set; }

        private CountryBusiness(int prCountryID, string prName)
        {
            CountryID = prCountryID;
            Name = prName;
        }

        public static CountryBusiness GetCountryByID(int CountryID)
        {
            string Name = null;

            if (CountryDA.GetCountryByID(CountryID, ref Name))
                return new CountryBusiness(CountryID, Name);
            else
                return null;
        }

        public static CountryBusiness GetCountryByName(string Name)
        {
            int CountryID = -1;

            if (CountryDA.GetCountryByName(Name, ref CountryID))
                return new CountryBusiness(CountryID, Name);
            else
                return null;
        }

        public static DataTable GetAllCountries()
        {
            return CountryDA.GetAllCountries();
        }
    }
}