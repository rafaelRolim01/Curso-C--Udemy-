using System;

namespace CourseExercicioPropostoClass01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas p1 = new Pessoas();
            Pessoas p2 = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Digite o nome completo: ");
            p1.Nome = Console.ReadLine();
             Console.Write("Digite a Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Digite o nome completo: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Digite a Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("A Pessoa Mais Velha: {0}", p1.Nome);
            }
            else
            {
                Console.WriteLine("A Pessoa Mais Velha: {0}", p2.Nome);
            }

            
        }
    }
}
