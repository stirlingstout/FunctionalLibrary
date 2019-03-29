using MetalUp.FunctionalLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FunctionalLibraryTest
{
    [TestClass]
    public class FoldR : TestBase
    {
        [TestMethod]
        public void FoldR1()
        {
            var list = FList.New(1, 2, 4, 8, 16);
            int actual = FList.FoldR((agg, input) => agg + input, 0, list);
            Assert.AreEqual(31, actual);
        }

        [TestMethod]
        public void FoldR2()
        {
            var list = FList.New(1, 2, 4, 8, 16);
            int actual = FList.FoldR((agg, input) => agg * input, 1, list);
            Assert.AreEqual(1024, actual);
        }

        [TestMethod]
        public void FoldR3()
        {
            var list = FList.New(1, 2, 4, 8, 16);
            int actual = FList.FoldR((agg, input) => agg - input, 0, list);
            Assert.AreEqual(11, actual);
        }

        [TestMethod]
        public void FoldR4()
        {
            var list = FList.New(1, 2, 4, 8, 16);
            int actual = FList.FoldR((agg, input) => agg / input, 1, list);
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void FoldR5()
        {
            var list = FList.New<int>(1, 2, 4, 8, 16);
            string actual = FList.FoldR<int, string>((input, agg) => agg + input.ToString(), "", list);
            Assert.AreEqual("124816", actual);
        }

        [TestMethod]
        public void FoldR1String()
        {
            var list = "abcde";
            int actual = FList.FoldR((agg, input) => agg + Convert.ToInt32(input), 0, list);
            Assert.AreEqual(495, actual);
        }
    }
}
