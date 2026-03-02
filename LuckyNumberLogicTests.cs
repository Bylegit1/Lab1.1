using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._1.Tests
{
    [TestClass()]
    public class LuckyNumberLogicTests
    {
        [TestMethod()]
        public void IsNegativeTestPositiveNumber()
        {
            int number = 123456;
            bool result = LuckyNumberLogic.IsNegative(number);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsNegativeTestNegativeNumber()
        {
            int number = -123456;
            bool result = LuckyNumberLogic.IsNegative(number);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsNegativeTestZero()
        {
            int number = 0;
            bool result = LuckyNumberLogic.IsNegative(number);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsSixDigitTestSixDigitNumber()
        {
            int number = 123456;
            bool result = LuckyNumberLogic.IsSixDigit(number);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsSixDigitTestFiveDigitNumber()
        {
            int number = 12345;
            bool result = LuckyNumberLogic.IsSixDigit(number);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsSixDigitTestSevenDigitNumber()
        {
            int number = 1234567;
            bool result = LuckyNumberLogic.IsSixDigit(number);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsSixDigitTestBoundaryMin()
        {
            int number = 100000;
            bool result = LuckyNumberLogic.IsSixDigit(number);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsSixDigitTestBoundaryMax()
        {
            int number = 999999;
            bool result = LuckyNumberLogic.IsSixDigit(number);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CheckLuckyNumberTestLuckyNumber()
        {
            int number = 123123;
            string result = LuckyNumberLogic.CheckLuckyNumber(number);
            Assert.AreEqual("Число является счастливым", result);
        }

        [TestMethod()]
        public void CheckLuckyNumberTestNotLuckyNumber()
        {
            int number = 123456;
            string result = LuckyNumberLogic.CheckLuckyNumber(number);
            Assert.AreEqual("Число не является счастливым", result);
        }

        [TestMethod()]
        public void CheckLuckyNumberTestMaxLuckyNumber()
        {
            int number = 999999;
            string result = LuckyNumberLogic.CheckLuckyNumber(number);
            Assert.AreEqual("Число является счастливым", result);
        }
    }
}