using System;

namespace Course14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 10;
            Calculator.Triple(ref a1);
            Console.WriteLine(a1);

            int a = 10;
            int triple;

            Calculator.Triple2(a, out triple);
            Console.WriteLine(a);
            Console.WriteLine(triple);
        }
    }
}
