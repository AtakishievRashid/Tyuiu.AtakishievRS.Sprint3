using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AtakishievRS.Sprint3.Task5.V26.Lib
{
    public class DataService : ISprint3Task5V26
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            int i, j;
            for (i = stopValue1; i <= stopValue1; i++)
            {
                for (j = stopValue2; j <= stopValue2; j++)
                {
                    sumSeries = sumSeries + (Math.Pow(x, j) + Math.Sin(j));
                }
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
