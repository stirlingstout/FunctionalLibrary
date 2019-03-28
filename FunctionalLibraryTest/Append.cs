using MetalUp.FunctionalLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionalLibraryTest
{
    [TestClass]
    public class Append : TestBase
    {
        [TestMethod]
        public void Append1()
        {
            var list = FList.New(1, 2, 3);
            var actual = FList.Append(list, FList.New(4));
            var expected = FList.New(1, 2, 3, 4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Append2()
        {
            var list = FList.New(1);
            var actual = FList.Append(list, FList.New(4));
            var expected = FList.New(1, 4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Append3()
        {
            var list = FList.Empty<int>();
            var actual = FList.Append(list, FList.New(4));
            var expected = FList.New(4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Append4()
        {
            var list = FList.New(1,2);
            var actual = FList.Append(list, FList.New(4,7));
            var expected = FList.New(1,2,4,7);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Append1String()
        {
            var list =  "123";
            var actual = FList.Append(list, "4");
            var expected = "1234";
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void Append2String()
        {
            var list = "1";
            var actual = FList.Append(list, "4");
            var expected = "14";
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void Append3String()
        {
            var list = "";
            var actual = FList.Append(list, "4");
            var expected = "4";
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void Append4String()
        {
            var list = "12";
            var actual = FList.Append(list, "47");
            var expected = "1247";
            Assert.AreEqual(expected, actual.ToString());
        }

    }
}
