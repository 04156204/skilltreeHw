using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using sTreeHw0706.Helper;

namespace sTreeHw0706.Models.ViewModels
{public enum TypeEnum
    {
        收入,
        支出
    }
    public class MoneyViewModel
    {
        public int No { get; set; }
        [Required(ErrorMessage ="請填類型")]
        public string Type { get; set; }
        [Required(ErrorMessage = "請填日期")]
        [DateLessThanToday(ErrorMessage ="日期不可大於今天")]
        public DateTime? Datetime { get; set; }
        [Required(ErrorMessage = "請填金額")]
        [Range(1,10000000,ErrorMessage ="金額必須是正數")]
        public int Amount { get; set; }
        [Required(ErrorMessage = "請填備註")]
        [StringLength(100,ErrorMessage ="字數不可超過100")]
        public string Note { get; set; }
    }
}