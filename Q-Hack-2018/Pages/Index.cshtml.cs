using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Q_Hack_2018.Core.Entities;
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
            Categories = GetCategories();
        }

        private IList<Category> GetCategories()
        {
            List<Category> listOfCategories = new List<Category>();

            Category c1 = new Category(1, "Entertainment");
            Category c2 = new Category(2, "Transport");
            Category c3 = new Category(3, "Groceries");
            Category c4 = new Category(4, "Bills");
            Category c5 = new Category(5, "General");
            Category c6 = new Category(6, "Shopping");

            listOfCategories.Add(c1);
            listOfCategories.Add(c2);
            listOfCategories.Add(c3);
            listOfCategories.Add(c4);
            listOfCategories.Add(c5);
            listOfCategories.Add(c6);

            return listOfCategories;
        }
    }
}
