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
            // Initialize greeting to ""
            string greeting = "";

            // Prompt for name with "What is your name?"
            Console.Write("What is your name?");
            name = Console.ReadLine();

            // Convert greeting to "Hello," + name + "nice to meet you!"
            greeting = "Hello," + name + "nice to meet you!";

            // Display "Hello, " + name + "nice to meet you!"
            Console.WriteLine("Hello, " + name + " nice to meet you!");

            // End
            Console.ReadLine();
        }
    }
}
