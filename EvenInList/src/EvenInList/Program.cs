using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvenInList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 6524187 };
            List<int> evens = new List<int>();
            
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                    {
                    evens.Add(number);
                }
            }
            Console.WriteLine(evens);
            Console.ReadLine();
        }
    }
}
