using Tyuiu.AtakishievRS.Sprint3.Task6.V25.Lib;
namespace Tyuiu.AtakishievRS.Sprint3.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 16;
            int stopValue = 24;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 89;
            Assert.AreEqual(res, wait);
        }
    }
}
