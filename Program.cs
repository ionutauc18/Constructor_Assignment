using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a const variable
            const string const1 = "Your favourite football team is: ";
            const string const2 = "Your age is: ";
            Console.WriteLine("Enter your favourite football team or your age: ");
            // Creating a variable using the var keyword
            var answer = Console.ReadLine();
            if (int.TryParse(answer, out int x))
            {
                Console.WriteLine(const2);
                Chain newChain = new Chain(x);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(const1);
                Chain newChain = new Chain(answer);
                Console.ReadLine();
            }
        }
    }
}
