using System;
using System.Globalization;

namespace CourseExercicioPropostoIf06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor Decimal: ");
            double numero = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);


             if (numero > 0 && numero <= 25)
            {
                Console.WriteLine("INTERVALO (0, 25)");
            }
             else if (numero > 25 && numero <= 50)
            {
                Console.WriteLine("INTERVALO (25, 50)");
            }
             else if (numero > 50 && numero <= 75)
            {
                Console.WriteLine("INTERVALO (50, 75)");
            }
             else if (numero > 75 && numero <= 100)
            {
                Console.WriteLine("INTERVALO (75, 100)");
            }
            else
            {
                Console.WriteLine("FORA DE INTERVALO!");
            }
        }
    }
}
