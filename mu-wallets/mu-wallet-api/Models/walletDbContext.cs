using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mu_wallet_api.Models
{
    public class walletDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<transactionLog> transactions { get; set; }
        public walletDbContext():base("defaultConnection")
        {

        }
    }
}