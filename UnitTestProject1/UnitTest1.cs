using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using job11;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Math.Round(Math.Log10(2-1),4),
                Math.Round(job11.Program.Ln(Math.Log10(2-1))));
        }
    }
}
