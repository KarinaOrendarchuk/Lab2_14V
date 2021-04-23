using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLab2_3A
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 2, 2, 3, -100, 5, 6 };

            long res1 = Lab2_3A.Program.DobElem(arr);
            long res2 = Lab2_3A.Program.SummToMaxModule(arr);
            Assert.AreEqual(-1200, res1);

            Assert.AreEqual(7, res2);
        }
    }
}
