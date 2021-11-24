using System;

namespace CourseExercicioPropostoIf03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o 1º Número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2º Número: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 % n2 == 0 || n2 % n1 == 0)
            {
                Console.WriteLine("São Multiplos!");
            }
            else
            {
                Console.WriteLine("Não São Multiplos!");
            }

        }
    }
}
