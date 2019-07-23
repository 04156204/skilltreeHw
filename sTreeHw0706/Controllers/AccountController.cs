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
        private AccountService _accService;

        public AccountController()
        {
            _accService = new AccountService();
        }

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        [HttpGet]
        public ActionResult _AccountInput()
        {
            return View();
        }

        [HttpPost]
        public ActionResult _InputAccount(MoneyViewModel anAccount) {
            var res = _accService.addAcc(anAccount);

            return RedirectToAction("Index");
            //res == 0 ?  View() : new JsonResult { }  ;
        }

        

        [ChildActionOnly]
        [HttpGet]
        public ActionResult _AccountDetails()
        {
            var accountBookDetails = _accService.AccountBookTurn();
            return PartialView(accountBookDetails);
        }

 

    }
}