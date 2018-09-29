using Q_Hack_2018.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q_Hack_2018.Infrastructure.Business_Logic
{
    public class FeedbackInfo
    {
        public static int DaysPaid(decimal givenAmount)
        {
            int daysPaid = 0;

            decimal averageDailyCost = new DAL().GetAverageDailyCost();

            daysPaid = (int)Math.Ceiling(givenAmount / averageDailyCost);

            return daysPaid;
        }

        public static string CategoriesGivenAsString()
        {
            List<string> calcHistory = new DAL().GetLatestCalculationHistory();

            if (calcHistory.Count == 0)
            {
                return "no categories";
            }
            else if (calcHistory.Count == 1)
            {
                return "<span class='category-text--category'>" +  calcHistory[0] + "</span> category";
            }
            else
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < (calcHistory.Count - 1); i++)
                {
                    sb.Append("<span class='category-text--category'>");
                    sb.Append(calcHistory[i]);
                    sb.Append("</span>");
                    sb.Append(", ");
                }

                sb.Remove((sb.Length - 2), 2);

                sb.Append(" and ");
                sb.Append("<span class='category-text--category'>");
                sb.Append(calcHistory[(calcHistory.Count - 1)]);
                sb.Append("</span>");
                sb.Append(" categories");

                return sb.ToString();
            }
        }

    }
}
