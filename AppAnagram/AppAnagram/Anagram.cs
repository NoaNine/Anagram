using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
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
            if (text.Length == 1)
            {
                return text;
            }
            char[] textInChars = text.ToCharArray();
            int start = 0;
            for (int i = 0; i < textInChars.Length; i++)
            {
                if (char.IsWhiteSpace(textInChars[i]))
                {
                    ReverseWord(textInChars, start, i);
                    start = i;
                }
            }
            ReverseWord(textInChars, start, textInChars.Length - 1);
            return new string(textInChars);
        }

        private void ReverseWord(char[] word, int start, int end)
        {
            while (start < end)
            {
                if (char.IsLetter(word[start]) && !char.IsLetter(word[end]))
                {
                    end--;
                    continue;
                }
                if (char.IsLetter(word[start]) && char.IsLetter(word[end]))
                {
                    Swap(word, start, end);
                    start++;
                    end--;
                    continue;
                }
                start++;
            }
        }

        private void Swap(char[] word, int start, int end)
        {
            char temp = word[start];
            word[start] = word[end];
            word[end] = temp;
        }
    }
}
