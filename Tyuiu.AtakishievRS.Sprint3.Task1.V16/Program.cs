using Tyuiu.AtakishievRS.Sprint3.Task1.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        
        DataService ds = new DataService(); 

        Console.Title = "Спринт #3 | Выполнил: Атакишиев Р.С. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла While                                              *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #16                                                             *");
        Console.WriteLine("* Выполнил: Атакишиев Р. С. | РППб-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл while,                                *");
        Console.WriteLine("* которая вычисляет сумму ряда по формуле, при х=0,7                      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        double x = 0.7;
        int start = 1;
        int stop = 15;

        Console.WriteLine("* Переменная X = " + x);
        Console.WriteLine("* Старт шага = " + start);
        Console.WriteLine("* Конец шага = " + stop);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = ds.GetSumSeries(x, start, stop);
        Console.WriteLine(res);

        Console.ReadKey();
    }
}