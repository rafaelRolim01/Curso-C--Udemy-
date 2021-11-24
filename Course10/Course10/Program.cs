using System;

namespace Course10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p;
            //p.X = 10;
            //p.Y = 20;

            //Console.WriteLine(p);

            //p = new Point();
            //Console.WriteLine(p);

            //Nullable<double> x = null;
            //double? x1 = null;
            //double? y1 = 10.0;

            //Console.WriteLine(x1.GetValueOrDefault());
            //Console.WriteLine(y1.GetValueOrDefault());

            //Console.WriteLine(x1.HasValue);
            //Console.WriteLine(y1.HasValue);

            //if(x1.HasValue)
            //    Console.WriteLine(x1.Value);
            //else
            //    Console.WriteLine("X is null");

            //if(y1.HasValue)
            //    Console.WriteLine(y1.Value);
            //else
            //    Console.WriteLine("Y is null");

            double? x = null;
            double? y = 10;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
            
        }
    }
}
