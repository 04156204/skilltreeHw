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
        public ActionResult Index(MoneyViewModel anAccount)
        {
            return View(anAccount);
        }

        [ChildActionOnly]
        [HttpGet]
        public ActionResult _AccountInput()
        {
            return View();
        }

        [HttpPost]
        public ActionResult _AccountInput(MoneyViewModel anAccount)
        {
            var res = new
            {
                Code = "",
                Message = "",
            };
            if (!ModelState.IsValid)
            {
                var errorMessage = ModelState.
                                    Values.
                                    SelectMany(v => v.Errors)
                                    .Select(e => e.ErrorMessage);
                res = new
                {
                    Code = "0001", 
                    Message = string.Join("，", errorMessage), 
                };

                return Json(res);
            }
            var retu = _accService.addAcc(anAccount);

            if (retu != 0)
            {
                res= new
                {
                    Code = "0000", 
                    Message = "",
                };
                return Json(res);
            }
            else {
                res = new
                {
                    Code = "0001",
                    Message = "後台新增失敗",
                };
                return Json(res);
            }

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