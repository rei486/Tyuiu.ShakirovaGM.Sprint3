using Tyuiu.ShakirovaGM.Sprint3.Task4.V18.Lib;
namespace Tyuiu.ShakirovaGM.Sprint3.Task4.V18
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
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Шакирова Гузель Мансуровна | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке,где x принимает значения от-5 до 5,вычислить значение функции*");
            Console.WriteLine("* y=sin(x)/cos(x) При х = 0 прервать цикл. Полученные значения суммировать*");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startV = -5;
            int stopV = 5;

            Console.WriteLine("Старт шага = : " + startV);
            Console.WriteLine("Конец шага = : " + stopV);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.Calculate( startV, stopV));

            Console.ReadLine();
        }
    }
}
