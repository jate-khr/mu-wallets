using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mu_wallet_api.Models
{
    public class Account
    {
        [Key]
        public string accountNo { get; set; }
        public int amount { get; set; }
        public string name { get; set; }
        public ICollection<transactionLog> transactions { get; set; }


    }
}