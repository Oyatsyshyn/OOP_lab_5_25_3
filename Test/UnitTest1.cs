using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0.5, new OOP_lab_5_25_3.Calls("+380987654321", "Київстар", DateTime.Now, 50, 25).MinuteValue());
        }
    }
}
