using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string molly = "";
            string ishere = "";
            string lotsofwords = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("Type in a set of letters/characters to look for");
            molly = Console.ReadLine();
            int seeking = lotsofwords.IndexOf(molly, StringComparison.CurrentCultureIgnoreCase);
            
            if (seeking > -1)
            {
                ishere = "true";
            }
            else
            {
                ishere = "false";
            }
                 
            Console.WriteLine("It is " + ishere + " that which you seek is here.");
            Console.ReadLine();

        }
    }
}
