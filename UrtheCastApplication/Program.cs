using System;
using System.Collections.Generic;
using System.Linq;

namespace UrtheCastApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1:");            
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Fibonacci number {0}: {1}", i, Fibonacci(i));
            }

            Console.WriteLine("Question 2:");
            var list = ListBuilderSorter(new List<string> { "one", "two", "three" }, new List<string> { "one", "two", "five", "six" }, new List<string> { "two", "five" });
            
            foreach(string s in list)
            {
                Console.WriteLine(s);
            }
        }

        public static int Fibonacci(int n)
        {
            //Calculates nth Fibonacci via rounding. Considering F0 = 0

            if (n < 0) throw new ArgumentException("Argument must be integer >= 0");

            double phi = (1 + Math.Sqrt(5)) / 2.0;

            return Convert.ToInt32(Math.Pow(phi, Convert.ToDouble(n)) / Math.Sqrt(5));
        }

        public static List<string> ListBuilderSorter(IEnumerable<string> original, IEnumerable<string> add, IEnumerable<string> remove)
        {
            //Returns new list of strings that contains strings present in original, plus strings in add list, 
            //minus strings in remove list, ordered by length then reverse alphabetically. Implemented with LINQ

            return new List<string>(original).Concat(add).Distinct().Except(remove).OrderByDescending(s => s.Length).ThenByDescending(s => s).ToList();
        }
    }
}
