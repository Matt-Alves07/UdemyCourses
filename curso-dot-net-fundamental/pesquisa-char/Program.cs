using System;

namespace pesquisa_char
{
    class Program
    {
        static void Main(string[] args)
        {
            string songLyrics = "Get, get, get, get, get low, when the whistle goes.....";
            Console.WriteLine($"{songLyrics}");

            if (songLyrics.Contains("get low"))
            {
                Console.WriteLine("By DJ Snake");
            }
        }
    }
}
