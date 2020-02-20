using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Double x1 = 0;
            Double x2 = 0;
            Double x3 = 0;
            Double y1 = 0;
            Double y2 = 3;
            Double y3 = 4;

            Double result1 = ConsoleApp1.Program.perim(x1, x2, x3, y1, y2, y3);
            Double result2 = ConsoleApp1.Program.Square(x1, x2, x3, y1, y2, y3);

            Assert.AreEqual(12, result1);
            Assert.AreEqual(6, result2);
        }
    }
}
