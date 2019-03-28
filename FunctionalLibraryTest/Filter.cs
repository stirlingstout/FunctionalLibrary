using MetalUp.FunctionalLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionalLibraryTest
{
    [TestClass]
    public class FilterTests :TestBase
    {
        [TestMethod]
        public void Filter1()
        {
            var list = FList.New(1, 2, 3);
            var actual = FList.Filter(i => i > 1, list);
            var expected = FList.New(2, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Filter2()
        {
            var list = FList.New(1, 2, 3);
            var actual = FList.Filter(i => i > 3, list);
            var expected = FList.Empty<int>();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Filter3()
        {
            var list = FList.New(1, 2, 3);
            var actual = FList.Filter(i => i > 0, list);
            var expected = FList.New(1, 2, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Filter1String()
        {
            var list = "123";
            var actual = FList.Filter(i => i > '1', list);
            var expected = "23";
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void Filter2String()
        {
            var list = "123";
            var actual = FList.Filter(i => i > '3', list);
            var expected = FList.Empty<char>();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Filter3String()
        {
            var list = "123";
            var actual = FList.Filter(i => i > '0', list);
            var expected = "123";
            Assert.AreEqual(expected, actual.ToString());
        }
    }
}
