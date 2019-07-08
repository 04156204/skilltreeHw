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

        public ActionResult _AccountDetails()
        {
            List<MoneyViewModel> accountList = GetDetials();
            return PartialView(accountList);
        }

        private List<MoneyViewModel> GetDetials()
        {
            List<MoneyViewModel> accoutDetails = new List<MoneyViewModel>();
            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                MoneyViewModel aDetail = new MoneyViewModel
                {
                    Type = GetRamType(rnd),
                    Datetime = GetRamData(rnd),
                    Amount = rnd.Next(100, 5000)
                };
                accoutDetails.Add(aDetail);
            }
            return accoutDetails;
        }

        private string GetRamType(Random rnd)
        {   //Demo您好：在這兩個GetRandom method有個小問題。
            //原本的寫法不是傳入Random，而是在其中宣告如下
            //Random rnd = new Random();
            //每執行一次就會宣告一次。但這樣寫會導致有時候不會隨機。
            //逐步偵錯可以看到它確實每次都會進來，但每次傳出去的結果都是第一次隨機的結果。
            //10次以下它還"有時候"會做隨機，有時候不會。次數改成100次它就只會傳第一次隨機的結果。
            //我嘗試清除方案重建方案，發現這個好像沒有影響。是什麼導致這種隨機的不隨機@@
            int rndType = rnd.Next(0, 2);
            if (rndType == 0)
                return "收入";
            else
                return "支出";
        }

        private DateTime GetRamData(Random rnd)
        {            
            DateTime start = new DateTime(2018, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range));
        }



    }
}