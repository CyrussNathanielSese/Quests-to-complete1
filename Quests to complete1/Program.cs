using System;
using System.IO;

namespace Quests_to_complete1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Quests To Complete!");
            Console.WriteLine("(press any key to continue)\n");
            Console.ReadKey();
            Console.WriteLine("Can I get your name?"); //the user will be asked to comment his/her name.

            Console.Write("Name:"); string name1 = Console.ReadLine();
            Console.WriteLine("--------------------------------------------");
            intro1();


        }
        public static void intro1()
        {
            string quests1 = "Do the Dishes";
            string quests2 = "Do the Dishes";
            string quests3 = "Do the Dishes";

            File.WriteAllText("filename.txt", quests1);
            File.WriteAllText("filename.txt", quests2);
            File.WriteAllText("filename.txt", quests3);


            Console.WriteLine("Do you want to look to your Quests for today?");
            Console.Write("Answer:"); string response1 = Console.ReadLine().ToLower();
            Console.WriteLine("--------------------------------------------");
            if (response1 == "yes")//if the user say 'yes', the program will show the quests below
            {
                Console.WriteLine("These are your Quests for today...");//lists of quests are shown below
                Console.WriteLine("A." +quests1);
                Console.WriteLine("B." +quests2);
                Console.WriteLine("C." +quests3);
                Console.WriteLine("Do you want to edit your quests?");
                Console.WriteLine("Press the letter of the quest you want to edit or delete");
                Console.WriteLine("(example: A,a )");
                Console.Write("Command:"); string command1 = Console.ReadLine().ToLower();
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------");
                if (command1 == "a")
                {
                    Console.WriteLine("What do you want to do to this Quest?");
                    Console.WriteLine("(comment 'remove' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest\a");
                    Console.WriteLine("(or if you want to go back to your quests, comment 'mainmenu'.)");
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string mainmenu = "mainmenu";
                    string remove = "remove";
                    string edit = "edit";
                    while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit)
                    {
                        Console.WriteLine("Please comment a valid command");
                        Console.Write("Command:"); commandanswer1 = Console.ReadLine();
                    }
                    //
                    //
                    //
                    if (commandanswer1 == "mainmenu")
                    {
                        Console.Clear();
                        intro1();
                    }
                    else if (commandanswer1 == "remove")
                    {
                        File.Delete(quests1);
                        Console.WriteLine("Command Complete");
                        Console.WriteLine("(press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        intro1();
                    }
                }
                else if (command1 == "b")
                {

                }
                else if (command1 == "c")
                {

                }
                
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
        }
    }
}
