using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mu_wallet_api.Services
{
    public class Transfer
    {

        public bool canTransfer(int amount_transfer,int amount_balance)
        {
            int sum = amount_transfer + amount_balance;
            if (sum <= 5000)
            {
                return true;
            }
            return false;
        }

    }
}