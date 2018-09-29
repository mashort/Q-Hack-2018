using System;
using System.Collections.Generic;
using System.Text;
using Q_Hack_2018.Core.Entities;
using Q_Hack_2018.Infrastructure.Data;

namespace Q_Hack_2018.Infrastructure.Business_Logic
{
    public static class TransactionClassifier
    {
        private static Dictionary<string, int> _categorisationMatches;
        private static Dictionary<int, Category> _categories;

        static TransactionClassifier()
        {
            _categorisationMatches = new Dictionary<string, int>();
            
            // Load the Categories from the DB.
            _categories = new DAL().GetCategories();

            // Load the CategorisationMatches from the DB.
            _categorisationMatches = new DAL().GetCategorisationMatches();
        }


        public static Category GetCategory(TransactionType transactionType, string transactionDescription)
        {
            // Only process transaction types that we're going to consider.
            if (transactionType.Process.HasValue && transactionType.Process.Value)
            {
                if (transactionType.HardCategoryID.HasValue )
                {
                    // Just return the specific category for this transaction type.
                    return _categories[transactionType.HardCategoryID.Value];
                }
                else
                {
                    // Work out the category from the description
                    if (_categorisationMatches.ContainsKey(transactionDescription))
                    {
                        return _categories[_categorisationMatches[transactionDescription]];
                    }
                    else
                    {
                        // May want to change this to anbother category to "fake" more categories in the dummy api data.
                        return null;
                    }
                }
            }
            else
            {
                // May want to change this to anbother category to "fake" more categories in the dummy api data.
                return null;
            }
        }
    }
}
