using System;
using System.Globalization;

namespace CourseExercicioPropostoClass03
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret;

            ret = new Retangulo();
            

            Console.WriteLine("Entre com a Largura e altura do Retângulo:");
            Console.Write("Largura: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = ret.Area();
            double peri = ret.Perimetro();
            double diag = ret.Diagonal();

            Console.WriteLine();
            Console.WriteLine("Área: {0}", area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Perímetro: {0}", peri.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Diagonal: {0}", diag.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
