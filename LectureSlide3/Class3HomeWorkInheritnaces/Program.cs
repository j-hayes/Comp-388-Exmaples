using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3HomeWorkInheritnaces
{
    class Program
    {
        private static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Please Enter a number to get some information about it \n Enter exit to exit:");
                string input = Console.ReadLine();
                if (input == "exit")
                {
                    running = false;
                }
                else
                {

                    double numberToCheck = TakeInput(input);

                    if (numberToCheck < 0)
                    {
                        Console.WriteLine("invalid input please enter a positive number");
                    }
                    else
                    {
                        Square square = new Square(numberToCheck);
                        Circle circle = new Circle(numberToCheck);

                        Console.WriteLine("the area of a square with side lenghts of {0} is {1}",numberToCheck,square.getArea());
                        Console.WriteLine("the area of a circle with a radius of {0} is {1}",numberToCheck,circle.getArea());

                    }
                }
            }
        }

        private static double TakeInput(string input)
        {
            double numberToCheck = 0;
            try
            {
                numberToCheck = Convert.ToDouble(input);
            }
            catch (Exception e)
            {
                return -1;
            }
            return numberToCheck;
        }
    }
}
