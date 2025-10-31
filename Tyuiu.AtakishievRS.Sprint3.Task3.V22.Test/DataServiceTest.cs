using Tyuiu.AtakishievRS.Sprint3.Task3.V22.Lib;
namespace Tyuiu.AtakishievRS.Sprint3.Task3.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string testString = "";
            char targetChar = 'b';
            int expected = 0;

            int actual = ds.GetMaxCharCount(testString, targetChar);

            Assert.AreEqual(expected, actual);
        }
    }
}
