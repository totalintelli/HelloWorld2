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
            string nation = "";
            Dictionary<string, string> firstGreetings = new Dictionary<string, string>();
            firstGreetings.Add("한국", "안녕하세요, ");
            firstGreetings.Add("USA", "Hello, ");
            firstGreetings.Add("France", "Bonjour, ");
            Dictionary<string, string> secondGreetings = new Dictionary<string, string>();
            secondGreetings.Add("한국", "님, 매우 반갑습니다.");
            secondGreetings.Add("USA", ", nice to meet you!");
            secondGreetings.Add("France", ", très gentil de vous rencontrer!");

            // Prompt for name with "What is your name?"
            Console.Write("What is your name?");
            name = Console.ReadLine();
            Console.Write("Where are you from?");
            nation = Console.ReadLine();

            Console.WriteLine(firstGreetings[nation] + name + secondGreetings[nation]);

            // End
            Console.ReadLine();
        }
    }
}
