using Tyuiu.AtakishievRS.Sprint3.Task5.V26.Lib;
namespace Tyuiu.AtakishievRS.Sprint3.Task5.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 13;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            double wait = 8192.420;

            Assert.AreEqual(wait, res);
        }
    }
}
