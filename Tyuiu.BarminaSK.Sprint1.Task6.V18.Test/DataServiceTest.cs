using Tyuiu.BarminaSK.Sprint1.Task6.V18.Lib;

namespace Tyuiu.BarminaSK.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckNumber()
        {
            DataService ds = new DataService();
            string str = "122";
            bool wait = true;

            bool res = ds.CheckNumber(str);

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void InvalidCheck0()
        {
            DataService ds = new DataService();
            string str = "0";
            bool wait = false;

            bool res = ds.CheckNumber(str);

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void InvalidCheckNegative()
        {

            DataService ds = new DataService();
            string str = "-12";
            bool wait = false;

            bool res = ds.CheckNumber(str);

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void InvalidCheckAnother()
        {

            DataService ds = new DataService();
            string str = "3.14";
            bool wait = false;

            bool res = ds.CheckNumber(str);

            Assert.AreEqual(wait, res);
        }
    }
}
