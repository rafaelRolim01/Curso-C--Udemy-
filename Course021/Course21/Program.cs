using System;
using System.Globalization;


namespace Course21
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            Console.WriteLine("--------------------------------------------------------");

            DateTime d2 = new DateTime(2021, 11, 09);
            DateTime d3 = new DateTime(2021, 11, 09, 18, 00, 45);
            DateTime d4 = new DateTime(2021, 11, 09, 18, 00, 45, 350);

            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.Today;
            DateTime d7 = DateTime.UtcNow;

            DateTime d8 = DateTime.Parse("2000-08-15");
            DateTime d9 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d10 = DateTime.Parse("15/01/1992");
            DateTime d11 = DateTime.Parse("15/01/1992 13:05:58");

            DateTime d12 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d13 = DateTime.ParseExact("15/01/1992 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine();
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);
            Console.WriteLine(d13);
        }
    }
}
