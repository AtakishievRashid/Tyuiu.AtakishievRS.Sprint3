using Tyuiu.AtakishievRS.Sprint3.Task7.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Атакишиев Р.С. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #20                                                             *");
        Console.WriteLine("* Выполнил: Атакишиев Р. С. | РППб-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая выводит таблицу значения функции:           *");
        Console.WriteLine("* Значения занести в массив                                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);
        int len = ds.GetMassFunction(startValue, stopValue).Length;
        double[] valueArray;
        valueArray = new double[len];
        valueArray = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(" +-----------+-----------+");
        Console.WriteLine(" |     X     |    F(x)   |");
        Console.WriteLine(" +-----------+-----------+");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine(" |{0,5:d}       |  {1, 5:f2}   |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine(" +-----------+-----------+");
        Console.ReadKey();
    }
}