using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_SKA.Models.ViewModels;

namespace MVC_SKA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var accountOrderViewModelList = new List<AccountOrderViewModel>();

            for (var i = 1; i <= 50; i++)
            {
                accountOrderViewModelList.Add(new AccountOrderViewModel()
                {
                    Id = i,
                    AccountType = new Random(i).Next(1, 3) == 1 ? AccountType.Expenditure : AccountType.Income,
                    Date = new DateTime(2019, new Random(i).Next(1, 13), new Random(i).Next(1, 29)).ToShortDateString(),
                    Amount = new Random(i).Next(1, 5000)
                });
            }

            return View(accountOrderViewModelList);
        }
    }
}