using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShakirovaGM.Sprint3.Task0.V28.Lib
{
    public class DataService : ISprint3Task0V28
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                MultiplySeries *= ((Math.Pow(value,3)*i)+2);
            }
            return Math.Round(MultiplySeries,3);
        }
    }
}
