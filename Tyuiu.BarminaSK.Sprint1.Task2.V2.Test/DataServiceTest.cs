using Tyuiu.BarminaSK.Sprint1.Task2.V2.Lib;

namespace Tyuiu.BarminaSK.Sprint1.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.ConvertAngleToRad(x);
            Assert.AreEqual(0.017, res, 0.0001);
        }
    }
}
