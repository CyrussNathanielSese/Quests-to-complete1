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
            Console.WriteLine("Please enter your name below...");

            Console.Write("Name:"); string name1 = Console.ReadLine();
            Console.WriteLine("--------------------------------------------");
            intro1();


        }
        public static void intro1()
        {
            string quests1 = "Do the Dishes";
            string quests2 = "Clean the House";
            string quests3 = "(empty quest)";
            string quests4 = "(empty quest)";
            string quests5 = "(empty quest)";

            

            Console.WriteLine("Do you want to look to your Quests for today?");
            Console.Write("Answer:"); string response1 = Console.ReadLine().ToLower();
            Console.WriteLine("--------------------------------------------");
            string yes1 = "yes";
            string no1 = "no";

            while (response1 != yes1 && response1 != no1)
            {
                Console.WriteLine("please enter a correct command");
                Console.Write("Response:"); response1 = Console.ReadLine().ToLower();
            }


            if (response1 == "yes")//if the user say 'yes', the program will show the quests below
            {
                Console.WriteLine("These are your Quests for today...");//lists of quests are shown below
                Console.WriteLine("A." + quests1);
                Console.WriteLine("B." + quests2);
                Console.WriteLine("C." + quests3);
                Console.WriteLine("D." + quests4);
                Console.WriteLine("E." + quests5);
                Console.WriteLine("Do you want to edit your quests?");
                Console.WriteLine("Press the letter of the quest you want to edit or delete.");
                Console.WriteLine("(example: A,a )\n");
                Console.Write("Command:"); string command1 = Console.ReadLine().ToLower();

                string a = "a";
                string b = "b";
                string c = "c";
                string d = "d";
                string e = "e";
                //THE USER NEEDS TO TYPE THE EXACT LETTER OF THE QUEST IN ORDER TO GO TO THAT QUESTS'S COMMANDS//
                while (command1 != a && command1 != b && command1 != c && command1 != d && command1  != e)
                {
                    Console.WriteLine("(Please enter a valid letter)");
                    Console.Write("Command:"); command1 = Console.ReadLine().ToLower(); //THE USER WILL BE ASKED REPEATEDLY TO TYPE THE SPECIFIC LETTER OF QUEST"
                }


                if (command1 == "a")
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests: A."); Console.WriteLine(quests1 + "\n");
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
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        intro1();
                    }
                }
                if (command1 == "b")
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests: B."); Console.WriteLine(quests2 + "\n");
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
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        intro1();
                    }
                }
                if (command1 == "c")
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests: C."); Console.WriteLine(quests3 + "\n");
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
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        intro1();
                    }
                }
                if (command1 == "d")
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests: D."); Console.WriteLine(quests4 + "\n");
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
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        intro1();
                    }
                }
                if (command1 == "e")
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests: E."); Console.WriteLine(quests5 + "\n");
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
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        intro1();
                    }
                }
            }

            else

            //THE PROGRAM WILL ASK THE PERSON IF HE/SHE WANTS TO QUIT THE PROGRAM//
            {
                Console.Clear();
                Console.WriteLine("Do you want to exit the program?");
                Console.Write("Response:"); string response2 = Console.ReadLine().ToLower();

                string yes2 = "yes";
                string no2 = "no";

                while (response2 != yes2 && response2 != no2)
                {
                    Console.WriteLine("please enter a correct command");
                    Console.Write("Response:"); response2 = Console.ReadLine().ToLower();
                }

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




        //THESE STATEMENTS WILL BE SHOWN WHEN THE USER CHOSE TO QUIT THE PROGRAM//
        public static void exitpanel()
        {
            Console.Clear();
            Console.WriteLine("OK, have a good day :)");
            Console.WriteLine("(press any key to continue)");
        }
    }
}