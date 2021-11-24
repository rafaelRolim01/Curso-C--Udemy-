using System;
using System.Globalization;

namespace CourseExercicioPropostoClass02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios f1 = new Funcionarios();
            Funcionarios f2 = new Funcionarios();

            double salarioMedio = 0.0;

            Console.WriteLine("Dados do primeiro Funcionário:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Sálario: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Dados do segundo Funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Sálario: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioMedio = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("Sálario Médio = {0}", salarioMedio.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
