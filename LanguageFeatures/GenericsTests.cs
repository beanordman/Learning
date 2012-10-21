using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LanguageFeatures
{
    internal class MyContainer<T>
    {
        public MyContainer(T t)
        {
            Value = t;
        }

        public T Value { get; private set; }
    }

    internal class MyListContainer<T> : MyContainer<T> 
        where T : List<int>
    {
        public MyListContainer(T t) :base(t)
        {}
    }

    [TestClass]
    public class GenericsTests
    {
        [TestMethod]
        public void TestContainer()
        {
            Assert.AreEqual(1, new MyContainer<int>(1).Value);
        }

        [TestMethod]
        public void TestMyListContainer()
        {
            var v = new MyContainer<List<int>>(new List<int> {1, 2, 3});
            Assert.AreEqual(1, v.Value[0]);
            Assert.AreEqual(2, v.Value[1]);
            Assert.AreEqual(3, v.Value[2]);
        }
    }
}
