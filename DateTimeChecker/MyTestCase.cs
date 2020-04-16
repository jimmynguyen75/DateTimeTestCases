using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CheckDayMonthYear;

namespace DateTimeChecker
{
    [TestFixture]

    class CheckNull
    {
        Check check = new Check();
        [TestCase]
        public void checkDayNull()
        {
            Assert.IsFalse(check.checkDayFormat(""));
        }
        [TestCase]
        public void checkMonthNull()
        {
            Assert.IsFalse(check.checkMonthFormat(""));
        }
        [TestCase]
        public void checkYearNull()
        {
            Assert.IsFalse(check.checkYearFormat(""));
        }
    }

    class CheckDay
    {
        Check check = new Check();
        [TestCase]
        public void checkDayUnderZero()
        {
            Assert.IsFalse(check.checkRangeOfDay(0));
        }
        [TestCase]
        public void checkDayGreaterThan31()
        {
            Assert.IsFalse(check.checkRangeOfDay(32));
        }
        [TestCase]
        public void checkDayInputString()
        {
            Assert.IsFalse(check.checkDayFormat("aa"));
        }
        [TestCase]
        public void checkDayInputRange1()
        {
            Assert.IsTrue(check.checkRangeOfDay(1));
        }
        [TestCase]
        public void checkDayInputRange2()
        {
            Assert.IsTrue(check.checkRangeOfDay(31));
        }
    }

    class CheckMonth    
    {
        Check check = new Check();
        [TestCase]
        public void checkMonthUnderZero()
        {
            Assert.IsFalse(check.checkRangeOfMonth(0));
        }
        [TestCase]
        public void checkMonthGreaterThan31()
        {
            Assert.IsFalse(check.checkRangeOfMonth(13));
        }
        [TestCase]
        public void checkMonthInputString()
        {
            Assert.IsFalse(check.checkMonthFormat("aa"));
        }
        [TestCase]
        public void checkMonthInputRange1()
        {
            Assert.IsTrue(check.checkRangeOfMonth(1));
        }
        [TestCase]
        public void checkMonthInputRange2()
        {
            Assert.IsTrue(check.checkRangeOfMonth(12));
        }
    }
    
    class CheckYear
    {
        Check check = new Check();
        [TestCase]
        public void checkYearUnder1000()
        {
            Assert.IsFalse(check.checkRangeOfYear(999));
        }
        [TestCase]
        public void checkYearGreaterThan3001()
        {
            Assert.IsFalse(check.checkRangeOfYear(3001));
        }
        [TestCase]
        public void checkYearInputString()
        {
            Assert.IsFalse(check.checkYearFormat("aa"));
        }
        [TestCase]
        public void checkYearInputRange1()
        {
            Assert.IsTrue(check.checkRangeOfYear(1001));
        }
        [TestCase]
        public void checkYearInputRange2()
        {
            Assert.IsTrue(check.checkRangeOfYear(2999));
        }
    }

    class CheckDayInMonth
    {
        Check check = new Check();
        [TestCase]
        public void checkDayInMonth1()
        {
            Assert.AreEqual(31, check.findDayInMonth(1, 2019));
        }
        [TestCase]
        public void checkDayInMonth2()
        {
            Assert.AreEqual(28, check.findDayInMonth(2, 2019));
        }
        [TestCase]
        public void checkDayInMonth3()
        {
            Assert.AreEqual(31, check.findDayInMonth(3, 2019));
        }
        [TestCase]
        public void checkDayInMonth4()
        {
            Assert.AreNotEqual(31, check.findDayInMonth(4, 2019));
        }
        [TestCase]
        public void checkDayInMonth5()
        {
            Assert.AreEqual(31, check.findDayInMonth(5, 2019));
        }
        [TestCase]
        public void checkDayInMonth6()
        {
            Assert.AreEqual(30, check.findDayInMonth(6, 2019));
        }
        [TestCase]
        public void checkDayInMonth7()
        {
            Assert.AreEqual(31, check.findDayInMonth(7, 2019));
        }
        [TestCase]
        public void checkDayInMonth8()
        {
            Assert.AreNotEqual(32, check.findDayInMonth(8, 2019));
        }
        [TestCase]
        public void checkDayInMonth9()
        {
            Assert.AreEqual(30, check.findDayInMonth(9, 2019));
        }
        [TestCase]
        public void checkDayInMonth10()
        {
            Assert.AreEqual(31, check.findDayInMonth(10, 2019));
        }
        [TestCase]
        public void checkDayInMonth11()
        {
            Assert.AreEqual(30, check.findDayInMonth(11, 2019));
        }
        [TestCase]
        public void checkDayInMonth12()
        {
            Assert.AreEqual(31, check.findDayInMonth(12, 2019));
        }
        [TestCase]
        public void checkDayInMonthOfLeapYear()
        {
            Assert.AreEqual(29, check.findDayInMonth(2, 2020));
        }
    }

    class CheckDate
    {
        Check check = new Check();

        [TestCase]
        public void checkDayInMonth1()
        {
            Assert.IsTrue(check.isValidDate(31, 1, 2019));
        }
        [TestCase]
        public void checkDayInMonth2()
        {
            Assert.IsFalse(check.isValidDate(31, 2, 2019));
        }
        [TestCase]
        public void checkDayInMonth22()
        {
            Assert.IsFalse(check.isValidDate(31, 2, 2019));
        }
        [TestCase]
        public void checkDayInMonhth2OfLeapYear()
        {
            Assert.IsTrue(check.isValidDate(29, 2, 2020));
        }
        [TestCase]
        public void checkDayInMonhth5()
        {
            Assert.IsTrue(check.isValidDate(31, 5, 2019));
        }
        [TestCase]
        public void checkDayInMonth3()
        {
            Assert.IsTrue(check.isValidDate(31, 3, 2019));
        }
        [TestCase]
        public void checkDayInMonhth7()
        {
            Assert.IsTrue(check.isValidDate(31, 07, 2019));
        }
        [TestCase]
        public void checkDayInMonth10()
        {
            Assert.IsTrue(check.isValidDate(31, 10, 2019));
        }
        [TestCase]
        public void checkDayInMonth9()
        {
            Assert.IsFalse(check.isValidDate(31, 09, 2019));
        }
        [TestCase]
        public void checkDayInMonth12()
        {
            Assert.IsTrue(check.isValidDate(31, 12, 2019));
        }
    }
}
