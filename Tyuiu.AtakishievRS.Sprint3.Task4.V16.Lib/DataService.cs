using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AtakishievRS.Sprint3.Task4.V16.Lib
{
    public class DataService : ISprint3Task4V16
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1.0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0) continue;
                res *= ((Math.Cos(i) + i) / i) + 0.25;
            }
            return Math.Round(res, 3);
        }

    }
}
