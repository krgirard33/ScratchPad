using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradebookDict
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> students =
                new Dictionary<int, string>();
            int studentID = 1;
            string newStudent;
            StringBuilder classRoster = new System.Text.StringBuilder();

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's grade
                    students.Add(studentID, newStudent);
                    studentID = ++studentID;
                    classRoster.Append(newStudent);
                    classRoster.Append(", ");
                }
            }
            while (newStudent != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");
            /* foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine("(" + student.Key + ") " + student.Value);
            }    
            */
            Console.WriteLine(classRoster);

            Console.ReadLine();
        }
    }
}