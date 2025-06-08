using Tyuiu.AntonovVV.Sprint5.Task6.V29.Lib;
namespace Tyuiu.AntonovVV.Sprint5.Task6.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\avv\source\repos\Tyuiu.AntonovVV.Sprint5\DataSprint5\InPutDataFileTask6V29.txt";
            var res = ds.LoadFromDataFile(path);
            int z = 3;
            Assert.AreEqual(z, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string path = @"C:\Users\avv\source\repos\Tyuiu.AntonovVV.Sprint5\DataSprint5\InPutDataFileTask6V29.txt";
            FileInfo FI = new FileInfo(path);
            bool fx = FI.Exists;
            bool z = true;
            Assert.AreEqual(z, fx);
        }
    }
}