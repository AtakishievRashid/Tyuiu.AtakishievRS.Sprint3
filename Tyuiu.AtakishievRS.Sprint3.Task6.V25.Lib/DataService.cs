using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AtakishievRS.Sprint3.Task6.V25.Lib
{
    public class DataService : ISprint3Task6V25
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        if (d < 10)
                            sum += d;
                    }
                }
            }
            return (sum);
        }
    }
}
