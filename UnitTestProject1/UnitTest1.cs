using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1: Form
    {
        [TestMethod]
        public void TestMethod1()
        {
            //assign
            var yearly = 85000M;
            var percentIncreaseAmount = 3M;

            var _app = new App();
            //act
            var monthly1 = _app.CalculateMonthlyWeeklyHourly("monthly", percentIncreaseAmount, yearly);
            var biweekly1 = _app.CalculateMonthlyWeeklyHourly("biweekly", percentIncreaseAmount, yearly);
            var hourlyly1 = _app.CalculateMonthlyWeeklyHourly("hourly", percentIncreaseAmount, yearly);

            var expectedMonthly = String.Format("{0:C}", 7083.33M);
            var expectedBiWeekly = String.Format("{0:C}", 3269.23M);
            var expectedHourly = String.Format("{0:C}", 40.87);

            //assert
            Equals(monthly1, expectedMonthly);
            Equals(biweekly1, expectedBiWeekly);
            Equals(hourlyly1, expectedHourly);
        }
    }
}
