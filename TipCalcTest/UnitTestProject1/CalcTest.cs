using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TipCalcTest;

namespace TipUnitTest
{
    [TestClass]
    public class PriceTest
    {
        [DataRow(10.00, 15, 1.50)]
        [DataRow(15.00, 18, 2.70)]
        [DataRow(25.00, 22, 5.50)]

        [DataTestMethod]
        public void TestTip(double price, double qos, double tip)
        {
            Assert.AreEqual(Price.GetTip(price, qos), tip, 0.01);
        }

        [DataRow(20.00, 1.50, 21.50)]
        [DataRow(10.50, 3.00, 13.50)]
        [DataRow(2.00, 1.00, 3.00)]

        [DataTestMethod]
        public void TestTotal(double price, double tip, double total)
        {
            Assert.AreEqual(Price.GetTotalPrice(price, tip), total, 0.01);
        }
    }
}
