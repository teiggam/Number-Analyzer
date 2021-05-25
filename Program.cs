using System;

namespace Number_Analyzer
{
    class Program
    { 
        static void Main(string[] args)
        {
            bool choice = true;

            string userName;
            Console.WriteLine("Hello! I'm Numberella! What is your name?");
            userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hi, " + userName + ", welcome to my number analyzer game!");

            while (choice == true)
            {
                Console.WriteLine("");
                Console.WriteLine(userName + ", please enter a whole number between 1 and 100.");
                string userInput = Console.ReadLine();
                Console.WriteLine();
                int input = int.Parse(userInput);
                if (input < 101 && input > 0)
                {
                    Console.WriteLine("Thanks so much, " + userName + ", for correctly entering a number between 1 and 100.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Oh," + userName + ", you and I both know that is not what I asked for... but I'll analyze it anyway, out of the kindness of my number-loving heart.");
                    Console.WriteLine();
                }

                if (input % 2 == 0)
                    if (input < 25)
                    {
                        Console.WriteLine("The number " + input + " is even and less than 25.");
                    }
                    else
                    {
                        Console.WriteLine("The number " + input + " is even.");
                    }
                else
                {
                    Console.WriteLine("The number " + input + " is odd.");
                }

                Console.WriteLine();
                Console.WriteLine("Want to check more numbers? (y/n): ");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "y")
                {
                    choice = true;
                    continue;
                }
                else if (answer.ToLower() == "n")
                {
                    Console.WriteLine();
                    Console.WriteLine("That's too bad, I was just getting warmed up!");
                    Console.WriteLine("Thanks and have a wonderful day " + userName + "!");
                    choice = false;
                    break;
                }
                else
                {
                    Console.WriteLine("I don't understand, let me ask again.");
                    continue;

                }

            }
        }
    }

}
