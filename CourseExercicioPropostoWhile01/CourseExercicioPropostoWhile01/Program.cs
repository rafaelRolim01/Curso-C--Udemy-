using System;

namespace CourseExercicioPropostoWhile01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a Senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida: ");
                Console.WriteLine("-----------------------");
                Console.Write("Digite Novamente: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");


            
            
        }
    }
}
