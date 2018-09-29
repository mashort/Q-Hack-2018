using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Q_Hack_2018.Core.Entities;
using Q_Hack_2018.Infrastructure.Business_Logic;
using Q_Hack_2018.Infrastructure.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Q_Hack_2018.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Category Category { get; set; }

        [DisplayFormat(DataFormatString = "{0:N}")]
        public decimal PotTotal { get; set; }

        public IList<Category> Categories { get; set; }

        public async Task OnGetAsync()
        {
            Categories = await new TxnProcessor().ProcessTransactions();

            PotTotal = GetPotTotal();
        }
        
        public decimal GetPotTotal()
        {
            decimal returnVal;

            decimal potTotal = new DAL().GetPotTotal();

            returnVal = potTotal;

            return returnVal;
        }
    }
}
