using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("How many miles have you driven?");
                double miles = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("How many gallons of gas did that take?");
                double gallons = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("You got " + (miles / gallons) + " mpg.");

                Console.WriteLine("Would you like to enter more data?");
                var userChoice = Console.ReadKey().KeyChar;
                Console.WriteLine("");
                if (char.ToLower(userChoice) != 'y') break;
            }
        }
    }
}
