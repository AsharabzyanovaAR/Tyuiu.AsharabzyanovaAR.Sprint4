using Tyuiu.AsharabzyanovaAR.Sprint4.Task6.V21.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint4.Task6.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var v = new string[] { "Facebook", "Twitter", "Instagram", "Snapchat", "LinkedIn", "Pinterest", "Reddit" };
            int res = ds.Calculate(v);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
