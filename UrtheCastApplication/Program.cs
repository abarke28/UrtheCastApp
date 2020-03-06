using System;

namespace UrtheCastApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine("Fibonacci number {0}: {1}", i, Fibonacci(i));
            }
        }

        public static int Fibonacci(int n)
        {
            //Calculate nth Fibonacci via rounding

            if (n <= 0) throw new ArgumentException("Argument must be integer > 0");

            double phi = (1 + Math.Sqrt(5)) / 2.0;

            return Convert.ToInt32(Math.Pow(phi, Convert.ToDouble(n-1)) / Math.Sqrt(5));
        }
    }
}
