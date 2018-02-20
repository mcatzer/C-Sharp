using Microsoft.VisualStudio.TestTools.UnitTesting;
using RunLengthEncoding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunLengthEncoding.Tests
{
    [TestClass()]
    public class RunLengthEncodingTests
    {
        [TestMethod()]
        public void EncodeTestEmptyString()
        {
            RunLengthEncoding target = new RunLengthEncoding();
            Assert.AreEqual("", target.Encode(""));
        }

        [TestMethod()]
        public void EncodeTestNoRepeats()
        {
            RunLengthEncoding target = new RunLengthEncoding();
            Assert.AreEqual("ABC", target.Encode("ABC"));
        }

        [TestMethod()]
        public void EncodeTestNormalInput()
        {
            RunLengthEncoding target = new RunLengthEncoding();
            Assert.AreEqual("3A2B4C", target.Encode("AAABBCCCC"));
        }

        [TestMethod()]
        public void EncodeTestStringAndSpaces()
        {
            RunLengthEncoding target = new RunLengthEncoding();
            Assert.AreEqual("2 3AB", target.Encode("  AAAB"));
        }

        [TestMethod()]
        public void EncodeTestLowercase()
        {
            RunLengthEncoding target = new RunLengthEncoding();
            Assert.AreEqual("2a3b4c", target.Encode("aabbbcccc"));
        }

        [TestMethod()]
        public void DecodeTestEmptyString()
        {
            RunLengthEncoding target = new RunLengthEncoding();
            Assert.AreEqual("", target.Decode(""));
        }

        [TestMethod()]
        public void DecodeTestSingleChars()
        {
            RunLengthEncoding target = new RunLengthEncoding();
            Assert.AreEqual("XYZ", target.Decode("XYZ"));
        }

        [TestMethod()]
        public void DecodeTestNoSingleChars()
        {
            RunLengthEncoding target = new RunLengthEncoding();
            Assert.AreEqual("AABBBCCCC", target.Decode("2A3B4C"));
        }

        [TestMethod()]
        public void DecodeTestCharsWithRepeatedChars()
        {
            RunLengthEncoding target = new RunLengthEncoding();
            Assert.AreEqual("WWWWWWWWWWWWBWWWWWWWWWWWWBBBWWWWWWWWWWWWWWWWWWWWWWWWB", target.Decode("12WB12W3B24WB"));
        }

        [TestMethod()]
        public void DecodeTestWhitespaces()
        {
            RunLengthEncoding target = new RunLengthEncoding();
            Assert.AreEqual("  hsqq qww  ", target.Decode("2 hs2q q2w2 "));
        }

        [TestMethod()]
        public void EncodeAndDecodeTest()
        {
            RunLengthEncoding target = new RunLengthEncoding();
            Assert.AreEqual("zzz ZZ  zZ", target.Decode(target.Encode("zzz ZZ  zZ")));
        }
    }
}