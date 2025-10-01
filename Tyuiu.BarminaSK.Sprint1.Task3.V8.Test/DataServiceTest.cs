using Tyuiu.BarminaSK.Sprint1.Task3.V8.Lib;

namespace Tyuiu.BarminaSK.Sprint1.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double startAmount = 2500.0;
            double percent = 20.0;
            double timeDays = 30.0;
            double wait = 41.096;
            var res = ds.IncomeAmount(startAmount, percent, timeDays);
            Assert.AreEqual(wait, res,0.001);
        }
    }
}
