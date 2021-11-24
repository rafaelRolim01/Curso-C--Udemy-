using System;
using System.Globalization;

namespace CourseExercicioPropostoClassStatic01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? : ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos Dólares você vai comprar?: ");
            double valorReal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorTotal = ConversorDeMoeda.DolarParaReal(valorReal, dolar);

            Console.Write("Valor a ser pago em reais: " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
