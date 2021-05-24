using System;

namespace Number_Analyzer
{
    class Program
    { 
        static void Main(string[] args)
        {
            bool choice = true;

            string userName;
            Console.WriteLine("Hello! What is your name?");
            userName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Hi, " + userName + ", welcome to the number analyzer game!");

            while (choice)
            {
                int a;


                Console.WriteLine("");
                Console.WriteLine(userName + ", please enter a whole number between 1 and 100.");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (a < 101 && a > 0)
                {
                    Console.WriteLine("Thanks so much, " + userName + ", for entering a number between 1 and 100.");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("That is not a number between 1 and 100, " + userName + ", but I can still analyze the number for you!");
                    Console.WriteLine("");
                }

                if (a % 2 == 0)
                    if (a < 25)
                    {
                        Console.WriteLine(a + ", even and less than 25.");
                    }
                    else
                    {
                        Console.WriteLine(a + ", even.");
                    }

                else
                    Console.WriteLine(a + ", odd.");



                Console.WriteLine("");
                Console.WriteLine("Want to check more numbers? (y/n): ");


                if (Console.ReadLine() == "n")
                    choice = false;

            }
            Console.WriteLine("");
            Console.WriteLine("Thanks, have a wonderful day" + userName + "!");
        }
    }

}
