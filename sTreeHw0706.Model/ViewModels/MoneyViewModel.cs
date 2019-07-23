using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace sTreeHw0706.Models.ViewModels
{
    public class MoneyViewModel
    {
        public int No { get; set; }
        [Required(ErrorMessage ="類型──")]
        public string Type { get; set; }
        [Required(ErrorMessage = "日期──")]
        public DateTime? Datetime { get; set; }
        [Required(ErrorMessage = "金額──")]
        public int Amount { get; set; }
        [Required(ErrorMessage = "備註")]
        public string Note { get; set; }
    }
}