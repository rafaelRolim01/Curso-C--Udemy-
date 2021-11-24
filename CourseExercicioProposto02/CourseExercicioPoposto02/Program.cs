using System;
using System.Globalization;

namespace CourseExercicioPoposto02
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A = {0}", area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
