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
    }
}
