using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sTreeHw0706.EFRepository
{
    public class AccountEFRepository
    {
        private SkillTreeHomeworkEntities _context;
        public AccountEFRepository() {
            _context = new SkillTreeHomeworkEntities();
        }

        /// <summary>
        /// 撈資料庫
        /// </summary>
        /// <returns></returns>
        public List<AccountBook> GetAll()
        {
            using (_context)
            {
                return _context.AccountBook.ToList();
            }
        }

        public int AddAccount(AccountBook anAccount)
        {
            int res = 0;
            using (_context)
            {
                _context.AccountBook.Add(anAccount);
                res = _context.SaveChanges();
            }
            return res;
        }





    }
}
