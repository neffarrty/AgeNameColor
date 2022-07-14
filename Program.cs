using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeNameColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = Console.ReadLine();
            Console.Write("Enter your favourite color: ");
            var favColor = Console.ReadLine();

            Console.WriteLine($"Well, you'll be surprised, but your name is {name}, you're {age} years old and you prefer wearing {favColor} T-shirt");
            
            Console.ReadKey();
        }
    }
}
