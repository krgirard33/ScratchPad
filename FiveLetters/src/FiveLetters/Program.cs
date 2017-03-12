using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveLetters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> lotsofwords = new List<string> { "I", "like", "big", "butts", "and", "I", "cannot", "lie" };
            List<string> fiveplus = new List<string>();

            foreach (var word in lotsofwords)
            {
                if (word.Length > 4)
                {
                    fiveplus.Add(word);
                    Console.WriteLine(word);
                }

            }
            
            Console.ReadLine();
        }
    }
}
