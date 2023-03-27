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
            //arrage
            Anagram anagram = new Anagram();

            //act
            string output = anagram.Reverse(input);

            //assert
            Assert.AreEqual(expected, output);
        }

        [DataTestMethod]
        [DataRow("Π³οκΰ", "ΰκο³Π")]
        [DataRow("Telegram", "margeleT")]
        public void ReverseWord(string input, string expected)
        {
            //arrage
            Anagram anagram = new Anagram();

            //act
            string output = anagram.Reverse(input);

            //assert
            Assert.AreEqual(expected, output);
        }

        [DataTestMethod]
        [DataRow("anna", "anna")]
        [DataRow("12345", "12345")]
        public void NonReverseWord(string input, string expected)
        {
            //arrage
            Anagram anagram = new Anagram();

            //act
            string output = anagram.Reverse(input);

            //assert
            Assert.AreEqual(expected, output);
        }

        [DataTestMethod]
        [DataRow("%%%Moon%%%", "%%%nooM%%%")]
        [DataRow("A#pplicatio~n", "n#oitacilpp~A")]
        public void MixWordReverseAndNonReverseChar(string input, string expected)
        {
            //arrage
            Anagram anagram = new Anagram();

            //act
            string output = anagram.Reverse(input);

            //assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void ReverseSentence()
        {
            //arrage
            string input = "Initializes a new instance of the " +
                "Microsoft.VisualStudio.TestTools.UnitTesting.DataRowAttribute " +
                "class which takes in an array of arguments.";
            string expected = "sezilaitinI a wen ecnatsni fo eht " +
                "etubirttA.woRataDgnits.eTtinUslo.oTtseToidut.SlausiVtfosorciM " +
                "ssalc hcihw sekat ni na yarra fo stnemugra.";
            Anagram anagram = new Anagram();

            //act
            string output = anagram.Reverse(input);

            //assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void CheckIsEmpty()
        {
            //arrage
            string input = "";
            string expected = "";
            Anagram anagram = new Anagram();

            //act
            string output = anagram.Reverse(input);

            //assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void CheckIsNull()
        {
            //arrage
            string input = null;
            string expected = "";
            Anagram anagram = new Anagram();

            //act
            string output = anagram.Reverse(input);

            //assert
            Assert.AreEqual(expected, output);
        }
    }
}