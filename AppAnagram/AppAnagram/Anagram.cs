using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAnagram
{
    public class Anagram
    {
        public string Reverse(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }
            string[] word = str.Split(' ');
            for (int i = 0; i < word.Length; i++)
            {
                word[i] = ReverseWord(word[i]);
            }
            return string.Join(' ', word);
        }

        private string ReverseWord(string word)
        {
            char[] reverseWordInChars = new char[word.Length];
            int counterLastLetter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsLetter(word[i]))
                {
                    for (int j = reverseWordInChars.Length - 1 - counterLastLetter; j > -1; j--)
                    {
                        if (Char.IsLetter(word[j]))
                        {
                            reverseWordInChars[j] = word[i];
                            counterLastLetter++;
                            break;
                        }
                        else
                        {
                            counterLastLetter++;
                        }
                    }
                }
                else
                {
                    reverseWordInChars[i] = word[i];
                }
            }
            return new string(reverseWordInChars);
        }
    }
}
