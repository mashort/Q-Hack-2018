using System;
using System.Collections.Generic;
using System.Text;
using Q_Hack_2018.Core.Entities;
using Q_Hack_2018.Infrastructure.Data;

namespace Q_Hack_2018.Infrastructure.Business_Logic
{
    public static class TransactionTypeClassifier
    {
        private static Dictionary<string, TransactionType> _txnTypes;

        static TransactionTypeClassifier()
        {
            // Load the dictionary from the DB.
            _txnTypes = new DAL().GetTransactionTypes();
        }

        public static TransactionType GetTransactionType(string txnTypeString)
        {
            if (_txnTypes.ContainsKey(txnTypeString))
            {
                return _txnTypes[txnTypeString];
            }
            else
            {
                // Hardcoded transaction type.
                return _txnTypes["POS"];
            }
        }
    }
}
