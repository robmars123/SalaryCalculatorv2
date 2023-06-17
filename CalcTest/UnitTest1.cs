using SalaryCalculator;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace CalcTest
{
    [TestFixture]
    public class Tests : Form
    {
        private App _app;
        [SetUp]
        public void Setup()
        {
            _app = new App();
        }

        [Test]
        public void Test1()
        {
            //assign
            var yearly = 85000M;
            var percentIncreaseAmount = 3M;
            //act
            var monthly1 = _app.CalculateMonthlyWeeklyHourly("monthly", percentIncreaseAmount, yearly);
            var biweekly1 = _app.CalculateMonthlyWeeklyHourly("biweekly", percentIncreaseAmount, yearly);
            var hourlyly1 = _app.CalculateMonthlyWeeklyHourly("hourly", percentIncreaseAmount, yearly);

            var expectedMonthly = 7083.33M;
            var expectedBiWeekly = 3269.23M;
            var expectedHourly = 40.87;

            //assert
            Assert.Equals(monthly1, expectedMonthly);
            Assert.Equals(biweekly1, expectedBiWeekly);
            Assert.Equals(hourlyly1, expectedHourly);
        }
    }
}