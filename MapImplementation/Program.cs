using System;
using System.Collections.Generic;

namespace MapImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] numbers = new int[] { 1, 2, 3 };

            int[] result = Transformer(numbers, multiplier);

            Console.WriteLine(string.Format("{0}",string.Join("", result)));
            Console.ReadLine();
        }

        protected static int[] Transformer(IEnumerable<int> values, Func<int, int> theorem)
        {

            List<int> outcome = new List<int>();
            foreach (var item in values)
            {
                outcome.Add(theorem(item));
            }
            
            return outcome.ToArray();

            
        }

        protected static int multiplier(int a)
        {
            return a * 2;
        }
    }
}
