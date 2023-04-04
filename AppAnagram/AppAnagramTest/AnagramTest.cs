using AppAnagram;

namespace AppAnagramTest
{
    [TestClass]
    public class AnagramTest
    {
        [DataTestMethod]
        [DataRow("Test", "tseT")]
        [DataRow("abcd efgh", "dcba hgfe")]
        [DataRow("a1bcd efg!h", "d1cba hgf!e")]
        [DataRow("  a1bcd    efg!h", "  d1cba    hgf!e")]
        public void QuickTest(string input, string expected)
        {
            Anagram anagram = new Anagram();
            string output = anagram.Reverse(input);
            Assert.AreEqual(expected, output);
        }

        [DataTestMethod]
        [DataRow("Ріпка", "акпіР")]
        [DataRow("anna", "anna")]
        [DataRow("Telegram", "margeleT")]
        public void ReverseWord(string input, string expected)
        {
            Anagram anagram = new Anagram();
            string output = anagram.Reverse(input);
            Assert.AreEqual(expected, output);
        }

        [DataTestMethod]
        [DataRow("/'₴!*?)%;)(+=", "/'₴!*?)%;)(+=")]
        [DataRow("12345", "12345")]
        [DataRow("9", "9")]
        [DataRow("і", "і")]
        public void NonReverseWord(string input, string expected)
        {
            Anagram anagram = new Anagram();
            string output = anagram.Reverse(input);
            Assert.AreEqual(expected, output);
        }

        [DataTestMethod]
        [DataRow("%%%Moon%%%", "%%%nooM%%%")]
        [DataRow("A#pplicatio~n", "n#oitacilpp~A")]
        public void ReverseWordAndNonReverseChar(string input, string expected)
        {
            Anagram anagram = new Anagram();
            string output = anagram.Reverse(input);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void ReverseSentence()
        {
            string input = "Initializes a new instance of the " +
                "Microsoft.VisualStudio.TestTools.UnitTesting.DataRowAttribute " +
                "class which takes in an array of arguments.";
            string expected = "sezilaitinI a wen ecnatsni fo eht " +
                "etubirttA.woRataDgnits.eTtinUslo.oTtseToidut.SlausiVtfosorciM " +
                "ssalc hcihw sekat ni na yarra fo stnemugra.";
            Anagram anagram = new Anagram();
            string? output = anagram.Reverse(input);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void CheckIsEmpty()
        {
            string input = "";
            string expected = "";
            Anagram anagram = new Anagram();
            string output = anagram.Reverse(input);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void CheckIsNull()
        {
            string? input = null;
            string expected = "";
            Anagram anagram = new Anagram();
            string output = anagram.Reverse(input);
            Assert.AreEqual(expected, output);
        }
    }
}