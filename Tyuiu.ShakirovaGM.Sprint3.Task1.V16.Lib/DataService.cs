﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShakirovaGM.Sprint3.Task1.V16.Lib
{
    public class DataService : ISprint3Task1V16
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            
           while (startValue<=stopValue) 
            {
                sum += ((Math.Pow(value, 2) * Math.Sin(startValue)) + 1);
                startValue++;
            }
            return Math.Round(sum, 3);
        }
    }
}
