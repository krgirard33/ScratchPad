using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What is the width? ");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the height? ");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The area of the rectangle is " + (height * width));
                // Console.ReadLine();

                Console.WriteLine("Would you like to continue? ");
                var userChoice = Console.ReadKey().KeyChar;
                Console.WriteLine("");
                if (char.ToLower(userChoice) !='y') break;
                
            }
        }
    }
}
