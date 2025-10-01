using Tyuiu.BarminaSK.Sprint1.Task4.V21.Lib;

namespace Tyuiu.BarminaSK.Sprint1.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 0.667;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(wait, res);
        }
    }
}
