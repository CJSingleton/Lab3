using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSingleton_Lab3
{
    class Program
    {
        static void Main()
        {
            //Input
            string userInput = "y"; // This establishes the default condition for the while loop in which most of the program resides.
            

            Console.WriteLine("Please enter your name below:");// Adding a Username
            string name = Console.ReadLine();

            Start:// I got this idea from Stack Overflow, though they mention that it goes against best practices.
            while (userInput == "y")
            {
                int n;
                Console.WriteLine("Please enter a number between 1 and 100. Example: 45");
                n = int.Parse(Console.ReadLine());//user input
               

                if (n <= 0 || n > 100)//Check to ensure the user enters a valid number.
                {
                    Console.WriteLine($"This is an invalid entry.");
                    goto Start;//If the user enters an invalid number, they go back to the start.
                }
                
                //Processing & Output
                if ((n % 2) == 1)//First check
                {
                    Console.WriteLine($"{name}, your number ({n}) is odd.");
                }
                else
                {
                    if (n <= 25)//second check
                    {
                        Console.WriteLine($"{name}, your number is even and less than 25.");
                    }
                    else
                    {
                        if (n > 60)//third check
                        {
                            Console.WriteLine($"{name}, your number ({n}) is even.");
                        }
                        else
                        {
                            Console.WriteLine($"{name}, your number is even.");//everything not covered by the checks
                        }
                    }
                }

                Console.WriteLine("Would you like to continue? (y/n)?");
                userInput = Console.ReadLine().ToLower();//user input that is anything other than a "y" will break the while loop.
            }

        }
        
    }
}
