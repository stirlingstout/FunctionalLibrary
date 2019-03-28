using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetalUp.FunctionalLibrary;

namespace FunctionalLibraryTest
{
    [TestClass]
    public class FLibTests
    {
        [TestMethod]
        public void If1()
        {
            Assert.AreEqual(3, FLib.If(1 > 0, 3, 4));
        }

        [TestMethod]
        public void If2()
        {
            Assert.AreEqual(4, FLib.If(1 < 0, 3, 4));
        }

        [TestMethod]
        public void If3()
        {
            Assert.AreEqual("Bar", FLib.If(1 < 0, "Foo", "Bar"));
        }

        [TestMethod]
        public void If4()
        {
            Assert.AreEqual("Foo", FLib.If<object>(1 < 2, "Foo", 4));
        }


        [TestMethod]
        public void Select1()
        {
           var actual = FLib.Select(3, Tuple.Create(false, 4), Tuple.Create(true,5), Tuple.Create(true, 6));
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void Select2()
        {
            var actual = FLib.Select(3, Tuple.Create(false, 4), Tuple.Create(false, 5), Tuple.Create(false, 6));
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void Select3()
        {
            var v = "foo";
            var actual = FLib.Select(v, 3, Tuple.Create("yon", 4), Tuple.Create("bar", 5), Tuple.Create("foo", 6), Tuple.Create("qux", 7));
            Assert.AreEqual(6, actual);
        }

    }
}
