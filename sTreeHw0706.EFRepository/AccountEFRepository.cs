using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sTreeHw0706.EFRepository
{
    public class AccountEFRepository
    {
        public List<AccountBook> GetAll()
        {
            using (SkillTreeHomeworkEntities context = new SkillTreeHomeworkEntities())
            {
                return context.AccountBook.ToList();
            }
        }







    }
}
