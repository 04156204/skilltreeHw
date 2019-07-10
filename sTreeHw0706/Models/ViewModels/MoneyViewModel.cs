using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sTreeHw0706.Models.ViewModels
{
    public class MoneyViewModel
    {
        public int No { get; set; }
        public string Type { get; set; }
        public DateTime? Datetime { get; set; }
        public int Amount { get; set; }
        public string Note { get; set; }
    }
}