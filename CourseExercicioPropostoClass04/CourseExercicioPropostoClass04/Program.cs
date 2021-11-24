using System;
using System.Globalization;

namespace CourseExercicioPropostoClass04
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Entre coom o Dados do Funcionário");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Funcionário: " + f);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.Write("Digite a porcentagem para aumentar o Salário: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porc);

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine();
            Console.Write("Dados Atualizados: " + f);




        }
    }
}
