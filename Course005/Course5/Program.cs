using System;

namespace Course5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos Números Inteiros você vai Digitar? : ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            for(int i = 1; i <= n; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Soma = " + soma);
        }
    }
}
