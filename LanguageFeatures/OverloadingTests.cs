using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LanguageFeatures
{
    internal class Simple
    {
        public int Value { get; set; }

        protected bool Equals(Simple other)
        {
            return Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Simple) obj);
        }

        public override int GetHashCode()
        {
            return Value;
        }

        public static bool operator!=(Simple a, Simple b)
        {
            return !(a == b);
        }

        public static bool operator==(Simple a, Simple b)
        {
            if (a == null)
                return false;

            return a.Equals(b);
        }
    }

    [TestClass]
    public class OverloadingTests
    {
        [TestMethod]
        public void TestEqualsOperator()
        {
        }
    }
}
