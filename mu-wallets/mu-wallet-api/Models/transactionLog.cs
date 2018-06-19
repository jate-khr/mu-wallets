using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mu_wallet_api.Models
{
    public class transactionLog
    {
        public int id { get; set; }
        public string sourceAccount { get; set; }
        public string transferType { get; set; }
        public int amountTransfer { get; set; }
        public int preTransferAmount { get; set; }
        public string targetAccount  { get; set; }
        public DateTime actionDatetime { get; set; }
        public bool isSuccess { get; set; }
    }
}