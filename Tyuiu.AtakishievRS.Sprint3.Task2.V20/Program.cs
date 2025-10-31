using Tyuiu.AtakishievRS.Sprint3.Task2.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Атакишиев Р.С. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #20                                                             *");
        Console.WriteLine("* Выполнил: Атакишиев Р. С. | РППб-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл do...while,                           *");
        Console.WriteLine("* которая вычисляет произведение ряда по формуле, при х=1                 *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        int x = 1;
        int startV = 1;
        int stopV = 6;


        Console.WriteLine("Переменная X: " + x);
        Console.WriteLine("Старт шага Y: " + startV);
        Console.WriteLine("Конец шага Y: " + stopV);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(x, startV, stopV));

        Console.ReadKey();
    }
}
