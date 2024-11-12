using Tyuiu.AsharabzyanovaAR.Sprint4.Task2.V11.Lib;

namespace Tyuiu.AsharabzyanovaAR.Sprint4.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            int res = ds.Calculate(numsArray);
            int wait = 38;
            Assert.AreEqual(wait, res);
        }
    }
}
