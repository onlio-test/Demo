
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Onlio.Demo.BankAccount;


namespace ConsoleClientTest
{
    
    /// <summary>
    ///This is a test class for ProgramTest and is intended
    ///to contain all ProgramTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProgramTest
    {

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetBankAccount
        ///</summary>
        [TestMethod()]
        public void GetBankAccountTest()
        {
            string customerName = "UnitTest01";
            double balance = 0.0;
            var expected = new BankAccount(customerName, balance);

            var actual = Program.GetBankAccount(customerName);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.CustomerName, actual.CustomerName, true);
            Assert.AreEqual(expected.Balance, actual.Balance);
        }

        /// <summary>
        ///A test for TransferMoney
        ///</summary>
        [TestMethod()]
        public void TransferMoneyTest()
        {
            var debitAccount = Program.GetBankAccount("UnitTest01");
            var creditAccount = Program.GetBankAccount("UnitTest02");
            double amount = 0.99;

            try
            {
                Program.TransferMoney(debitAccount, creditAccount, amount);
            }
            catch (ArgumentException) { }
            catch (Exception ex)
            {
                Assert.Fail("Unexpected exception type " + ex.GetType().Name);
            }

            debitAccount.Credit(amount);
            Program.TransferMoney(debitAccount, creditAccount, amount);
            Assert.AreEqual(debitAccount.Balance, 0.0);
            Assert.AreEqual(creditAccount.Balance, amount);
        }

    }
}
