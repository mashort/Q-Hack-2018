using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Q_Hack_2018.Core.Entities;
using Q_Hack_2018.Infrastructure.Data;

namespace Q_Hack_2018.Pages
{
    public class IndexModel : PageModel
    {
        public IList<Transaction> Transactions { get; set; }

        public async Task OnGetAsync()
        {
            // Transactions = await new ServiceRepository().GetTransactions();
            //await new TxnProcessor().ProcessTransactions()
        }
    }
}
