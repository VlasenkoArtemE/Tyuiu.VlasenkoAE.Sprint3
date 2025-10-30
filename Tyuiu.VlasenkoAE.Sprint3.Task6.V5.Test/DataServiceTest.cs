using Tyuiu.VlasenkoAE.Sprint3.Task6.V5.Lib;

namespace Tyuiu.VlasenkoAE.Sprint3.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue = 15;
            int stopValue = 22;

            double res = ds.GetSumTheDivisors(startValue, stopValue);

            double wait = 242;

            Assert.AreEqual(wait, res);
        }
    }
}
