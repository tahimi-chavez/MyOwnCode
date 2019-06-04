using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication3;

namespace CheckTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDeposit()
        {
            //Arrange
            var a1 = new Account();
            a1.Balance=500;
            decimal expected = 750;
            //Act
            a1.Deposit(250);
            //Assert
            Assert.IsTrue(expected == a1.Balance, "Balance is not correct");
        }
    }
}
