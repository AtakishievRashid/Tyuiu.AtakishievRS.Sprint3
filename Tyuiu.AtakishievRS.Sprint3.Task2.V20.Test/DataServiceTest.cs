using Tyuiu.AtakishievRS.Sprint3.Task2.V20.Lib;
namespace Tyuiu.AtakishievRS.Sprint3.Task2.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 6;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 914700.940;
            Assert.AreEqual(wait, res);
        }
    }
}
