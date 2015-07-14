using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_JustinExpIT
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName = null;
            String lastName = null;

            Console.WriteLine("What is your first name? ");
            firstName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is your last name? ");
            lastName = Console.ReadLine();
            Console.WriteLine();


            //Write to standard output the following string: "firstName lastName".
            Console.Write(firstName);   // Writes first name.
            Console.Write(" ");         // Adds a space.
            Console.Write(lastName);    // Writes last name.
            Console.WriteLine();        // Ends the line.

            //Write to standard output the following string: "firstName lastName".
            Console.Write(lastName);   // Writes last name.
            Console.Write(", ");         // Adds a comma and a space.
            Console.Write(firstName);    // Writes first name.
            Console.WriteLine();        // Ends the line.

            Console.Read();
        }
    }
}