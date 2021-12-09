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
            var math = new GitUnitTestDemo.Math(5, 2);
            var math2 = new GitUnitTestDemo.Math(1234, 0);
            var math3 = new GitUnitTestDemo.Math();

            Assert.AreEqual(7, math.Add());
            Assert.AreEqual(3, math.Subtract());
            Assert.AreEqual(10, math.Multiply());
            Assert.AreEqual(2.5, math.Divide());

            Assert.IsTrue(math.Divide() > 2.49 && math.Divide() < 2.51);
            Assert.AreEqual(Single.PositiveInfinity, math2.Divide());

            Assert.AreEqual(10, math2.SumDigits());
            Assert.AreEqual("101", math.Binary());

            Assert.IsTrue(math.a == 5 && math.b == 2);
            Assert.IsTrue(math3.a == 1 && math3.b == 1);

        }
    }
}
