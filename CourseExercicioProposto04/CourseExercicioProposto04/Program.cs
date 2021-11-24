using System;
using System.Globalization;

namespace CourseExercicioProposto04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o Código do Funcionário: ");
            int cod = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as Horas Trabalhada do Funcionário: ");
            int horasTrabalhada = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o Valor por Hora Funcionário: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horasTrabalhada * valorHora;

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Código Funcionário = {0}", cod);
            Console.WriteLine("Salário Funcionário = U$ {0}", salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
