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
                string[] quests = { "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT" };
                Console.Clear();
                Console.WriteLine("These are your Quests for today...");//lists of quests are shown below[DEFAULT QUESTS]
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A." + quests[0]);
                Console.WriteLine("B." + quests[1]);
                Console.WriteLine("C." + quests[2]);
                Console.WriteLine("D." + quests[3]);
                Console.WriteLine("E." + quests[4]);
                Console.ResetColor();
                Console.WriteLine("Do you want to edit your quests?");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Type the letter of the quest you want to edit or delete.");
                Console.WriteLine("You can also type 'exit' the program if you want to quit the program.");
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
                    Console.Title = "LIST OF QUESTS";
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests:A."); Console.WriteLine(quests[0] + "\n");
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
                        Lists();
                    }
                    else if (commandanswer1 == "delete")
                    {
                        DeletedQuestA0 A0 = new DeletedQuestA0();
                    }
                    else if (commandanswer1 == "edit")
                    {
                        Console.Clear();
                        UpdatedQuestA0 A0 = new UpdatedQuestA0();
                    }


                }

                if (command1 == "b")
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests:B."); Console.WriteLine(quests[1] + "\n");
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
                        UpdatedQuestB1 B1 = new UpdatedQuestB1();
                    }
                }
                if (command1 == "c")
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests:C."); Console.WriteLine(quests[2] + "\n");
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
                        UpdatedQuestC2 C2 = new UpdatedQuestC2();
                    }
                }
                if (command1 == "d")
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests:D."); Console.WriteLine(quests[3] + "\n");
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
                        UpdatedQuestD3 D3 = new UpdatedQuestD3();
                    }
                }
                if (command1 == "e")
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests:E."); Console.WriteLine(quests[4] + "\n");
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
                        UpdatedQuestE4 E4 = new UpdatedQuestE4();
                    }
                }
            }
        }
    }
}
