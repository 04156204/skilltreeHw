using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sTreeHw0706.EFRepository;
using sTreeHw0706.Models.ViewModels;

namespace sTreeHw0706.Business
{
    public class AccountService
    {
        private AccountEFRepository _accRepo;
        public AccountService()
        {
            _accRepo = new AccountEFRepository();

        }


        /// <summary>
        /// 從資料庫拿出資料，並轉成ViewModel所需格式
        /// </summary>
        /// <returns></returns>
        public List<MoneyViewModel> AccountBookTurn()
        {
            List<MoneyViewModel> accoutDetails = new List<MoneyViewModel>();
            //AccountEFRepository repo = new AccountEFRepository();
            List<AccountBook> accountBooks = _accRepo.GetAll();
            int i = 1;
            foreach (var details in accountBooks)
            {
                MoneyViewModel aDetail = new MoneyViewModel
                {
                    No = i,
                    Type = details.Categoryyy % 2 == 0 ? "收入" : "支出",
                    //其實不知道 demo提供的Categoryyy哪個數字代表什麼
                    Datetime = details.Dateee,
                    Amount = details.Amounttt,
                    Note =details.Remarkkk
                };
                accoutDetails.Add(aDetail);
                i++;
            }
            return accoutDetails;
        }

        public int addAcc(MoneyViewModel anAccount)
        {
            AccountBook accountBook = new AccountBook();
            // 產流水號 
            accountBook.Id = Guid.NewGuid();
            accountBook.Categoryyy = int.Parse(anAccount.Type);
            accountBook.Dateee = anAccount.Datetime ?? DateTime.Now;
            accountBook.Amounttt = anAccount.Amount;
            accountBook.Remarkkk = anAccount.Note;

            var repo = _accRepo.AddAccount(accountBook);
            return repo ;          
        }





    }
}
