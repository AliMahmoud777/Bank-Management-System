using System;
using System.Data;
using BankSys_Business;
using BankSys_DataAccess;

namespace BankSys_Business
{
    public class MemberBusiness
    {
        private enum enMode { Add, Update };
        private enMode _Mode = enMode.Add;

        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public bool Gender { get; set; }

        public string GenderString
        {
            get
            {
                if (!Gender)
                    return "Male";
                else
                    return "Female";
            }
        }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public CountryBusiness Country { get; set; }

        private MemberBusiness(int memberID, string firstName, string lastName, bool gender, string email,
            DateTime dateOfBirth, string phoneNumber, string address, int countryID)
        {
            MemberID = memberID;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Email = email;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Address = address;
            Country = CountryBusiness.GetCountryByID(countryID);

            _Mode = enMode.Update;
        }

        public MemberBusiness()
        {
            MemberID = -1;
            FirstName = null;
            LastName = null;
            Gender = false;
            Email = null;
            DateOfBirth = DateTime.Now;
            PhoneNumber = null;
            Address = null;
            Country = null;

            _Mode = enMode.Add;
        }

        public static MemberBusiness GetMemberByID(int MemberID)
        {
            string firstName = null, lastName = null, email = null, phoneNumber = null, address = null;
            bool gender = false;
            DateTime dateOfBirth = DateTime.Now;
            int countryID = -1;

            if (MemberDA.GetMemberByID(MemberID, ref firstName, ref lastName, ref gender, ref email, ref dateOfBirth,
                ref phoneNumber, ref address, ref countryID))
                return new MemberBusiness(MemberID, firstName, lastName, gender, email, dateOfBirth, phoneNumber,
                    address, countryID);
            else
                return null;
        }

        private bool _AddNewMember()
        {
            this.MemberID = MemberDA.AddNewMember(FirstName, LastName, Gender, Email, DateOfBirth,
                PhoneNumber, Address, Country.CountryID);

            return (this.MemberID != -1);
        }

        private bool _UpdateMember()
        {
            return MemberDA.UpdateMember(MemberID, FirstName, LastName, Gender, Email,
                DateOfBirth, PhoneNumber, Address, Country.CountryID);
        }

        public static bool DeleteMember(int MemberID)
        {
            return MemberDA.DeleteMember(MemberID);
        }

        public static DataTable GetAllMembers()
        {
            return MemberDA.GetAllMembers();
        }

        public static bool IsMemberExists(int MemberID)
        {
            return MemberDA.IsMemberExists(MemberID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    if (_AddNewMember())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateMember();
            }

            return false;
        }
    }
}