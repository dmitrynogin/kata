using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordWrapping.UnitTests
{
    [TestClass]
    public class Wrapping_Should
    {
        [TestMethod]
        public void Break_Text()
        {
            var given = "The quick brown fox jumped over the lazy dog.";
            var expected = "The quick brown\nfox jumped over\nthe lazy dog.";
            Assert.AreEqual(expected, given.Wrap(15));
        }
    }
}
