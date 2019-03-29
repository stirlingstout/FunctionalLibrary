using MetalUp.FunctionalLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FunctionalLibraryTest
{
    [TestClass]
    public class Map : TestBase
    {
        [TestMethod]
        public void Map1()
        {
            var list = FList.New(1, 2, 3);
            var actual = FList.Map(i => i * i, list);
            var expected = FList.New(1, 4, 9);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Map2()
        {
            var list = FList.New(3);
            var actual = FList.Map(i => i * i, list);
            var expected = FList.New(9);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Map3()
        {
            var list = FList.Empty<int>();
            var actual = FList.Map(i => i * i, list);
            var expected = FList.Empty<int>();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Map1String()
        {
            var list = "abc";
            var actual = FList.Map(i => Convert.ToInt32(i), list);
            var expected = FList.New(97, 98, 99);
            Assert.AreEqual(expected, actual);
        }
    }
}
