namespace mu_wallet_api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        accountNo = c.String(nullable: false, maxLength: 128),
                        amount = c.Int(nullable: false),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.accountNo);
            
            CreateTable(
                "dbo.transactionLogs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        sourceAccount = c.String(),
                        transferType = c.String(),
                        amountTransfer = c.Int(nullable: false),
                        preTransferAmount = c.Int(nullable: false),
                        targetAccount = c.String(),
                        actionDatetime = c.DateTime(nullable: false),
                        isSuccess = c.Boolean(nullable: false),
                        Account_accountNo = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Accounts", t => t.Account_accountNo)
                .Index(t => t.Account_accountNo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.transactionLogs", "Account_accountNo", "dbo.Accounts");
            DropIndex("dbo.transactionLogs", new[] { "Account_accountNo" });
            DropTable("dbo.transactionLogs");
            DropTable("dbo.Accounts");
        }
    }
}
