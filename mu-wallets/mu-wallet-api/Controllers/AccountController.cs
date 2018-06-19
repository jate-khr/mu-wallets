using mu_wallet_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mu_wallet_api.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult GetBalance(string accountNo)
        {
            walletDbContext database = new walletDbContext();

            return Json(database.Accounts.Find(accountNo), JsonRequestBehavior.AllowGet);
        }
    }
}