using Tyuiu.AtakishievRS.Sprint3.Task1.V16.Lib;
namespace Tyuiu.AtakishievRS.Sprint3.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 0.7;
            int Start = 1;
            int End = 15;
            double wait = 15.948;

            double res = ds.GetSumSeries(x, Start, End);
            Assert.AreEqual(wait, res);
        }
    }
}
