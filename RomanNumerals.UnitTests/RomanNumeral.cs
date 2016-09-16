using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals.UnitTests
{
    [TestClass]
    public class RomanNumber_Should
    {
        [TestMethod]
        public void Interpret_MMXVI_As_2016()
        {
            var rn = new RomanNumeral("MMXVI");
            var result = rn.ToInt32();
            Assert.AreEqual(2016, result);
        }

        [TestMethod]
        public void Interpret_XXXVI_As_36()
        {
            var rn = new RomanNumeral("XXXVI");
            var result = rn.ToInt32();
            Assert.AreEqual(36, result);
        }

        [TestMethod]
        public void Interpret_MMXII_As_2012()
        {
            var rn = new RomanNumeral("MMXII");
            var result = rn.ToInt32();
            Assert.AreEqual(2012, result);
        }
    }
}
