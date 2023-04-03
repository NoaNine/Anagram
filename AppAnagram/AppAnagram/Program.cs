using System;

namespace AppAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Anagram anagram = new Anagram(); 
            Console.WriteLine(Properties.Messages.Greeting);
            Console.Write(Properties.Messages.AskTextForAnagram);
            string? text = Console.ReadLine();
            string? result = anagram.Reverse(text);
            Console.WriteLine(result);
        }
    }
}