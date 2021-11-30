using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;
using System;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void OnlyBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        BalancedBrackets test;
        [TestInitialize]
        public void CreateBalancedBracketsObject()
        {
            test = new BalancedBrackets();
        }
        [TestMethod]
        public void OnlyBracketsReturnsIsNotNull()
        {
           Assert.IsNotNull(test);
        }

    }
}
