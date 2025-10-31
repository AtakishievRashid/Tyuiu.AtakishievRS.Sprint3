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

            double expected = 0;

            for (int i = 1; i <= 3; i++)
            {
                double innerSum = 0;
                for (int k = 1; k <= 13; k++)
                {
                    innerSum += Math.Pow(2, k) + Math.Sin(k);
                }
                expected += innerSum;
            }

            double actual = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}
