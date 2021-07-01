using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Quests_to_complete1
{
    class ListOfQuests
    {
        public ListOfQuests()
        {
            Lists();
            static void Lists()
            {
                Console.Title = "LIST OF QUESTS";
                string[] quests = { "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT" };//THERE WILL BE A DEFAULT LIST OF QUESTS THAT WILL BE SHOWN AND IT WILL BE LISTED IN AN ARRAY//
                Console.Clear();
                Console.Title = "Quests To Complete";
                DateTime now = DateTime.Now;
                Console.WriteLine(now.ToString());
                Console.WriteLine("\nPlease choose a letter below to fill...");//lists of quests are shown below[DEFAULT QUESTS]
                Console.WriteLine("------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("A." + quests[0]);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("B." + quests[1]);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("C." + quests[2]);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("D." + quests[3]);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("E." + quests[4]);
                Console.ResetColor();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Do you want add or edit a quest?");//The user will be asked if he/she wants to modify the default set of quests. //The user will be supported with heaps of choices below
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Type the letter of the line to put your quest.");
                Console.WriteLine("You can also type 'exit' or click the 'X' button in the upper right panel if you want to quit the program.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("(if you close the program, all of the quests that you added will be removed)");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("(example: A,a )\n");
                Console.ResetColor();
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("(Please enter a valid letter)");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("(example: A,a )");
                    Console.ResetColor();
                    Console.Write("Command:"); command1 = Console.ReadLine().ToLower(); //THE USER WILL BE ASKED REPEATEDLY TO TYPE THE SPECIFIC LETTER OF QUEST"
                }
                if (command1 == "exit")
                {
                    EXITPANEL EXIT = new EXITPANEL(); //When the user chose to exit the program, he will be moved into a new class which will allow the user to ge out of the program.
                }


                if (command1 == "a")
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Quest A:"); Console.WriteLine(quests[0] + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("(comment 'delete' if you want to remove/delete the quest or comment 'edit' if you want to edit or replace the quest)\a");
                    Console.WriteLine("(or if you want to go back to your quests, comment 'mainmenu'.)\n");
                    Console.ResetColor();
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string mainmenu = "mainmenu";
                    string remove = "delete";
                    string edit = "edit";

                    while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit && commandanswer1 != exit)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("(Please comment a valid command)");
                        Console.ResetColor();
                        Console.Write("Command:"); commandanswer1 = Console.ReadLine().ToLower();
                    }
                    //
                    //
                    //  
                    if (commandanswer1 == "mainmenu")
                    {
                        Console.Clear();
                        Lists();
                    }
                    else if (commandanswer1 == "delete")
                    {
                        DeletedQuestA0 A0 = new DeletedQuestA0();
                    }
                    else if (commandanswer1 == "edit")
                    {
                        Console.Clear();
                        UpdatedQuests1 A0 = new UpdatedQuests1();
                    }


                }

                if (command1 == "b")
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Quest B:"); Console.WriteLine(quests[1] + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("(comment 'remove' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest\a");
                    Console.WriteLine("(or if you want to go back to your quests, comment 'mainmenu'.)\n");
                    Console.ResetColor();
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string mainmenu = "mainmenu";
                    string remove = "remove";
                    string edit = "edit";
                    while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("(Please comment a valid command)");
                        Console.ResetColor();
                        Console.Write("Command:"); commandanswer1 = Console.ReadLine().ToLower();
                    }
                    //
                    //
                    //
                    if (commandanswer1 == "mainmenu")
                    {
                        Console.Clear();
                        MainProgram Main1 = new MainProgram();
                    }
                    else if (commandanswer1 == "remove")
                    {
                        File.Delete(quests[1]);
                        Console.WriteLine("Command Complete");
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        MainProgram Main1 = new MainProgram();
                    }
                    else if (commandanswer1 == "edit")
                    {
                        Console.Clear();
                        UpdatedQuests2 A0 = new UpdatedQuests2();
                    }
                }
                if (command1 == "c")
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Quest C:"); Console.WriteLine(quests[2] + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("(comment 'remove' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest\a");
                    Console.WriteLine("(or if you want to go back to your quests, comment 'mainmenu'.)\n");
                    Console.ResetColor();
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string mainmenu = "mainmenu";
                    string remove = "remove";
                    string edit = "edit";
                    while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("(Please comment a valid command)");
                        Console.ResetColor();
                        Console.Write("Command:"); commandanswer1 = Console.ReadLine().ToLower();
                    }
                    //
                    //
                    //
                    if (commandanswer1 == "mainmenu")
                    {
                        Console.Clear();
                        MainProgram Main1 = new MainProgram();
                    }
                    else if (commandanswer1 == "remove")
                    {
                        File.Delete(quests[2]);
                        Console.WriteLine("Command Complete");
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        MainProgram Main1 = new MainProgram();
                    }
                    else if (commandanswer1 == "edit")
                    {
                        Console.Clear();
                        UpdatedQuests3 A2 = new UpdatedQuests3();
                    }
                }
                if (command1 == "d")
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Quest D:"); Console.WriteLine(quests[3] + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("(comment 'remove' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest\a");
                    Console.WriteLine("(or if you want to go back to your quests, comment 'mainmenu'.)\n");
                    Console.ResetColor();
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string mainmenu = "mainmenu";
                    string remove = "remove";
                    string edit = "edit";
                    while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("(Please comment a valid command)");
                        Console.ResetColor();
                        Console.Write("Command:"); commandanswer1 = Console.ReadLine().ToLower();
                    }
                    //
                    //
                    //
                    if (commandanswer1 == "mainmenu")
                    {
                        Console.Clear();
                        MainProgram Main1 = new MainProgram();
                    }
                    else if (commandanswer1 == "remove")
                    {
                        File.Delete(quests[3]);
                        Console.WriteLine("Command Complete");
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        MainProgram Main1 = new MainProgram();
                    }
                    else if (commandanswer1 == "edit")
                    {
                        Console.Clear();
                        UpdatedQuests4 A0 = new UpdatedQuests4();
                    }
                }
                if (command1 == "e")
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Quest E:"); Console.WriteLine(quests[4] + "\n");
                    Console.WriteLine("(comment 'remove' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest\a");
                    Console.WriteLine("(or if you want to go back to your quests, comment 'mainmenu'.)\n");
                    Console.ResetColor();
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string mainmenu = "mainmenu";
                    string remove = "remove";
                    string edit = "edit";
                    while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("(Please comment a valid command)");
                        Console.ResetColor();
                        Console.Write("Command:"); commandanswer1 = Console.ReadLine();
                    }
                    //
                    //
                    //
                    if (commandanswer1 == "mainmenu")
                    {
                        Console.Clear();
                        MainProgram Main1 = new MainProgram();
                    }
                    else if (commandanswer1 == "remove")
                    {
                        File.Delete(quests[4]);
                        Console.WriteLine("Command Complete");
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        MainProgram Main1 = new MainProgram();
                    }
                    else if (commandanswer1 == "edit")
                    {
                        Console.Clear();
                        UpdatedQuests5 A0 = new UpdatedQuests5();
                    }
                }
            }
        }
    }
}
