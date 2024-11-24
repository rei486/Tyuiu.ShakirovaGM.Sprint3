using Tyuiu.ShakirovaGM.Sprint3.Task0.V28.Lib;
namespace Tyuiu.ShakirovaGM.Sprint3.Task0.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Шакирова Г. М. | РППб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Шакирова Гузель Мансуровна | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение   *");
            Console.WriteLine("* ряда по формуле, при X=0,25                                             *");
          
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");



           
            double x = 0.25;
            
            int startV = 1;

            int stopV = 17;


            Console.WriteLine("Переменная X: " + x);
            Console.WriteLine("Старт шага Y: " + startV);
            Console.WriteLine("Конец шага Y: " + stopV);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(x,startV,stopV));

            Console.ReadLine();
        }
    }
}
