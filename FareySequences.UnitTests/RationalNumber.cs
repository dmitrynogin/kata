using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FareySequences.UnitTests
{
    [TestClass]
    public class RationalNumber_Should
    {
        [TestMethod]
        public void Represent_Numerator_And_Denomerator()
        {
            var rn = new RationalNumber(33, 44);

            Assert.AreEqual("33/44", rn.ToString());
        }

        [TestMethod]
        public void Be_Comparable()
        {
            var smaller = new RationalNumber(1, 3);
            var bigger = new RationalNumber(1, 2);
                        
            Assert.AreEqual(-1, smaller.CompareTo(bigger));
        }

        [TestMethod]
        public void Be_Equitable()
        {
            var left = new RationalNumber(1, 3);
            var right = new RationalNumber(1, 3);

            Assert.AreEqual(0, left.CompareTo(right));
        }
    }
}
