using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    public class Chain
    {
        // Creating a constructor with only one parameter, an integer, is provided
        public Chain(int age1) : this(age1, "Arsenal FC")
        {
            Console.WriteLine(age1 + " and your favourite football team is " + FavouriteTeam);
        }
        // Creating a constructor with only one parameter, a string, is provided
        public Chain(string favouriteTeam1) : this(31, favouriteTeam1)
        {
            Console.WriteLine(favouriteTeam1 + " and your age is " + Age);
        }
        // Creating a constructor with both parametera, a string and an integer, are provided
        public Chain(int age, string favouriteTeam)
        {
            Age = age;
            FavouriteTeam = favouriteTeam;
        }
        int Age { get; set; }
        string FavouriteTeam { get; set; }
    }
}
