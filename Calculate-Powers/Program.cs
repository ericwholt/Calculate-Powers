using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Powers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Learn your squares cubes!");
                Console.Clear();
                //Prompt user to enter an integer
                Console.WriteLine("Enter an integer: ");
                int userInput = int.Parse(Console.ReadLine());

                //Display a table of squares and cubes from 1 to the value entered.
                Console.WriteLine(String.Format("{0,-11}{1,-11}{2,-11}", "Number", "Squared", "Cubed"));
                Console.WriteLine("{0,-11}{1,-11}{2,-11}", "======", "=======", "=====");
                for (int i = 1; i <= userInput; i++)
                {
                    
                    int squared = CalculateSquared(i);
                    int cubed = CalculateCube(i);
                    if (squared < 0 || cubed < 0)
                    {
                        Console.WriteLine("int Max Value reached");
                        break;
                    }
                    Console.WriteLine("{0,-11}{1,-11}{2,-11}", i, squared, cubed);
                }
                Console.WriteLine("Continue (y/n)");
                string response = Console.ReadLine().ToLower();
                if (response == "n" || response == "no")
                {
                    break;
                }

            }
            Console.Clear();
            Console.WriteLine("Goodbye!");
            Console.Write("Press Any Key...");
            Console.ReadKey();//Keep console from closing immediately
        }
        static int CalculateCube(int value)
        {
            return value * value * value;
        }
        static int CalculateSquared(int value)
        {
            return value * value;
        }
    }

}
