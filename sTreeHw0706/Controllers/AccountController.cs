using sTreeHw0706.Models;
using sTreeHw0706.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sTreeHw0706.EFRepository;
using sTreeHw0706.Business;

namespace sTreeHw0706.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Input(MoneyViewModel anAccount) {

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
            var accountBookDetails = new AccountService().AccountBookTurn();
            return PartialView(accountBookDetails);
        }

 

    }
}