using Tyuiu.AtakishievRS.Sprint3.Task0.V25.Lib;
namespace Tyuiu.AtakishievRS.Sprint3.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 14;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 0.690;

            Assert.AreEqual(wait, res);
        }
    }
}
