using System;
using System.Globalization;

namespace CourseExercicioProposto05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o código da Peça: ");
            int cod = int.Parse(Console.ReadLine());

            Console.Write("Informe a Quantidade de Peça: ");
            int qtd = int.Parse(Console.ReadLine());

            Console.Write("Informe o Valor da Peça: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe o código da Peça 2: ");
            int cod2 = int.Parse(Console.ReadLine());

            Console.Write("Informe a Quantidade de Peça 2: ");
            int qtd2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o Valor da Peça 2: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = qtd * valor;
            double total2 = qtd2 * valor2;

            double totalPeca = total + total2;

            Console.WriteLine("Total a Pagar: R$ " + totalPeca.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
