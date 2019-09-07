using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_SKA.Models.Enum;

namespace MVC_SKA.Models.ViewModels
{
    public class AccountOrderViewModel
    {
        public int Id { get; set; }
        public string AccountType { get; set; }
        public string Date { get; set; }
        public int Amount { get; set; }
    }
}