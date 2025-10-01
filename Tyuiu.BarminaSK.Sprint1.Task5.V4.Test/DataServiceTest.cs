using Tyuiu.BarminaSK.Sprint1.Task5.V4.Lib;

namespace Tyuiu.BarminaSK.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int time = 13257;
            int wait = 3;
            var res = ds.SecondsToHours(time);
            Assert.AreEqual(wait, res); 

        }
    }
}
