#define PERFORMANCE_TEST

using System;
using System.Diagnostics;

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
            string result = anagram.Reverse(text);
            Console.WriteLine(result);
#if PERFORMANCE_TEST

            var performanceTest = new Anagram();
            var iterationCount = 100_000;

            var stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            for (int i = 0; i < iterationCount; i++)
            {
                performanceTest.Reverse("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ac nisi varius ex laoreet egestas ac nec orci. Vestibulum gravida purus ut arcu imperdiet, non sollicitudin metus sodales. Interdum et malesuada fames ac ante ipsum primis in faucibus. Donec cursus ipsum a tortor feugiat, vitae feugiat massa luctus. Aliquam id quam ac enim tincidunt dignissim. In hac habitasse platea dictumst. Praesent vel quam nisi. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.Morbi eget est quis dolor aliquet rhoncus.Duis suscipit vehicula nunc.Phasellus sollicitudin sapien in sollicitudin lobortis.Vivamus imperdiet velit augue, et consequat diam pellentesque at.Sed eget bibendum eros, eu sodales turpis.Donec bibendum imperdiet sem.Nam interdum nibh ut justo vulputate, vel hendrerit tellus egestas.Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Curabitur lobortis malesuada libero vitae ornare.Fusce suscipit, lectus sit amet pharetra vel.");
            }
            stopwatch.Stop();
            Console.WriteLine(
            $"Iteration count: {iterationCount}\n" +
            $"time: {stopwatch.Elapsed.ToString(@"m\:ss\.fff")}\n" +
            $"avrg.: {stopwatch.Elapsed.TotalMilliseconds / iterationCount}");

            return;
#pragma warning disable CS0162
#endif
        }
    }
}
