using System;
using System.Collections.Generic;
using Q_Hack_2018.Infrastructure.Data;
using Q_Hack_2018.Core.Entities;
using System.Text;
using System.Threading.Tasks;

namespace Q_Hack_2018.Infrastructure.Business_Logic
{
    /// <summary>
    /// This is the main class for processing output from the BankOfApis get transactions method.
    /// </summary>
    public class TxnProcessor
    {
        public async Task ProcessTransactions()
        {
            Dictionary<int, Category> categoryDict = new Dictionary<int, Category>();
            
            // TODO: Load the categories.

            
            // Request the list of transactions from the Bank of APIs
            List<Transaction> bankTransactions = await new ServiceRepository().GetTransactions();

            foreach (Transaction t in bankTransactions)
            {
                // Get the TXN Type ID
                TransactionType txntype = TransactionTypeClassifier.GetTransactionType(t.TransactionType);

                // Categorise this transaction
                Category c = TransactionClassifier.GetCategory(txntype, t.TransactionDescription);

                // Work out what that means money wise
                decimal givingAmount = Calculator.CalculateAmount(t.TransactionAmount);

                // Work out running totals
                categoryDict[c.Id].AddAmount(givingAmount);

                // Store to the DB




            }

        }

    }
}
