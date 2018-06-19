using mu_wallet_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mu_wallet_api.Services;

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
        [HttpPost]
        public ActionResult Transfer(string accountNo, string accountReceive, int amount)
        {
            walletDbContext database = new walletDbContext();
            Account account = database.Accounts.Find(accountNo);
            Account Receive = database.Accounts.Find(accountReceive);
            Transfer transfer = new Transfer();
            if(transfer.canTransfer(amount, Receive.amount))
            {
                account.transactions.Add(new transactionLog
                {
                    transferType = "out",
                    preTransferAmount = account.amount,
                    amountTransfer = amount,
                    actionDatetime = DateTime.Now,
                    isSuccess = true,
                    targetAccount = Receive.accountNo,
                    sourceAccount = account.accountNo
                });
                account.amount -= amount;
                Receive.transactions.Add(new transactionLog
                {
                    transferType = "in",
                    preTransferAmount = Receive.amount,
                    amountTransfer = amount,
                    actionDatetime = DateTime.Now,
                    isSuccess = true,
                    targetAccount = account.accountNo,
                    sourceAccount = Receive.accountNo
                });
                Receive.amount += amount;

                database.SaveChanges();
                return Json(new
                {
                    sourceAccount = account,
                    receiveAccount = Receive,
                    amount = amount
                });
            }
            return null;
        }
    


    }
}