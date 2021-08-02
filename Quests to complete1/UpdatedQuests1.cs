using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Quests_to_complete1
{
    class UpdatedQuests1 : QuestsLIST
    {
        public UpdatedQuests1()
        {
            edit1();
            static void edit1()
            {
                Console.Title = "Quest Slot 1";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter your new quest below...");
                Console.ResetColor();
                Console.Write("New Quest:"); Quests[0] = Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Edit Complete");
                Console.ResetColor();
                Console.Write("New Quest:"); Console.WriteLine(Quests[0]);
                Console.WriteLine("(press enter to continue)");
                Console.ReadKey();
                Console.Clear();


                Console.Title = "LIST OF QUESTS";
                Console.Clear();
                Console.Title = "Quests To Complete";
                DateTime now = DateTime.Now;
                Console.WriteLine(now.ToString());
                Console.WriteLine("\nThese are your Quests for today...");//lists of Quests are shown below[DEFAULT Quests]
                Console.WriteLine("------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("A." + Quests[0]);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("B." + Quests[1]);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("C." + Quests[2]);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("D." + Quests[3]);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("E." + Quests[4]);
                Console.ResetColor();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Stay at this panel if you do not want to edit your quests");
                Console.WriteLine("Do you want to edit your Quests?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Type the letter of the quest you want to edit or delete.");
                Console.WriteLine("You can exit the program by typing 'exit' in the command block.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Note: ALL of your Quests will be deleted once you close the program.");
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

                //THE USER NEEDS TO TYPE THE EXACT LETTER OF THE QUEST IN ORDER TO GO TO THAT Quests'S COMMANDS//
                while (command1 != a && command1 != b && command1 != c && command1 != d && command1 != e && command1 != exit)
                {
                    Console.WriteLine("(Please enter a valid letter)");
                    Console.Write("Command:"); command1 = Console.ReadLine().ToLower(); //THE USER WILL BE ASKED REPEATEDLY TO TYPE THE SPECIFIC LETTER OF QUEST"
                }

                if (command1 == "a")
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Quest A:"); Console.WriteLine(Quests[0] + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("(comment 'delete' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest)\a");
                    Console.WriteLine("(or if you want to go back to your quests, comment 'mainmenu'.)\n");
                    Console.ResetColor();
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string remove = "delete";
                    string edit = "edit";
                    string backtomenu = "mainmenu";

                    while (commandanswer1 != remove && commandanswer1 != edit && commandanswer1 != backtomenu)
                    {
                        Console.WriteLine("Please comment a valid command");
                        Console.Write("Command:"); commandanswer1 = Console.ReadLine().ToLower();
                    }

                    if (commandanswer1 == "delete")
                    {
                        DeletedQuestA0 A0 = new DeletedQuestA0();
                    }
                    else if (commandanswer1 == "edit")
                    {
                        Console.Clear();
                        UpdatedQuests1 U1 = new UpdatedQuests1();
                    }
                    else if (commandanswer1 == "mainmenu")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You will be moved to the main menu shortly.");
                        Console.ResetColor();
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        ListOfQuestsPANEL Panel1 = new ListOfQuestsPANEL();
                    }


                }

                else if (command1 == "b")
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Quest B:"); Console.WriteLine(Quests[1] + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("(comment 'delete' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest)\a");
                    Console.WriteLine("(or if you want to go back to your quests, comment 'mainmenu'.)\n");
                    Console.ResetColor();
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string remove = "delete";
                    string edit = "edit";
                    string backtomenu = "mainmenu";

                    while (commandanswer1 != remove && commandanswer1 != edit && commandanswer1 != backtomenu)
                    {
                        Console.WriteLine("Please comment a valid command");
                        Console.Write("Command:"); commandanswer1 = Console.ReadLine().ToLower();
                    }

                    if (commandanswer1 == "delete")
                    {
                        DeletedQuestB1 B1 = new DeletedQuestB1();
                    }
                    else if (commandanswer1 == "edit")
                    {
                        Console.Clear();
                        UpdatedQuests2 E2 = new UpdatedQuests2();
                    }
                    else if (commandanswer1 == "mainmenu")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You will be moved to the main menu shortly.");
                        Console.ResetColor();
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        ListOfQuestsPANEL Panel1 = new ListOfQuestsPANEL();
                    }

                }


                else if (command1 == "c")
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Quest C:"); Console.WriteLine(Quests[2] + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("(comment 'delete' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest)\a");
                    Console.WriteLine("(or if you want to go back to your quests, comment 'mainmenu'.)\n");
                    Console.ResetColor();
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string remove = "delete";
                    string edit = "edit";
                    string backtomenu = "mainmenu";

                    while (commandanswer1 != remove && commandanswer1 != edit && commandanswer1 != backtomenu)
                    {
                        Console.WriteLine("Please comment a valid command");
                        Console.Write("Command:"); commandanswer1 = Console.ReadLine().ToLower();
                    }

                    if (commandanswer1 == "delete")
                    {
                        Console.Clear();
                        DeletedQuestC2 C2 = new DeletedQuestC2();
                    }
                    else if (commandanswer1 == "edit")
                    {
                        Console.Clear();
                        UpdatedQuests3 E3 = new UpdatedQuests3();
                    }
                    else if (commandanswer1 == "mainmenu")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You will be moved to the main menu shortly.");
                        Console.ResetColor();
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        ListOfQuestsPANEL Panel1 = new ListOfQuestsPANEL();
                    }
                }

                else if (command1 == "d")
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Quest D:"); Console.WriteLine(Quests[3] + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("(comment 'delete' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest)\a");
                    Console.WriteLine("(or if you want to go back to your quests, comment 'mainmenu'.)\n");
                    Console.ResetColor();
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string remove = "delete";
                    string edit = "edit";
                    string backtomenu = "mainmenu";

                    while (commandanswer1 != remove && commandanswer1 != edit && commandanswer1 != backtomenu)
                    {
                        Console.WriteLine("Please comment a valid command");
                        Console.Write("Command:"); commandanswer1 = Console.ReadLine().ToLower();
                    }

                    if (commandanswer1 == "delete")
                    {
                        Console.Clear();
                        DeletedQuestD3 D3 = new DeletedQuestD3();
                    }
                    else if (commandanswer1 == "edit")
                    {
                        Console.Clear();
                        UpdatedQuests4 E4 = new UpdatedQuests4();
                    }
                    else if (commandanswer1 == "mainmenu")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You will be moved to the main menu shortly.");
                        Console.ResetColor();
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        ListOfQuestsPANEL Panel1 = new ListOfQuestsPANEL();
                    }
                }

                else if (command1 == "e")
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Quest E:"); Console.WriteLine(Quests[4] + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("(comment 'delete' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest)\a");
                    Console.WriteLine("(or if you want to go back to your quests, comment 'mainmenu'.)\n");
                    Console.ResetColor();
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string remove = "delete";
                    string edit = "edit";
                    string backtomenu = "mainmenu";

                    while (commandanswer1 != remove && commandanswer1 != edit && commandanswer1 != backtomenu)
                    {
                        Console.WriteLine("Please comment a valid command");
                        Console.Write("Command:"); commandanswer1 = Console.ReadLine().ToLower();
                    }

                    if (commandanswer1 == "delete")
                    {
                        Console.Clear();
                        DeletedQuestE4 E4 = new DeletedQuestE4();
                    }
                    else if (commandanswer1 == "edit")
                    {
                        Console.Clear();
                        UpdatedQuests5 E5 = new UpdatedQuests5();
                    }
                    else if (commandanswer1 == "mainmenu")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You will be moved to the main menu shortly.");
                        Console.ResetColor();
                        Console.WriteLine("(press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                        ListOfQuestsPANEL Panel1 = new ListOfQuestsPANEL();
                    }
                }

                else if (command1 != exit)
                {
                    EXITPANEL Exit = new EXITPANEL();
                }
            }
           


                ///////     ///////    /////////   //////    //     //   //////              //////////  //   //   //////  /////
                //   //     //        //  //  //   //  //     //   //    //                      //      ///////     //    //
                /////       ///        // //  //   //  //      // //     ///                     //      //   //     //      ///
                //  ///     ////////   //     //   //////       ///      ///////                 //      //   //   /////  /////


        }
    }
}
