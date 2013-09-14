using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Random r = new Random();
            int a, b, c, d, e, f, g, h;

            a = r.Next(1, 1000);
            b = r.Next(1, 1000);
            c = r.Next(1, 1000);
            d = r.Next(1, 1000);
            e = r.Next(1, 1000);
            f = r.Next(1, 1000);
            g = r.Next(1, 1000);
            h = r.Next(1, 1000);

            //simple example
            PrintMaxFormatted(a, b, c);

            List<int> numbers = new List<int>() {a, b, c, d, e, f, g, h};
            PrintMaxFormatted(numbers);

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();

        }

        private static void PrintMaxFormatted(List<int> numbers)
        {
            int max = 0;
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            Console.Write("The max of:");
            foreach (var number in numbers)
            {
                Console.Write("{0}, ", number);
            }
            Console.WriteLine("is: {0}", max);


        }



        public static void PrintMaxFormatted(int a, int b, int c)
        {
            int max = Math.Max(a, b);
            max = Math.Max(max, c);

            Console.WriteLine("The Max of {0}, {1}, {2} is {3}", a, b, c, max);

        }
    }
}

