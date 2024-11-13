using System.Globalization;
using Tyuiu.AsharabzyanovaAR.Sprint4.Task7.V2.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint4.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 3;
            int columns = 4;
            int[,] matrix = new int[rows, columns];
            string str = "597643158942";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 39;
            Assert.AreEqual(wait, res);

        }
    }
}
