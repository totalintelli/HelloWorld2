using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // GreeingApp
            // Initialize name to ""
            string name = "";

            // Prompt for name with "What is your name?"
            Console.Write("What is your name?");
            name = Console.ReadLine();

            // Display "Hello, " + name + "nice to meet you!"
            Console.WriteLine("Hello, " + name + ", nice to meet you!");

            // End
            Console.ReadLine();
        }
    }
}
