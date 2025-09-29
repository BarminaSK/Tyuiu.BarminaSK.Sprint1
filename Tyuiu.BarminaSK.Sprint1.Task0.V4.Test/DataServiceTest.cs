namespace Tyuiu.BarminaSK.Sprint1.Task0.V4.Test;

using Microsoft.ApplicationInsights.DataContracts;
using Tyuiu.BarminaSK.Sprint1.Task0.V4.Lib;


{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(6, res);
        }
    }
}
