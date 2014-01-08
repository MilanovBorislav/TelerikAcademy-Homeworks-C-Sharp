using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_04_LongestSubsequence;

namespace TestEquals
{
    [TestClass]
    public class LongestEqualSequenceTest
    {
        private static bool EqualsValues(List<int> firstArr, List<int> secondArr)
        {
            for (int i = 0; i < firstArr.Count; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    return false;
                }
            }
            return true;
        }

        [TestMethod]
        public void IsEqualsMiddle()
        {
            int[] arr = { 3, 4, 6, 6, 6, 6, 1, 1, 2, 2, 2 };
            List<int> equals = LongestSubsequence.FindLongestEqualSequence(arr);
            List<int> numbers = new List<int>() { 6, 6, 6, 6 };
            bool equal = EqualsValues(equals, numbers);
            Assert.IsTrue(equal);
        }

        [TestMethod]
        public void IsEqualsBeginning()
        {
            int[] arr = { 7, 7, 71, 1, 4, 8 };
            List<int> equals = LongestSubsequence.FindLongestEqualSequence(arr);
            List<int> numbers = new List<int>() { 7, 7 };
            bool equal = EqualsValues(equals, numbers);
            Assert.IsTrue(equal);
        }

        [TestMethod]
        public void IsEqualsEnding()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 6, 6, 6, 6, 6, 6 };
            List<int> equals = LongestSubsequence.FindLongestEqualSequence(arr);
            List<int> numbers = new List<int>() { 6, 6, 6, 6, 6, 6, 6 };
            bool equal = EqualsValues(equals, numbers);
            Assert.IsTrue(equal);
        }

        [TestMethod]
        public void TestOneItem()
        {
            int[] arr = { 1 };
            List<int> equals = LongestSubsequence.FindLongestEqualSequence(arr);
            List<int> numbers = new List<int>() { 1 };
            bool equal = EqualsValues(equals, numbers);
            Assert.IsTrue(equal);
        }
    }
}