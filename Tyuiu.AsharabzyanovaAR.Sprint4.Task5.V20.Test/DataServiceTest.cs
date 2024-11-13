using Tyuiu.AsharabzyanovaAR.Sprint4.Task5.V20.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint4.Task5.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5] {{-4, -5, -5, -6, -4},

                                     { -7, -8, -4, -7,- 5},

                                     {-5, -6, -5, -8, -5},

                                     { -7, -5, -8, -7, -8},

                                     { -4, -7, -7, 8, 8} };
            int res = ds.Calculate(mas);
            int wait = 16;
            Assert.AreEqual(wait,res);
        }
    }
}
