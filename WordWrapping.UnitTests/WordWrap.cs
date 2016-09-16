using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordWrapping.UnitTests
{
    [TestClass]
    public class WordWrap_Should
    {
        // Integration test     
        [TestMethod]
        public void Break_Text()
        {            
            var given = "The quick brown fox jumped over the lazy dog.";

            var nl = Environment.NewLine;
            var expected = $"The quick brown{nl}fox jumped over{nl}the lazy dog.";

            Assert.AreEqual(expected, given.Wrap(15));
        }
    }
}
