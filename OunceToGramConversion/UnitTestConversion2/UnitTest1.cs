using Microsoft.VisualStudio.TestTools.UnitTesting;
using OunceToGramConversion;

namespace UnitTestConversion
{
    [TestClass]
    public class UnitTest1
    {
        double factor = 28.34952;
        [TestMethod]
        //Test med heltal
        public void OuncesToGramsTest1()
        {
            double ounce = 10;
            double expected = factor * ounce;
            var ouncesToGram = new Methods();
            double actual = ouncesToGram.ToGrams(ounce);
            Assert.AreEqual(expected, actual,0.00000001);
        }
        [TestMethod]
        //Test med decimal tal
        public void OuncesToGramsTest2()
        {
            double ounce = 7.9;
            double expected = factor * ounce;
            var ouncesToGram = new Methods();
            double actual = ouncesToGram.ToGrams(ounce);
            Assert.AreEqual(expected, actual, 0.0000001);
        }
        [TestMethod]
        //Test med heltal
        public void GramsToOuncesTest1()
        {
            double grams = 100;
            double expected = grams / factor;
            var gramToOunces = new Methods();
            double actual = gramToOunces.ToOunces(grams);
            Assert.AreEqual(expected, actual,0.00000001);
        }
        [TestMethod]
        //Test med decimal tal
        public void GramsToOuncesTest2()
        {
            double grams = 55.9;
            double expected = grams / factor;
            var gramToOunces = new Methods();
            double actual = gramToOunces.ToOunces(grams);
            Assert.AreEqual(expected, actual, 0.0000001);
        }
    }
}
