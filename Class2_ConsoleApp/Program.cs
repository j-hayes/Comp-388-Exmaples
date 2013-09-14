using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2_ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<String> _reasons = new List<string>();


            Console.WriteLine("Programming Can Be Fun!");


            Console.WriteLine("Tell Me a reason Why you think Programming is fun");

            _reasons.Add(Console.ReadLine());
            Console.WriteLine("Tell Me another reason Why you think Programming is fun");
            _reasons.Add(Console.ReadLine());
            Console.WriteLine("Tell Me yet another reason Why you think Programming is fun");
            _reasons.Add(Console.ReadLine());
            Console.WriteLine("The Reasons that Programming is fun are:");

            foreach (string s in _reasons)
            {
                Console.WriteLine(s);


            }
            Console.WriteLine("Please Click Enter to Exit");
            Console.ReadLine();
        }
    }
}
