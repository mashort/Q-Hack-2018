using Microsoft.AspNetCore.Mvc.RazorPages;
using Q_Hack_2018.Infrastructure.Business_Logic;
using Q_Hack_2018.Infrastructure.Data;
using System.ComponentModel.DataAnnotations;

namespace Q_Hack_2018.Pages
{
    public class ContributionConfirmModel : PageModel
    {
        [DisplayFormat(DataFormatString = "{0:N}")]
        public decimal PotTotal { get; set; }

        public string GivenDays { get; set; }

        public string CategoriesChosen { get; set; }

        public void OnGet()
        {
            PotTotal = GetPotTotal();

            GivenDays = GetGivenDays();

            CategoriesChosen = GetCategoriesChosen();
        }

        public decimal GetPotTotal()
        {
            decimal returnVal;

            decimal potTotal = new DAL().GetLatestGivingHistory();

            returnVal = potTotal;

            return returnVal;
        }

        public string GetGivenDays()
        {
            string returnVal = string.Empty;

            int daysPaid = FeedbackInfo.DaysPaid(PotTotal);

            returnVal = daysPaid.ToString();

            return returnVal;
        }

        public string GetCategoriesChosen()
        {
            string returnVal = string.Empty;

            returnVal = FeedbackInfo.CategoriesGivenAsString();

            return returnVal;
        }
    }
}