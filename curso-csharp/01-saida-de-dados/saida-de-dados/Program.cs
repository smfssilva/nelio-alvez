using System;
using System.Globalization;

namespace saida_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.23567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}"); // saldo.ToString("F2"), CultureInfo.InvariantCulture)
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}"); // saldo.ToString("F2"), CultureInfo.InvariantCulture)
            Console.WriteLine(""); // saldo.ToString("F2"), CultureInfo.InvariantCulture)
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine(""); // saldo.ToString("F2"), CultureInfo.InvariantCulture)
            Console.WriteLine("Media com oito casas decimais: {media:F8}");
            Console.WriteLine("Media com (três casas decimais): {media:F3}");
            Console.WriteLine("Separador decimal invariant culture: {0}", medida.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}
