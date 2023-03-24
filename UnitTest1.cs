using System;
using MyAnagram;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyAnagramTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            //arrage
            string input = "Test";
            string expected = "tseT";
            Anagram anagram = new Anagram();

            //act
            string output = anagram.Reverse(input);

            //assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void Test2()
        {
            //arrage
            string input = "abcd efgh";
            string expected = "dcba hgfe";
            Anagram anagram = new Anagram();

            //act
            string output = anagram.Reverse(input);

            //assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void Test3()
        {
            //arrage
            string input = "  a1bcd    efg!h";
            string expected = "  d1cba    hgf!e";
            Anagram anagram = new Anagram();

            //act
            string output = anagram.Reverse(input);

            //assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void Test4()
        {
            //arrage
            string input = "  a111bcd    efg!!!h";
            string expected = "  d111cba    hgf!!!e";
            Anagram anagram = new Anagram();

            //act
            string output = anagram.Reverse(input);

            //assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void Test5()
        {
            //arrage
            string input = "";
            string expected = "IsNullOrEmpty";
            Anagram anagram = new Anagram();

            //act
            string output = anagram.Reverse(input);

            //assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void Test6()
        {
            //arrage
            string input = null;
            string expected = "IsNullOrEmpty";
            Anagram anagram = new Anagram();

            //act
            string output = anagram.Reverse(input);

            //assert
            Assert.AreEqual(expected, output);
        }
    }
}
