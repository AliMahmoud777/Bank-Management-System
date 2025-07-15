using System;
using System.Data;
using BankSys_DataAccess;

namespace BankSys_Business
{
    public class TransactionTypeBusiness
    {
        public int TypeID { get; set; }
        public string TypeName { get; }
        public decimal Fees { get; set; }

        private TransactionTypeBusiness(int typeID, string typeName, decimal fees)
        {
            TypeID = typeID;
            TypeName = typeName;
            Fees = fees;
        }

        public static TransactionTypeBusiness GetTransactionTypeByID(int typeID)
        {
            string typeName = null;
            decimal fees = default;

            if (TransactionTypeDA.GetTransactionTypeByID(typeID, ref typeName, ref fees))
            {
                return new TransactionTypeBusiness(typeID, typeName, fees);
            }
            else
            {
                return null;
            }
        }

        public bool UpdateTransactionTypeFees(decimal fees)
        {
            this.Fees = fees;
            return TransactionTypeDA.UpdateTransactionTypeFees(this.TypeID, this.Fees);
        }
        public static DataTable GetAllTransactionTypes()
        {
            return TransactionTypeDA.GetAllTransactionTypes();
        }
    }
}