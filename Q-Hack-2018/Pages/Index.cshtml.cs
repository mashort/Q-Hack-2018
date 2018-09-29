using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Q_Hack_2018.Core.Entities;
using Q_Hack_2018.Infrastructure.Business_Logic;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Q_Hack_2018.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Category Category { get; set; }

        public IList<Category> Categories { get; set; }

        public async Task OnGetAsync()
        {
            Categories = await new TxnProcessor().ProcessTransactions();
        }        
    }
}
