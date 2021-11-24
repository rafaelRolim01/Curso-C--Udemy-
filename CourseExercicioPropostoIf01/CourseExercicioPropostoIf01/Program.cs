using System;

namespace CourseExercicioPropostoIf01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um Número: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("NEGATIVO!");
            }
            else
            {
                Console.WriteLine("NÃO NEGATIVO!");
            }


        }
    }
}
