using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAnagram
{
    public class Anagram
    {
        public string Reverse(string? text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ReverseWord(words[i]);
            }
            return string.Join(' ', words);
        }

        private string ReverseWord(string word)
        {
            StringBuilder wordBuilder = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                if (char.IsLetter(word[i]))
                {
                    wordBuilder.Append(word[i]);
                }
            }
            for (int  j = 0; j < word.Length; j++)
            {
                if (!char.IsLetter(word[j]))
                {
                    wordBuilder.Insert(j, word[j]);
                }
            }
            return wordBuilder.ToString();
        }
    }
}
