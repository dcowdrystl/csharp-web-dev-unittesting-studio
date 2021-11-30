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
        public void OnlyLeftBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
            
        }

        [TestMethod]
        public void OnlyRightBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));

        }

        [TestMethod]
        public void OnlyDoubleBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][]"));
        }

        [TestMethod]
        public void BracketsWithWordsInsideReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Launch]"));
        }

        [TestMethod]
        public void NestedBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"));
        }

        [TestMethod]
        public void OnlyUnevenBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void UnevenBracketsWithWordsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void NumbersInBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[123]"));
        }

        [TestMethod]
        public void OnlyOpeningBracketWithWordsFollowingReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Launch"));

        }

        [TestMethod]
        public void OutOfOrderBracketWithWordsFollowingReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Launch]]["));

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
