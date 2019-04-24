using System;

namespace Calculate_Powers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
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
                run = Continue();

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

        static bool Continue()
        {
            Console.WriteLine("Continue (y/n)");
            string response = Console.ReadLine().ToLower();
            bool run = true;

            if (response == "n" || response == "no")
            {
                run = false;
            }
            else if (response == "y" || response == "yes")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("Invalid input please try again.");
                Continue();
            }


            return run;
        }
    }

}
