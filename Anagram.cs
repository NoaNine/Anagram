using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAnagram
{
    public class Anagram
    {
        private string ReverseWord(string word)
        {
            char[] wordInChars = word.ToCharArray();
            char[] reverseWordInChars = new char[word.Length];
            int counterLastLetter = 0;
            for (int i = 0; i < wordInChars.Length; i++)
            {
                if (Char.IsLetter(wordInChars[i]))
                {
                    for (int j = reverseWordInChars.Length - 1 - counterLastLetter; j > -1; j--)
                    {
                        if (Char.IsLetter(wordInChars[j]))
                        {
                            reverseWordInChars[j] = wordInChars[i];
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
                    reverseWordInChars[i] = wordInChars[i];
                }
            }
            return new string(reverseWordInChars);
        }
        public string Reverse(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "IsNullOrEmpty";
            }
            else
            {
                string[] word = str.Split(' ');
                for (int i = 0; i < word.Length; i++)
                {
                    word[i] = ReverseWord(word[i]);
                }
                return string.Join(' ', word);
            }
        }
    }
}
