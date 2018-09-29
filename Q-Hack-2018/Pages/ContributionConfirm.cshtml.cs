using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Q_Hack_2018.Infrastructure.Business_Logic;
using Q_Hack_2018.Infrastructure.Data;

namespace Q_Hack_2018.Pages
{
    public class ContributionConfirmModel : PageModel
    {
        [DisplayFormat(DataFormatString = "{0:N}")]
        public decimal PotTotal { get; set; }

        public string GivenDays { get; set; }

        public void OnGet()
        {
            PotTotal = GetPotTotal();

            GivenDays = GetGivenDays();
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
    }
}