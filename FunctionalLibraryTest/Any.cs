using MetalUp.FunctionalLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionalLibraryTest
{
    [TestClass]
    public class AnyTests : TestBase
    {
        [TestMethod]
        public void Any1()
        {
            var list = FList.New(1, 2, 3);
            var any = FList.Any(i => i > 1, list);
            Assert.IsTrue(any);
        }

        [TestMethod]
        public void Any2()
        {
            var list = FList.New(1, 2, 3);
            var any = FList.Any(i => i > 3, list);
            Assert.IsFalse(any);
        }

        [TestMethod]
        public void Any3()
        {
            var list = FList.New(3);
            var any = FList.Any(i => i > 2, list);
            Assert.IsTrue(any);
        }

        [TestMethod]
        public void Any4()
        {
            var list = FList.New(3);
            var any = FList.Any(i => i > 3, list);
            Assert.IsFalse(any);
        }

        [TestMethod]
        public void Any5()
        {
            var list = FList.Empty<int>();
            var any = FList.Any(i => i > 3, list);
            Assert.IsFalse(any);
        }
        [TestMethod]
        public void Any1String()
        {
            var list = "123";
            var any = FList.Any(i => i > '1', list);
            Assert.IsTrue(any);
        }

        [TestMethod]
        public void Any2String()
        {
            var list = "123";
            var any = FList.Any(i => i > '3', list);
            Assert.IsFalse(any);
        }

        [TestMethod]
        public void Any3String()
        {
            var list = "3";
            var any = FList.Any(i => i > '2', list);
            Assert.IsTrue(any);
        }

        [TestMethod]
        public void Any4String()
        {
            var list = "3";
            var any = FList.Any(i => i > '3', list);
            Assert.IsFalse(any);
        }

        [TestMethod]
        public void Any5String()
        {
            var list = "";
            var any = FList.Any(i => i > '3', list);
            Assert.IsFalse(any);
        }
    }
}
