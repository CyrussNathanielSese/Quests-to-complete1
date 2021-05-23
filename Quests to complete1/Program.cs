using System;

namespace Quests_to_complete1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Quests Tp Complete!");
            Console.WriteLine("(press any key to continue)");
            Console.ReadKey();
            Console.Clear();
            intro1();


        }
        public static void intro1()
        {
            Console.WriteLine("Do you want to look to your Quests for today?");
            Console.Write("Answer:"); string response1 = Console.ReadLine().ToLower();
            Console.WriteLine("______________________________________________________");
            if (response1 == "yes")
            {
                Console.WriteLine("");
            }
            else

            {
                Console.Clear();
                Console.WriteLine("Do you want to exit the program?");
                Console.Write("Response:"); string response2 = Console.ReadLine().ToLower();
                if (response2 == "yes")
                {
                    exitpanel();
                }

                else
                {
                    Console.Clear();
                    intro1();
                }
            }
        }
        public static void exitpanel()
        {
            Console.Clear();
            Console.WriteLine("OK, have a good day :)");
            Console.WriteLine("(press any key to continue)");
            Console.ReadKey();
        }
    }
}
