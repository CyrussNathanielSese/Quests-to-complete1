using System;
using System.IO;
using System.Collections.Generic;

namespace Quests_to_complete1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            //INTRODUCTION//
            Console.WriteLine("Welcome to your Quests To Complete!");
            Console.WriteLine("(press any key to continue)");
            Console.WriteLine("--------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("Can I get your name?"); //the user will be asked to comment his/her name.
            Console.Write("Response:"); string NameResponse1 = Console.ReadLine().ToLower();
            string nameResponse = "yes";
            string nameResponse2 = "no";
            while (NameResponse1 != nameResponse && NameResponse1 != nameResponse2)
            {
                Console.WriteLine("please enter a correct command");
                Console.WriteLine("(please type 'yes' or 'no' to continue)");
                Console.Write("Response:"); NameResponse1 = Console.ReadLine().ToLower();
            }
            if (NameResponse1 == "yes")
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Please enter your name below...");
                //THE USER WILL BE ABLE TO PUT HIS/HER NAME BELOW//
                Console.Write("Name:"); string name1 = Console.ReadLine();
                Console.WriteLine("Thank you for putting your name! Now you can procceed to your Quests!");
                Console.WriteLine("--------------------------------------------");
                intro1();
            }
            else if (NameResponse1 == "no")
            {
                Console.Clear();
                intro1();
            }
        }
        public static void intro1()
        {
            string[] quests = { "Do the Dishes", "Clean the House", "", "", "", };
            //THERE WILL BE A DEFAULT LIST OF QUESTS THAT WILL BE SHOWN//
            //THE DEFAULT QUESTS ARE LISTED IN AN ARRAY


            Console.WriteLine("Do you want to look to your Quests for today?");
            Console.WriteLine("(please type 'yes' or 'no' to continue)");//There will be two choices for this part
            Console.Write("Answer:"); string response1 = Console.ReadLine().ToLower();
            string yes1 = "yes";
            string no1 = "no";

            while (response1 != yes1 && response1 != no1)//If the user type anything else aside from 'yes' or 'no', he/she will be asked to write a right command.
            {
                Console.WriteLine("please enter a correct command");
                Console.WriteLine("(please type 'yes' or 'no' to continue)");
                Console.Write("Response:"); response1 = Console.ReadLine().ToLower();
                //THIS LOOP WILL BE REPEATED ONCE THE USER DID NOT TYPE 'YES' OR 'NO'//
            }


            if (response1 == "yes")//if the user say 'yes', the program will show the quests below
            {
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("What do you want to do to these Quests?\n");
                Console.WriteLine("These are your Quests for today...");//lists of quests are shown below[DEFAULT QUESTS]
                Console.WriteLine("A." + quests[0]);
                Console.WriteLine("B." + quests[1]);
                Console.WriteLine("C." + quests[2]);
                Console.WriteLine("D." + quests[3]);
                Console.WriteLine("E." + quests[4]);
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
                while (command1 != a && command1 != b && command1 != c && command1 != d && command1 != e)
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
                    Console.Write("Quests: A."); Console.WriteLine(quests[0] + "\n");
                    Console.WriteLine("(comment 'remove' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest)\a");
                    Console.WriteLine("(or if you want to go back to your quests, comment 'mainmenu'.)");
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string mainmenu = "mainmenu";
                    string remove = "remove";
                    string edit = "edit";
                    while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit)
                    {
                        Console.WriteLine("Please comment a valid command");
                        Console.Write("Command:"); commandanswer1 = Console.ReadLine().ToLower();
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
                        File.Delete(quests[0]);
                        Console.WriteLine("Command Complete");
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        intro1();
                    }
                    else if (commandanswer1 == "edit")
                    {
                        Console.WriteLine("Please enter your new quest below...");
                        Console.Write("New Quest:"); quests[0] = Console.ReadLine();
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("Edit Complete");
                        Console.Write("New Quest:"); Console.WriteLine(quests[0]);
                        Console.WriteLine("(press enter to continue)");
                    }

                }
                ///////     ///////    /////////   //////    //     //   //////              //////////  //   //   //////  /////
                //   //     //        //  //  //   //  //     //   //    //                      //      ///////     //    //
                /////       ///        // //  //   //  //      // //     ///                     //      //   //     //      ///
                //  ///     ////////   //     //   //////       ///      ///////                 //      //   //   /////  /////
                if (command1 == "b")
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests: B."); Console.WriteLine(quests[1] + "\n");
                    Console.WriteLine("(comment 'remove' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest\a");
                    Console.WriteLine("(or if you want to go back to your quests, comment 'mainmenu'.)");
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string mainmenu = "mainmenu";
                    string remove = "remove";
                    string edit = "edit";
                    while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit)
                    {
                        Console.WriteLine("Please comment a valid command");
                        Console.Write("Command:"); commandanswer1 = Console.ReadLine().ToLower();
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
                        File.Delete(quests[1]);
                        Console.WriteLine("Command Complete");
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        intro1();
                    }
                    else if (commandanswer1 == "edit")
                    {
                        Console.WriteLine("Please enter your new quest below...");
                        Console.Write("New Quest:"); quests[1] = Console.ReadLine();
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("Edit Complete");
                        Console.Write("New Quest:"); Console.WriteLine(quests[1]);
                        Console.WriteLine("(press enter to continue)");
                        intro1();
                    }
                }
                if (command1 == "c")
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests: C."); Console.WriteLine(quests[2] + "\n");
                    Console.WriteLine("(comment 'remove' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest\a");
                    Console.WriteLine("(or if you want to go back to your quests, comment 'mainmenu'.)");
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string mainmenu = "mainmenu";
                    string remove = "remove";
                    string edit = "edit";
                    while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit)
                    {
                        Console.WriteLine("Please comment a valid command");
                        Console.Write("Command:"); commandanswer1 = Console.ReadLine().ToLower();
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
                        File.Delete(quests[2]);
                        Console.WriteLine("Command Complete");
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        intro1();
                    }
                    else if (commandanswer1 == "edit")
                    {
                        Console.WriteLine("Please enter your new quest below...");
                        Console.Write("New Quest:"); quests[2] = Console.ReadLine();
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("Edit Complete");
                        Console.Write("New Quest:"); Console.WriteLine(quests[2]);
                        Console.WriteLine("(press enter to continue)");
                        intro1();
                    }
                }
                if (command1 == "d")
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests: D."); Console.WriteLine(quests[3] + "\n");
                    Console.WriteLine("(comment 'remove' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest\a");
                    Console.WriteLine("(or if you want to go back to your quests, comment 'mainmenu'.)");
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string mainmenu = "mainmenu";
                    string remove = "remove";
                    string edit = "edit";
                    while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit)
                    {
                        Console.WriteLine("Please comment a valid command");
                        Console.Write("Command:"); commandanswer1 = Console.ReadLine().ToLower();
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
                        File.Delete(quests[3]);
                        Console.WriteLine("Command Complete");
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        intro1();
                    }
                    else if (commandanswer1 == "edit")
                    {
                        Console.WriteLine("Please enter your new quest below...");
                        Console.Write("New Quest:"); quests[3] = Console.ReadLine();
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("Edit Complete");
                        Console.Write("New Quest:"); Console.WriteLine(quests[3]);
                        Console.WriteLine("(press enter to continue)");
                        intro1();
                    }
                }
                if (command1 == "e")
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests: E."); Console.WriteLine(quests[4] + "\n");
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
                        File.Delete(quests[4]);
                        Console.WriteLine("Command Complete");
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        intro1();
                    }
                    else if (commandanswer1 == "edit")
                    {
                        Console.WriteLine("Please enter your new quest below...");
                        Console.Write("New Quest:"); quests[4] = Console.ReadLine().ToLower();
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("Edit Complete");
                        Console.Write("New Quest:"); Console.WriteLine(quests[4]);
                        Console.WriteLine("(press enter to continue)");
                        intro1();
                    }
                }
            }

            else if (response1 == "no")

            //THE PROGRAM WILL ASK THE PERSON IF HE/SHE WANTS TO QUIT THE PROGRAM//
            {
                Console.Clear();
                Console.WriteLine("Do you want to exit the program?");
                Console.WriteLine("(please type 'yes' or 'no' to continue)");
                Console.Write("Response:"); string response2 = Console.ReadLine().ToLower();

                string yes2 = "yes";
                string no2 = "no";

                while (response2 != yes2 && response2 != no2)
                {
                    Console.WriteLine("please enter a correct command");
                    Console.WriteLine("(please type 'yes' or 'no' to continue)");
                    Console.Write("Response:"); response2 = Console.ReadLine().ToLower();
                }

                if (response2 == "yes")
                {
                    exitpanel();
                }

                else if (response2 == "no")
                {
                    Console.Clear();
                    intro1();
                }
            }
        }




        //THESE STATEMENTS BELOW WILL BE SHOWN WHEN THE USER CHOSE TO QUIT THE PROGRAM//
        public static void exitpanel()
        {
            Console.Clear();
            Console.WriteLine("OK, have a good day :)");
            Console.WriteLine("(press any key to continue)");
        }
    }
}
