using System;
using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        private void ImprimeStrings()
        {
            string produto1 = "Computador", produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0, preco2 = 650.50, medida = 53.1234567;

            Console.WriteLine($"{produto1}, cujo preço é R$ {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é R$ {preco2}");

            Console.WriteLine("");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e genêro: {genero}");

            Console.WriteLine("");
            Console.WriteLine($"Medida com oito casas decimais: {medida}");
            Console.WriteLine($"Arredondado(três casas decimais): {medida:F3}");
            Console.WriteLine("Separador universal com três casas decimais: {0}", medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}