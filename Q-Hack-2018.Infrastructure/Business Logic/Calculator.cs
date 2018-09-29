using System;
using System.Collections.Generic;
using System.Text;

namespace Q_Hack_2018.Infrastructure.Business_Logic
{
    public static class Calculator
    {
        /// <summary>
        /// At the moment, this just returns a rounded amount.
        /// 
        /// In the future, we can extend this out for other calculation methods
        /// </summary>
        /// <returns></returns>
        public static decimal CalculateAmount(decimal transactionValue)
        {
            if (transactionValue > 0)
            {
                // Account credit, don't return anything..
                return 0;
            }
            else
            {
                // Don't forget spending is negative values.
                decimal roundedValue = Math.Ceiling(System.Math.Abs(transactionValue));

                // Return the difference from the overall transation rounded amount.
                return (roundedValue - transactionValue);
            }
            
        }
    }
}
