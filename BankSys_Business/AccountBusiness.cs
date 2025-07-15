using System;
using System.Data;
using BankSys_DataAccess;

namespace BankSys_Business
{
    public class AccountBusiness
    {
        private enum enMode { Add, Update };
        private enMode _Mode = enMode.Add;

        public int AccountID { get; set; }
        public MemberBusiness Member { get; set; }

        private decimal _Balance;
        public decimal Balance { 
            get
            { 
                return _Balance;
            }
            
            set 
            {
                if (_Mode != enMode.Add)
                    return;

                _Balance = value;
            }
        }
        public string Password { get; set; }
        public string SerialNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public UserBusiness User { get; set; }

        public AccountBusiness()
        {
            AccountID = -1;
            Member = new MemberBusiness();
            Balance = default;
            Password = null;
            SerialNumber = null;
            CreatedDate = DateTime.Now;
            User = new UserBusiness();

            _Mode = enMode.Add;
        }

        public AccountBusiness(int accountID, int memberID, decimal balance, string password, string serialNumber, 
            DateTime createdDate, int userID)
        {
            AccountID = accountID;
            Member = MemberBusiness.GetMemberByID(memberID);
            Balance = balance;
            Password = password;
            SerialNumber = serialNumber;
            CreatedDate = createdDate;
            User = UserBusiness.GetUserByID(userID);

            _Mode = enMode.Update;
        }

        public static AccountBusiness GetAccountByID(int accountID)
        {
            int memberID = -1, userID = -1;
            string password = null, serialNumber = null;
            DateTime createdDate = DateTime.Now;
            decimal balance = default;

            if (AccountDA.GetAccountByID(accountID, ref memberID, ref balance, ref password, ref serialNumber, 
                ref createdDate, ref userID))
            {
                return new AccountBusiness(accountID, memberID, balance, password, serialNumber, createdDate, userID);
            }
            else
            {
                return null;
            }
        }

        public static AccountBusiness GetAccountBySerialNumber(string serialNumber)
        {
            int accountID = -1, memberID = -1, userID = -1;
            string password = null;
            DateTime createdDate = DateTime.Now;
            decimal balance = default;

            if (AccountDA.GetAccountBySerialNumber(serialNumber, ref accountID, ref memberID, ref balance, ref password,
                ref createdDate, ref userID))
            {
                return new AccountBusiness(accountID, memberID, balance, password, serialNumber, createdDate, userID);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewAccount()
        {
            AccountID = AccountDA.AddNewAccount(Member.MemberID, Balance, Password, SerialNumber, CreatedDate, User.UserID);

            return (AccountID != -1);
        }

        private bool _ChangePassword()
        {
            return AccountDA.ChangePassword(AccountID, Password);
        }

        public static bool DeleteAccount(int accountID)
        {
            return AccountDA.DeleteAccount(accountID);
        }

        public static DataTable GetAllAccounts()
        {
            return AccountDA.GetAllAccounts();
        }

        public static bool IsAccountExists(int accountID)
        {
            return AccountDA.IsAccountExists(accountID);
        }

        public static bool IsAccountExistsByMemberID(int memberID)
        {
            return AccountDA.IsAccountExistsByMemberID(memberID);
        }

        public static string GetPasswordBySerialNumber(string serialNumber)
        {
            return AccountDA.GetPasswordBySerialNumber(serialNumber);
        }

        public static string GetPasswordByID(int accountID)
        {
            return AccountDA.GetPasswordByAccountID(accountID);
        }

        public bool Deposit(decimal depositAmount, int userID)
        {
            if (AccountDA.DepositToAccount(this.AccountID, depositAmount, userID))
            {
                this._Balance += depositAmount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Withdraw(decimal withdrawAmount, int userID)
        {
            if (AccountDA.WithdrawToAccount(this.AccountID, withdrawAmount, userID))
            {
                this._Balance -= withdrawAmount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Transfer(AccountBusiness sourceAccount, AccountBusiness destinationAccount, decimal transferAmount, int userID)
        {
            if (AccountDA.TransferToAccount(sourceAccount.AccountID, destinationAccount.AccountID, transferAmount, userID))
            {
                sourceAccount._Balance -= transferAmount;
                destinationAccount._Balance += transferAmount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    if (_AddNewAccount())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _ChangePassword();
            }

            return false;
        }
    }
}