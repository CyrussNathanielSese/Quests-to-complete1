using System;
using System.IO;
using System.Collections.Generic;

namespace Quests_to_complete1
{
    class MainProgram
    {
        
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            //INTRODUCTION//
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Welcome to Quests To Complete!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What can you do on this application?\nThis App will be able to put your quests or things to do while you are using your computer!\nJust simply put things that ");
            Console.WriteLine("(press any key to continue)");
            Console.WriteLine("--------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("Can I get your name?"); //the user will be asked by the program if he/she wants to comment his/her name.
            Console.WriteLine("(leave this panel blank if you do not want to put your name inside of the program)"); Console.WriteLine("\nPress enter after you put your name to continue");
            Console.Write("Response:"); Console.ReadLine();

            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("--------------------------------------------");
            intro1();
        }
        public static void intro1()
        {
            string[] quests = { "nothing", "nothing2", "nothing3", "nothing4", "nothing5" };
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
                Console.WriteLine("These are your Quests for today...");//lists of quests are shown below[DEFAULT QUESTS]
                Console.WriteLine("A." + quests[0]);
                Console.WriteLine("B." + quests[1]);
                Console.WriteLine("C." + quests[2]);
                Console.WriteLine("D." + quests[3]);
                Console.WriteLine("E." + quests[4]);
                Console.WriteLine("Do you want to edit your quests?");
                Console.WriteLine("Type the letter of the quest you want to edit or delete.");
                Console.WriteLine("You can also type 'exit' the program if you want to quit the program.");
                Console.WriteLine("(example: A,a )\n");
                Console.Write("Command:"); string command1 = Console.ReadLine().ToLower();

                string a = "a";
                string b = "b";
                string c = "c";
                string d = "d";
                string e = "e";
                string exit = "exit";
                //THE USER NEEDS TO TYPE THE EXACT LETTER OF THE QUEST IN ORDER TO GO TO THAT QUESTS'S COMMANDS//
                while (command1 != a && command1 != b && command1 != c && command1 != d && command1 != e && command1 != exit)
                {
                    Console.WriteLine("(Please enter a valid letter)");
                    Console.Write("Command:"); command1 = Console.ReadLine().ToLower(); //THE USER WILL BE ASKED REPEATEDLY TO TYPE THE SPECIFIC LETTER OF QUEST"
                }
                if (command1 == "exit")
                {
                    EXITPANEL EXIT = new EXITPANEL(); //When the user chose to exit the program, he will be moved into a new class which will allow the user to ge out of the program.
                }


                if (command1 == "a")
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests:A. "); Console.WriteLine(quests[0] + "\n");
                    Console.WriteLine("(comment 'delete' if you want to remove/delete the quest or comment 'edit' if you want to edit or replace the quest)\a");
                    Console.WriteLine("(or if you want to go back to your quests, comment 'mainmenu'.)");
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string mainmenu = "mainmenu";
                    string remove = "delete";
                    string edit = "edit";
                    
                    while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit && commandanswer1 != exit)
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
                    else if (commandanswer1 == "delete")
                    {
                        DeletedQuestA0 A0 = new DeletedQuestA0();
                    }
                    else if (commandanswer1 == "edit")
                    { 
                        UpdatedQuestA0 A0 = new UpdatedQuestA0();
                    }


                }

                if (command1 == "b")
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests:B. "); Console.WriteLine(quests[1] + "\n");
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
                        UpdatedQuestB1 B1 = new UpdatedQuestB1();
                    }
                }
                if (command1 == "c")
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests:C. "); Console.WriteLine(quests[2] + "\n");
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
                        UpdatedQuestC2 C2 = new UpdatedQuestC2();
                    }
                }
                ///////     ///////    /////////   //////    //     //   //////              //////////  //   //   //////  /////
                //   //     //        //  //  //   //  //     //   //    //                      //      ///////     //    //
                /////       ///        // //  //   //  //      // //     ///                     //      //   //     //      ///
                //  ///     ////////   //     //   //////       ///      ///////                 //      //   //   /////  /////
                if (command1 == "d")
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests:D. "); Console.WriteLine(quests[3] + "\n");
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
                        UpdatedQuestD3 D3 = new UpdatedQuestD3();
                    }
                }
                if (command1 == "e")
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests:E. "); Console.WriteLine(quests[4] + "\n");
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
                        UpdatedQuestE4 E4 = new UpdatedQuestE4();
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
                    EXITPANEL EXIT = new EXITPANEL();
                }

                else if (response2 == "no")
                {
                    Console.Clear();
                    intro1();
                }
            }
        }
    }
}