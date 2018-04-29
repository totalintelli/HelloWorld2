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

            if (name == "용단")
            {
                Console.WriteLine("안녕하세요 " + name + "님 매우 반갑습니다!");
            }
            else if (name == "Sophie")
            {
                Console.WriteLine("Bonjour " + name + ", très gentil de vous rencontrer!");
            }
            else
            {
                // Display "Hello, " + name + "nice to meet you!"
                Console.WriteLine("Hello, " + name + ", nice to meet you!");
            }

            // End
            Console.ReadLine();
        }
    }
}
