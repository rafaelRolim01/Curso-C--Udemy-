using System;

namespace CourseExercicioProposto03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor A");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor B");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor C");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor D");
            int d = int.Parse(Console.ReadLine());

            int dif = (a * b - c * d);

            Console.WriteLine("A Diferença de A e B pelo produto C e D = {0}", dif);
        }
    }
}
