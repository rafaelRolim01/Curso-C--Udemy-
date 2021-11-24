using System;
using System.Globalization;

namespace CourseExercicioPropostoIf07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número no EIXO-X: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite um número no EIXO-Y: ");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Quadrante: Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Quadrante: Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Quadrante: Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Quadrante: Q4");
            }
            else
            {
                Console.WriteLine("Origem");
            }


        }
    }
}
