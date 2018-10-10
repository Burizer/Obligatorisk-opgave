using System;
using Methods.cs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestConversion
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double ounce = 10;
            double expected = 283.4952;
            var ounceToGram = new Methods();
            double actual = ounceToGram.ToOunces(ounce);
            Assert.AreEqual(expected, actual);

        }
    }
}
