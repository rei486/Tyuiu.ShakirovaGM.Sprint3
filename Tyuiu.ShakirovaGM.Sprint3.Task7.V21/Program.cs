using Tyuiu.ShakirovaGM.Sprint3.Task7.V21.Lib;
namespace Tyuiu.ShakirovaGM.Sprint3.Task7.V21
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
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Шакирова Гузель Мансуровна | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x)=(2cos(x)+2)/(2x-1) + cos(x) - 5x + 3                               *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1.*");
            Console.WriteLine("* Произвести проверку деления на 0.При делении на 0 вернуть значение 0.   *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;


            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |    f(x)  |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= len-1;i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1, 5:f2}   |", startValue, res[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadLine();
        }
    }
}
