using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShakirovaGM.Sprint3.Task7.V21.Lib
{
    public class DataService : ISprint3Task7V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res;
            int len = stopValue - startValue + 1;
            res = new double[len];
            double y;
            int k = 0;
            for (int x=startValue; x<=stopValue; x++)
            {
                if (2 * x - 1 == 0)
                {
                    res[k] = 0;
                }
                else
                {
                    y = Math.Round((((2 * Math.Cos(x) + 2) / 2 * x - 1) + Math.Cos(x) - 5 * x + 3), 2);
                    res[k] = y;
                    k++;
                }
            }
            return res;
        }
    }
}
