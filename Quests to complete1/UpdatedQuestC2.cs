using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Quests_to_complete1
{
    public class UpdatedQuestC2
    {
        public UpdatedQuestC2()
        {
            edit3();
            static void edit3()
            {
                string[] quests = { "nothing", "nothing2", "nothing3", "nothing4", "nothing5" };
                Console.Title = "Quest Slot 3";
                Console.WriteLine("Please enter your new quest below...");
                Console.Write("New Quest:"); quests[2] = Console.ReadLine();
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Edit Complete");
                Console.Write("New Quest:"); Console.WriteLine(quests[2]);
                Console.WriteLine("(press enter to continue)");
                Console.ReadKey();
                Console.Clear();

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

                //if (command1 == "exit")
                //{
                //  exitpanel();
                //}


                if (command1 == "c")
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests: C."); Console.WriteLine(quests[2] + "\n");
                    Console.WriteLine("(comment 'remove' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest)\a");
                    Console.WriteLine("(or if you want to go back to your quests, comment 'mainmenu'.)");
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string mainmenu = "mainmenu";
                    string remove = "remove";
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
                        edit3();
                    }
                    else if (commandanswer1 == "remove")
                    {
                        File.Delete(quests[2]);
                        Console.WriteLine("Command Complete");
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        edit3();
                    }
                    else if (commandanswer1 == "edit")
                    {
                        UpdatedQuestC2 U1 = new UpdatedQuestC2();
                    }


                }
            }
        }



    }
}