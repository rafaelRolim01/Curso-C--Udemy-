using System;

namespace CourseExercicioProposto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o 1º valor: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o 2º valor: ");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine($"A RESULTADO de {n1} + {n2} = {soma}");
        }
    }
}
