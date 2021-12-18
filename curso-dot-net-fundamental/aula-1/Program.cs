using System;

namespace aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string saudacao = "         Tamos aí.....     ";
            Console.WriteLine($"[{saudacao}]");
            Console.WriteLine($"[{saudacao.TrimStart()}]");
            Console.WriteLine($"[{saudacao.TrimEnd()}]");
            Console.WriteLine($"[{saudacao.Trim()}]");
        }
    }
}