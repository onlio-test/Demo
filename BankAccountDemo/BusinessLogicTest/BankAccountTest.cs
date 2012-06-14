
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Onlio.Demo.BankAccount;


namespace BusinessLogicTest
{

    /// <summary>
    ///This is a test class for BankAccountTest and is intended
    ///to contain all BankAccountTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BankAccountTest
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
        ///A test for BankAccount Constructor
        ///</summary>
        [TestMethod()]
        public void BankAccountConstructorTest()
        {
            string customerName = "UnitTest01";
            double balance = 0.99;
            var target = new BankAccount(customerName, balance);
            
            Assert.IsNotNull(target);
            Assert.AreEqual(target.CustomerName, customerName, true);
            Assert.AreEqual(target.Balance, balance);
        }

        /// <summary>
        ///A test for Credit
        ///</summary>
        [TestMethod()]
        public void CreditTest()
        {
            string customerName = "UnitTest01";
            double balance = 0.99;
            var target = new BankAccount(customerName, balance);

            double amount = -1.0;
            try
            {
                target.Credit(amount);
            }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception ex)
            {
                Assert.Fail("Unexpected exception type " + ex.GetType().Name);
            }

            amount = 1.0;
            target.Credit(amount);
            Assert.AreEqual(target.Balance, balance + amount);
        }

        /// <summary>
        ///A test for Debit
        ///</summary>
        [TestMethod()]
        public void DebitTest()
        {
            string customerName = "UnitTest01";
            double balance = 0.99;
            var target = new BankAccount(customerName, balance);

            double amount = -1.0;
            try
            {
                target.Debit(amount);
            }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception ex)
            {
                Assert.Fail("Unexpected exception type " + ex.GetType().Name);
            }

            amount = 1.0;
            try
            {
                target.Debit(amount);
            }
            catch (ArgumentOutOfRangeException) { }
            catch (Exception ex)
            {
                Assert.Fail("Unexpected exception type " + ex.GetType().Name);
            }

            amount = balance;
            target.Debit(amount);
            Assert.AreEqual(target.Balance, balance - amount);
        }

    }
}
