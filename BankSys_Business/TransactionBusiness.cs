using System;
using System.Data;
using BankSys_DataAccess;

namespace BankSys_Business
{
    public class TransactionBusiness
    {
        public static DataTable GetAllTransactions()
        {
            return TransactionDA.GetAllTransactions();
        }

        public static DataTable GetAccountTransaction(int AccountID)
        {
            return TransactionDA.GetAccountTransactions(AccountID);
        }

        public static DataTable GetAllTransfers()
        {
            return TransactionDA.GetAllTransfers();
        }

        public static DataTable GetAccountTransfers(int AccountID)
        {
            return TransactionDA.GetAccountTransfers(AccountID);
        }
    }
}