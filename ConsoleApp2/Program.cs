using System;

namespace ConsoleApp1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Double x1 = 0;
            Double x2 = 0;
            Double x3 = 0;
            Double y1 = 0;
            Double y2 = 3;
            Double y3 = 4;

            Console.Write("x1=");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2=");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x3=");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1=");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2=");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3=");
            y3 = Convert.ToDouble(Console.ReadLine());

            Double per = perim(x1, x2, x3, y1, y2, y3);
            Double sqr = Square(x1, x2, x3, y1, y2, y3);
        }
        public static Double perim(Double x1, Double x2, Double x3, Double y1, Double y2, Double y3)
        {
            Double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            Double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            Double P = a + b + c;
            Console.WriteLine("a:" + a);
            Console.ReadLine();
            Console.WriteLine("b:" + b);
            Console.ReadLine();
            Console.WriteLine("c:" + c);
            Console.ReadLine();

            Console.WriteLine("P:" + P);

            return P;
        }

        public static Double Square(Double x1, Double x2, Double x3, Double y1, Double y2, Double y3)
        {
            Double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            Double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            Console.WriteLine("a:" + a);
            Console.ReadLine();
            Console.WriteLine("b:" + b);
            Console.ReadLine();
            Console.WriteLine("c:" + c);
            Console.ReadLine();
            Double p = (a + b + c) / 2;

            Double S = 1;
            if (p >= 0)
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("S:" + p);
            return S;
        }
    }
}