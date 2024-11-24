using Tyuiu.ShakirovaGM.Sprint3.Task1.V16.Lib;
namespace Tyuiu.ShakirovaGM.Sprint3.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 1;
            int startValue = 1;
            int stopValue = 15;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 16.936;
            Assert.AreEqual(wait, res);
        }
    }
}