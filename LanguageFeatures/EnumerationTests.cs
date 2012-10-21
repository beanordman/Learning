using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LanguageFeatures
{
    internal class MyCollection : IEnumerable<int>
    {
        //class Enumerator<T> : IEnumerator<T>
        //{
        //    public T Current
        //    {
        //        get { throw new NotImplementedException(); }
        //    }

        //    public void Dispose()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    object System.Collections.IEnumerator.Current
        //    {
        //        get { throw new NotImplementedException(); }
        //    }

        //    public bool MoveNext()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void Reset()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
        private IEnumerator<int> getEnumerator()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return getEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return getEnumerator();
        }
    }

    [TestClass]
    public class EnumerationTests
    {
        [TestMethod]
        public void TestMyCollection()
        {
            var mc = new MyCollection();

            var i = 0;
            foreach(var n in mc)
            {
                Assert.AreEqual(++i, n);
            }
        }
    }
}
