using Microsoft.VisualStudio.TestTools.UnitTesting;
using BitCount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCount.Tests
{
    [TestClass()]
    public class BitCounterTests
    {
        [TestMethod()]
        public void countBitsTest1()
        {
            Assert.AreEqual(1, BitCounter.countBits(1));
        }

        [TestMethod()]
        public void countBitsTest100()
        {
            Assert.AreEqual(3, BitCounter.countBits(100));
        }

        [TestMethod()]
        public void countBitsTestMinus1()
        {
            Assert.AreEqual(32, BitCounter.countBits(-1));
        }

    }
}