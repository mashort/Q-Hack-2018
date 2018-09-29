using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Q_Hack_2018.Infrastructure.Data;

namespace Q_Hack_2018.Pages
{
    public class ContributionConfirmModel : PageModel
    {
        [DisplayFormat(DataFormatString = "{0:N}")]
        public decimal PotTotal { get; set; }

        public void OnGet()
        {
            PotTotal = GetPotTotal();
        }

        public decimal GetPotTotal()
        {
            decimal returnVal;

            decimal potTotal = new DAL().GetLatestGivingHistory();

            returnVal = potTotal;

            return returnVal;
        }
    }
}