﻿using MetalUp.FunctionalLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FunctionalLibraryTest
{
    [TestClass]
    public class Constructors : TestBase
    {

        [TestMethod]
        public void IsEmptyWithNull()
        {
            FList.IsEmpty<int>(null);
        }

        [TestMethod]
        public void Empty()
        {
            var list = FList.Empty<int>();
            Assert.IsTrue(FList.IsEmpty(list));
        }

        [TestMethod]
        public void NewHeadOnly()
        {
            var list = FList.New(1);
            Assert.IsFalse(FList.IsEmpty(list));
            Assert.AreEqual("1", list.ToString());
        }

        [TestMethod]
        public void NewWithNull()
        {
            var list = FList.New<int>(null);
            Assert.IsTrue(FList.IsEmpty(list));
        }

        [TestMethod]
        public void NewWithHeadAndNull()
        {
            var list = FList.New(3, null);
            Assert.IsFalse(FList.IsEmpty(list));
            Assert.AreEqual("3", list.ToString());
        }

        [TestMethod]
        public void NewWithHeadAndNullNullableType()
        {
            var list = FList.New<string>(null, "a", "b");
            Assert.IsFalse(FList.IsEmpty(list));
            Assert.AreEqual(", a, b", list.ToString());
        }

        [TestMethod]
        public void NewHeadOnlyChar()
        {
            var list = FList.New('1');
            Assert.IsFalse(FList.IsEmpty(list));
            Assert.AreEqual("1", list.ToString());
        }

        [TestMethod]
        public void NewWithEmptyString()
        {
            var list = FList.AsChars("");
            Assert.IsTrue(FList.IsEmpty(list));
        }

        [TestMethod]
        public void NewWithString()
        {
            var list = FList.AsChars("Hello");
            Assert.IsFalse(FList.IsEmpty(list));
            Assert.AreEqual("Hello", list.ToString());
        }

        [TestMethod]
        public void NewWithString2()
        {
            var list = FList.AsChars("Hello");
            var expected = FList.New('H', 'e', 'l', 'l', 'o');
            Assert.AreEqual(expected, list);
        }

        [TestMethod]
        public void NewWithString3()
        {
            var list = FList.New("Hello");
            Assert.AreEqual(1, FList.Length(list));
        }
    }
}
