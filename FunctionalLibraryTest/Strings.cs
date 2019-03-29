using System;
using MetalUp.FunctionalLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionalLibraryTest
{
    [TestClass]
    public class Strings
    {
        [TestMethod]
        public void Strings1()
        {
            var list = FList.New("Tom", "Dick", "Harry");
            Assert.AreEqual("Tom", FList.Head(list));
        }

        [TestMethod]
        public void Strings2()
        {
            var list = FList.New("Tom", "Dick", "Harry");
            var expected = FList.New("Dick", "Harry");
            Assert.AreEqual(expected, FList.Tail(list));
        }

        [TestMethod]
        public void Strings3()
        {
            var list = FList.AsChars("Tom");
            var expected = 'T';
            Assert.AreEqual(expected, FList.Head(list));
        }

        [TestMethod]
        public void Strings4()
        {
            var list = FList.AsChars("Tom");
            var expected = FList.New('o', 'm');
            Assert.AreEqual(expected, FList.Tail(list));
        }


        [TestMethod]
        public void Strings5()
        {
            var list = FList.New("Tom", "Dick", "Harry");
            var expected = 'T';
            Assert.AreEqual(expected, FList.Head(FList.Head(list)));
        }

        [TestMethod]
        public void Strings6()
        {
            var list = FList.New("Tom", "Dick", "Harry");
            var expected = FList.New('o', 'm');
            Assert.AreEqual(expected, FList.Tail(FList.Head(list)));
        }

        [TestMethod]
        public void Strings7()
        {
            var str =  "Harry";
            var expected = 'H';
            Assert.AreEqual(expected, FList.Head(str));
        }

        [TestMethod]
        public void Strings8()
        {
            var str = "Harry";
            var expected = "arry";
            Assert.AreEqual(expected, FList.Tail(str).ToString());
        }

        [TestMethod]
        public void Strings9()
        {
            var str = "Harry";
            var expected = "HarryVI";
            Assert.AreEqual(expected, FList.Append(str, "VI").ToString());
        }

        [TestMethod]
        public void Strings10()
        {
            var list  = FList.AsChars("Henry");
            var expected = "HenryVIII";
            Assert.AreEqual(expected, FList.Append(list, "VIII").ToString());
        }

        [TestMethod]
        public void Strings11()
        {
            var list = FList.AsChars("Henry");
            var expected = "HenryVIII";
            Assert.AreEqual(expected, FList.Append(list, FList.AsChars("VIII")).ToString());
        }

    }
}
