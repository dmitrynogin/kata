using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace FareySequences.UnitTests
{
    [TestClass]
    public class FareySequence_Should
    {
        [TestMethod]
        public void Implement_F4()
        {
            var f4 = new[]
            {
                new RationalNumber(0, 1),
                new RationalNumber(1, 4),
                new RationalNumber(1, 3),
                new RationalNumber(1, 2),
                new RationalNumber(2, 3),
                new RationalNumber(3, 4),
                new RationalNumber(1, 1)
            };

            var result = new FareySequence(4)
                .ToArray();

            CollectionAssert.AreEqual(f4, result);
        }

        [TestMethod]
        public void Stringify_F4()
        {
            var f4 = new FareySequence(4);
            Assert.AreEqual("{0/1, 1/4, 1/3, 1/2, 2/3, 3/4}", f4.ToString());
        }
    }
}
