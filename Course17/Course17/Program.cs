using System;

namespace Course17
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); //Serve para ver a quantidade de celula emm uma matriz

            Console.WriteLine(mat.Rank); //Serve para ver a quantidade de linha de uma matriz

            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));

        }
    }
}
