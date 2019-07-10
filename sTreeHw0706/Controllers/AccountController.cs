using sTreeHw0706.Models;
using sTreeHw0706.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sTreeHw0706.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult _AccountInput()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult _AccountDetails()
        {
            List<MoneyViewModel> accountList = GetDetials();
            return PartialView(accountList);
        }

        private List<MoneyViewModel> GetDetials()
        {
            List<MoneyViewModel> accoutDetails = new List<MoneyViewModel>();
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            for (int i = 1; i < 101; i++)
            {
                MoneyViewModel aDetail = new MoneyViewModel
                {
                    No = i,
                    Type = rnd.Next() % 2 == 0 ? "收入" : "支出",
                    Datetime = GetRamData(rnd),
                    Amount = rnd.Next(100, 5000)
                };
                accoutDetails.Add(aDetail);
            }
            return accoutDetails;
        }

        private DateTime GetRamData(Random rnd)
        {
            DateTime start = new DateTime(2018, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range));
        }



    }
}