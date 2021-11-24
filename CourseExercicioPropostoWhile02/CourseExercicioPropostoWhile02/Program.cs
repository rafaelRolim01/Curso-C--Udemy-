using System;

namespace CourseExercicioPropostoWhile02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite dua Coordenadas (X, Y):");
            string[] vetor = Console.ReadLine().Split(' ');
            int x = int.Parse(vetor[0]);
            int y = int.Parse(vetor[1]);

            while (x != 0 && y != 0)
            {
                
                if (x > 0 && y > 0) 
                    Console.WriteLine("Primeiro Quadrante!");
                if (x < 0 && y > 0) 
                    Console.WriteLine("Segundo Quadrante!");
                if (x < 0 && y < 0) 
                    Console.WriteLine("Terceiro Quadrante!");
                if (x > 0 && y < 0) 
                    Console.WriteLine("Quarto Quadrante!");

                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Digite dua Coordenadas (X, Y):");
                vetor = Console.ReadLine().Split(' ');
                x = int.Parse(vetor[0]);
                y = int.Parse(vetor[1]);

            }

            Console.WriteLine("");


        }
    }
}
