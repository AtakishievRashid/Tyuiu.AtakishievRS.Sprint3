using Tyuiu.AtakishievRS.Sprint3.Task4.V16.Lib;
namespace Tyuiu.AtakishievRS.Sprint3.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int startValue = -5;
            int stopValue = 5;
            Assert.AreEqual(6.719, dataService.Calculate(startValue, stopValue)); ;
        }
    }
}
