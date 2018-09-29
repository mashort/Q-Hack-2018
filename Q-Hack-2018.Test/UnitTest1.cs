using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q_Hack_2018.Infrastructure.Business_Logic;
using Q_Hack_2018.Infrastructure.Data;
using Q_Hack_2018.Core.Entities;
using System.Collections.Generic;

namespace Q_Hack_2018.Test
{
    [TestClass]
    public class UnitFeedbackInfoTests
    {
        [TestMethod]
        public void TestInsertCalculationHistory()
        {
            Category c1 = new Category(1, "Entertainment");
            c1.AddAmount((decimal)3.45);
            Category c2 = new Category(2, "Transport");
            c2.AddAmount((decimal)18.21);
            Category c3 = new Category(2, "Groceries");

            List<Category> catList = new List<Category>();
            catList.Add(c1);
            catList.Add(c2);
            catList.Add(c3);

            new DAL().InsertCalculationHistory(catList);

        }

        [TestMethod]
        public void TestCategoriesGivenAsString()
        {
            Category c1 = new Category(1, "Entertainment");
            c1.AddAmount((decimal)3.45);
            Category c2 = new Category(2, "Transport");
            c2.AddAmount((decimal)18.21);
            Category c3 = new Category(2, "Groceries");
            List<Category> catList = new List<Category>();
            catList.Add(c1);
            catList.Add(c2);
            catList.Add(c3);

            string a = FeedbackInfo.CategoriesGivenAsString();

        }
    }
}
