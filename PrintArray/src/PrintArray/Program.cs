using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] someInts = { 1, 1, 2, 3, 5, 8 };
            foreach (int num in someInts)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
