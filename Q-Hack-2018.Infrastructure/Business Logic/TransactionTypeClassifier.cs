using System;
using System.Collections.Generic;
using System.Text;
using Q_Hack_2018.Core.Entities;

namespace Q_Hack_2018.Infrastructure.Business_Logic
{
    public static class TransactionTypeClassifier
    {
        private static Dictionary<string, TransactionType> _txnTypes;

        static TransactionTypeClassifier()
        {
            _txnTypes = new Dictionary<string, TransactionType>();

            // Load the dictionary from the DB.

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
