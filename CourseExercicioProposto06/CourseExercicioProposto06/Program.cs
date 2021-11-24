using System;
using System.Globalization;

namespace CourseExercicioProposto06
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            Console.Write("Entre com o valor A: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o valor B: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o valor C: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double triangulo = (a * c) / 2;
            double circulo = pi * Math.Pow(c, 2);
            double trapezio = (a + b) * c / 2;
            double quadrado = Math.Pow(b, 2);
            double retangulo = a * b;


            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("Área do Triandulo: {0}", triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do Circulo: {0}", circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do Trapézio: {0}", trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do Quadrado: {0}", quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do Retangulo: {0}", retangulo.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
