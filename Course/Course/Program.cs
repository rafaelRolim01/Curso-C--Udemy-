using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa da escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"Produtos:\n{produto1}, cujo o preço é R$ {preco1:F2}\n{produto2}, cujo o preço é R$ {preco2:F2}");

            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Registro {0} anos de idade, código {1} e gênero: {2} ", idade, codigo, genero);

            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine($"Medida com oito casa decimais: {medida}");
            Console.WriteLine("Arredondando (três casas decimais): {0:F3}", medida);
            Console.WriteLine("Sepadador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
