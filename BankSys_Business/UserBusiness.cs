using BankSys_DataAccess;
using System;
using System.Data;

namespace BankSys_Business
{
    public class UserBusiness
    {
        enum enMode { Add, Update };
        private enMode _Mode = enMode.Add;

        public int UserID { get; set; }
        public MemberBusiness Member { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }
        public string ImagePath { get; set; }

        public UserBusiness()
        {
            UserID = -1;
            Member = new MemberBusiness();
            Username = null;
            Password = null;
            Permissions = 0;
            ImagePath = null;

            _Mode = enMode.Add;
        }

        public UserBusiness(int userID, int memberID, string username, string password, int permissions, string imagePath)
        {
            UserID = userID;
            Member = MemberBusiness.GetMemberByID(memberID);
            Username = username;
            Password = password;
            Permissions = permissions;
            ImagePath = imagePath;

            _Mode = enMode.Update;
        }

        public static UserBusiness GetUserByID(int UserID)
        {
            int MemberID = -1, Permissions = 0;
            string Username = "", Password = "", ImagePath = "";

            if(UserDA.GetUserByID(UserID, ref MemberID, ref Username, ref Password, ref Permissions, ref ImagePath))
            {
                return new UserBusiness(UserID, MemberID, Username, Password, Permissions, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static UserBusiness GetUserByUsername(string Username)
        {
            int UserID = -1, MemberID = -1, Permissions = 0;
            string Password = "", ImagePath = "";

            if (UserDA.GetUserByUsername(Username, ref UserID, ref MemberID, ref Password, ref Permissions, ref ImagePath))
            {
                return new UserBusiness(UserID, MemberID, Username, Password, Permissions, ImagePath);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewUser()
        {
            this.UserID = UserDA.AddNewUser(Member.MemberID, Username, Password, Permissions, ImagePath);

            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return UserDA.UpdateUser(UserID, Username, Password, Permissions, ImagePath);
        }

        public static bool DeleteUser(int UserID)
        {
            return UserDA.DeleteUser(UserID);
        }

        public static DataTable GetAllUsers()
        {
            return UserDA.GetAllUsers();
        }

        public static bool IsUserExists(int UserID)
        {
            return UserDA.IsUserExists(UserID);
        }

        public static bool IsUserExists(string Username)
        {
            return UserDA.IsUserExists(Username);
        }

        public static bool IsUserExistsByMemberID(int MemberID)
        {
            return UserDA.IsUserExistsByMemberID(MemberID);
        }

        public void AddToLogRegistry()
        {
            UserDA.AddToLogRegistry(this.UserID);
        }

        public static DataTable GetAllLogs()
        {
            return UserDA.GetAllLogs();
        }

        public static string GetPasswordByUsername(string Username)
        {
            return UserDA.GetPasswordByUsername(Username);
        }

        public bool ChangePermissions(int Permissions)
        {
            return UserDA.ChangePermissions(this.UserID, Permissions);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }
    }
}