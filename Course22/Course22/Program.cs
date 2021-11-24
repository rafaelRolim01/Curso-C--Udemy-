using System;

namespace Course22
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();

            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(900000000L);
            TimeSpan t4 = new TimeSpan(2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);

            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();

            TimeSpan f1 = TimeSpan.FromDays(1.5);
            TimeSpan f2 = TimeSpan.FromHours(1.5);
            TimeSpan f3 = TimeSpan.FromMinutes(1.5);
            TimeSpan f4 = TimeSpan.FromSeconds(1.5);
            TimeSpan f5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan f6 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(f3);
            Console.WriteLine(f4);
            Console.WriteLine(f5);




        }
    }
}
