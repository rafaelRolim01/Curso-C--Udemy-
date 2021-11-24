using System;

namespace CourseExercicioPropostoIf02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Didite um Número: ");
            int n = int.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                Console.WriteLine("PAR!");
            }
            else
            {
                Console.WriteLine("IMPAR!");
            }

        }
    }
}
