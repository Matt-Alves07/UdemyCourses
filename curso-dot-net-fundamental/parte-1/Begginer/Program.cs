using System;

namespace Begginer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro parâmetro:");
            short num1 = short.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe o segundo parâmetro:");
            short num2 = short.Parse(Console.ReadLine());

            Console.WriteLine("Informe a operação desejada:");
            char operacao = char.Parse(Console.ReadLine());

            if (operacao == '+')
            {
                Console.WriteLine($"Resultado: {num1 + num2}");
            } else if (operacao == '-')
            {
                Console.WriteLine($"Resultado: {num1 - num2}");
            } else if ((operacao == '*') || (operacao == 'x'))
            {
                Console.WriteLine($"Resultado: {num1 * num2}");
            } else if (operacao == '/')
            {
                Console.WriteLine($"Resultado: {num1 / num2}");
            } else
            {
                Console.WriteLine("Operação não implementada.");
            }

            Console.ReadKey();
        }
    }
}
