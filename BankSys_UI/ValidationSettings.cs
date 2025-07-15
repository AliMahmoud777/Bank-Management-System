using System;
using System.Text.RegularExpressions;

namespace BankSys_UI
{
    public static class ValidationSettings
    {
        public static bool ValidateEmail(string Email)
        {
            string Pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            Regex regex = new Regex(Pattern);

            return regex.IsMatch(Email);
        }
    }
}