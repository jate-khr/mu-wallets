using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mu_wallet_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void transfer_total_amount_under_5000()
        {
            //arrange
            int amount_transfer = 2000;
            int amount_balance = 1000;
            Transfer transfer_obj = new Transfer();
            bool expect_value = true;
            //action
            bool actual_value = transfer_obj.canTransfer(amount_transfer, amount_balance);

            //assert

            Assert.AreEqual(expect_value, actual_value);
        }
        [TestMethod]
        public void transfer_total_amount_equal_5000()
        {
            //arrange
            int amount_transfer = 3000;
            int amount_balance = 2000;
            Transfer transfer_obj = new Transfer();
            bool expect_value = true;
            //action
            bool actual_value = transfer_obj.canTransfer(amount_transfer, amount_balance);

            //assert

            Assert.AreEqual(expect_value, actual_value);
        }
    }
}
