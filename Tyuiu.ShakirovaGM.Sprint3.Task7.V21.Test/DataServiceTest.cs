using Tyuiu.ShakirovaGM.Sprint3.Task7.V21.Lib;
namespace Tyuiu.ShakirovaGM.Sprint3.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue-startValue +1;

            double[] wait;
            wait = new double[len];

            wait[0] = 28.05;
            wait[1] = 22.27;
            wait[2] = 17.01;
            wait[3] = 12.35;
            wait[4] = 7.51;
            wait[5] = 0.0;
            wait[6] = 1.62;
            wait[7] = -7.03;
            wait[8] =-12.99;
            wait[9] =-17.55;
            wait[10] =-21.43;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            
            CollectionAssert.AreEqual(wait, res);
        }
    }
}