using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sTreeHw0706.EFRepository
{
    public class AccountEFRepository
    {
        /// <summary>
        /// 撈資料庫
        /// </summary>
        /// <returns></returns>
        public List<AccountBook> GetAll()
        {
            using (SkillTreeHomeworkEntities context = new SkillTreeHomeworkEntities())
            {
                return context.AccountBook.ToList();
            }
        }







    }
}
