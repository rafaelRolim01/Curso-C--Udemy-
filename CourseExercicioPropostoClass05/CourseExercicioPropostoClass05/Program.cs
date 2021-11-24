using System;
using System.Globalization;

namespace CourseExercicioPropostoClass05
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno nota = new Aluno();

            Console.Write("Nome do Aluno: ");
            nota.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            Console.Write("Primeiro Trimeste: ");
            nota.PrimeiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Segundo Trimeste: ");
            nota.SegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Terceiro Trimeste: ");
            nota.TerceiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final: " + nota.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

             

            if (nota.NotaFinal() >= 60)
            {
                Console.WriteLine("Aluno Aprovado!");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado!");
                Console.WriteLine("Falta {0} Pontos!", nota.NotaRestante().ToString("F2", CultureInfo.InvariantCulture));
            }





        }
    }
}
