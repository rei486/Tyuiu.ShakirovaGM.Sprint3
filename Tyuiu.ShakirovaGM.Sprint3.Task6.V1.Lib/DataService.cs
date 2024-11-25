using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShakirovaGM.Sprint3.Task6.V1.Lib
{
    public class DataService : ISprint3Task6V1
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int i;
            int sum = 0;
            for (i = startValue; i <= stopValue; i++)
            {
                for (int d=1; d<=i; d++)
                {
                    if (i%d == 0)
                    {
                        sum += d;
                    }
                }
            }
            return sum;
        }
    }
}
