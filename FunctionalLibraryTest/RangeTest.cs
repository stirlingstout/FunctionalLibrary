using System;
using System.Text;
using System.Collections.Generic;
using MetalUp.FunctionalLibrary;
using static MetalUp.FunctionalLibrary.FList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionalLibraryTest
{
    /// <summary>
    /// Summary description for InfiniteSeriesTest
    /// </summary>
    [TestClass]
    public class RangeTest
    {
     
        [TestMethod]
        public void Range1()
        {
            var r = EnumFrom(1);
            Assert.AreEqual("1..", r.ToString());
            Assert.AreEqual(1, Head(r));
            Assert.AreEqual(2, Head(Tail(r)));
            Assert.AreEqual(3, Head(Tail(Tail(r))));
        }

        [TestMethod]
        public void Range2()
        {
            var r = EnumFromTo(1,3);
            Assert.AreEqual("1..3", r.ToString());
            Assert.AreEqual(1, Head(r));
            Assert.AreEqual(2, Head(Tail(r)));
            Assert.AreEqual(3, Head(Tail(Tail(r))));
            Assert.AreEqual(Empty<int>(), Tail(Tail(Tail(r))));
        }
        [TestMethod]
        public void Range3()
        {
            var r = EnumFromThenTo(1,3,19);
            Assert.AreEqual("1,3..19", r.ToString());
            Assert.AreEqual(1, Head(r));
            Assert.AreEqual(3, Head(Tail(r)));
            Assert.AreEqual(5, Head(Tail(Tail(r))));
        }

        [TestMethod]
        public void Range4()
        {
            var actual = Take(4, EnumFrom(9));
            var expected = NewFList(9,10,11,12);
            Assert.AreEqual(expected, actual);
        }

    }
}
