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
        public List<MoneyViewModel> AccountBookTurn()
        {
            List<MoneyViewModel> accoutDetails = new List<MoneyViewModel>();
            AccountEFRepository repo = new AccountEFRepository();
            List<AccountBook> accountBooks = repo.GetAll();
            int i = 1;
            foreach (var details in accountBooks)
            {
                MoneyViewModel aDetail = new MoneyViewModel
                {
                    No = i,
                    Type = details.Categoryyy % 2 == 0 ? "收入" : "支出",
                    Datetime = details.Dateee,
                    Amount = details.Amounttt
                };
                accoutDetails.Add(aDetail);
                i++;
            }
            return accoutDetails;
        }


    }
}
