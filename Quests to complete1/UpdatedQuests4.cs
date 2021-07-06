using System;
using System.Collections.Generic;
using System.Text;

namespace Quests_to_complete1
{
    class UpdatedQuests4
    {
        public UpdatedQuests4()
        {
            edit1();
            static void edit1()
            {
                string[] quests = { "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT" };
                Console.Title = "Quest Slot 1";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter your new quest below...");
                Console.ResetColor();
                Console.Write("New Quest:"); quests[3] = Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Edit Complete");
                Console.ResetColor();
                Console.Write("New Quest:"); Console.WriteLine(quests[3]);
                Console.WriteLine("(press enter to continue)");
                Console.ReadKey();
                Console.Clear();


                Console.Title = "LIST OF QUESTS";
                Console.Clear();
                Console.WriteLine("These are your Quests for today...");//lists of quests are shown below[DEFAULT QUESTS]
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
                Console.WriteLine("Do you want to edit your quests?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Type the letter of the quest you want to edit or delete.");
                Console.WriteLine("You can also type 'exit' the program if you want to quit the program.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Note: ALL of your quests will be deleted once you close the program.");
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
                    Console.WriteLine("(Please enter a valid letter)");
                    Console.Write("Command:"); command1 = Console.ReadLine().ToLower(); //THE USER WILL BE ASKED REPEATEDLY TO TYPE THE SPECIFIC LETTER OF QUEST"
                }

                if (command1 == "exit")
                {
                    EXITPANEL EXIT1 = new EXITPANEL();
                }


                if (command1 == "a")
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests: A."); Console.WriteLine(quests[0] + "\n");
                    Console.WriteLine("(comment 'remove' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest)\a");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("(Note: You cannot go back to the main menu once you added a quest on the first slot)");

                    Console.ResetColor();
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string mainmenu = "mainmenu";
                    string remove = "delete";
                    string edit = "edit";
                    while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit && commandanswer1 != exit)
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
                        UpdatedQuests1 U1 = new UpdatedQuests1();
                    }

                }

                else if (command1 == "b")
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests: A."); Console.WriteLine(quests[1] + "\n");
                    Console.WriteLine("(comment 'remove' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest)\a");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("(Note: You cannot go back to the main menu once you added a quest on the first slot)");

                    Console.ResetColor();
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string mainmenu = "mainmenu";
                    string remove = "delete";
                    string edit = "edit";
                    while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit && commandanswer1 != exit)
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
                        edit2();
                    }

                }


                else if (command1 == "c")
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests: A."); Console.WriteLine(quests[2] + "\n");
                    Console.WriteLine("(comment 'remove' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest)\a");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("(Note: You cannot go back to the main menu once you added a quest on the first slot)");

                    Console.ResetColor();
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string mainmenu = "mainmenu";
                    string remove = "delete";
                    string edit = "edit";
                    while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit && commandanswer1 != exit)
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
                        edit2();
                    }
                }
                else if (command1 == "d")
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests: A."); Console.WriteLine(quests[3] + "\n");
                    Console.WriteLine("(comment 'remove' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest)\a");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("(Note: You cannot go back to the main menu once you added a quest on the first slot)");

                    Console.ResetColor();
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string mainmenu = "mainmenu";
                    string remove = "remove";
                    string edit = "edit";
                    while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit && commandanswer1 != exit)
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
                        edit2();
                    }
                }
                else if (command1 == "e")
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests: A."); Console.WriteLine(quests[4] + "\n");
                    Console.WriteLine("(comment 'remove' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest)\a");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("(Note: You cannot go back to the main menu once you added a quest on the first slot)");

                    Console.ResetColor();
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string mainmenu = "mainmenu";
                    string remove = "remove";
                    string edit = "edit";
                    while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit && commandanswer1 != exit)
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
                        edit2();
                    }
                }


            }
            edit2();
            static void edit2()
            {
                string[] quests = { "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT" };
                Console.Title = "Quest Slot 1";
                Console.WriteLine("Please enter your new quest below...");
                Console.Write("New Quest:"); quests[1] = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Edit Complete");
                Console.Write("New Quest:"); Console.WriteLine(quests[1]);
                Console.WriteLine("(press enter to continue)");
                Console.ReadKey();
                Console.Clear();


                Console.WriteLine("These are your Quests for today...");//lists of quests are shown below[DEFAULT QUESTS]
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
                    EXITPANEL EXIT1 = new EXITPANEL();
                }


                if (command1 == "b")
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests: A."); Console.WriteLine(quests[1] + "\n");
                    Console.WriteLine("(comment 'remove' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest)\a");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("(Note: You cannot go back to the main menu once you added a quest on the first slot)");

                    Console.ResetColor();
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string mainmenu = "mainmenu";
                    string remove = "remove";
                    string edit = "edit";
                    while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit && commandanswer1 != exit)
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
                        edit2();
                    }

                }
            }
            edit3();
            static void edit3()
            {
                string[] quests = { "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT" };
                Console.Title = "Quest Slot 1";
                Console.WriteLine("Please enter your new quest below...");
                Console.Write("New Quest:"); quests[2] = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Edit Complete");
                Console.Write("New Quest:"); Console.WriteLine(quests[2]);
                Console.WriteLine("(press enter to continue)");
                Console.ReadKey();
                Console.Clear();


                Console.WriteLine("These are your Quests for today...");//lists of quests are shown below[DEFAULT QUESTS]
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
                    EXITPANEL EXIT1 = new EXITPANEL();
                }

                if (command1 == "c")
                {
                    Console.Clear();
                    Console.WriteLine("What do you want to do to this Quest?\n");
                    Console.Write("Quests:A."); Console.WriteLine(quests[2] + "\n");
                    Console.WriteLine("(comment 'remove' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest)\a");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("(Note: You cannot go back to the main menu once you added a quest on the first slot)");

                    Console.ResetColor();
                    Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                    string mainmenu = "mainmenu";
                    string remove = "remove";
                    string edit = "edit";
                    while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit && commandanswer1 != exit)
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
                        edit3();
                    }

                }

            }

                edit4();
                static void edit4()
                {
                    string[] quests = { "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT" };
                    Console.Title = "Quest Slot 1";
                    Console.WriteLine("Please enter your new quest below...");
                    Console.Write("New Quest:"); quests[3] = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Edit Complete");
                    Console.Write("New Quest:"); Console.WriteLine(quests[3]);
                    Console.WriteLine("(press enter to continue)");
                    Console.ReadKey();
                    Console.Clear();


                    Console.WriteLine("These are your Quests for today...");//lists of quests are shown below[DEFAULT QUESTS]
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
                        EXITPANEL EXIT1 = new EXITPANEL();
                    }


                    if (command1 == "d")
                    {
                        Console.Clear();
                        Console.WriteLine("What do you want to do to this Quest?\n");
                        Console.Write("Quests:A."); Console.WriteLine(quests[3] + "\n");
                        Console.WriteLine("(comment 'remove' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest)\a");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("(Note: You cannot go back to the main menu once you added a quest on the first slot)");

                        Console.ResetColor();
                        Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                        string mainmenu = "mainmenu";
                        string remove = "remove";
                        string edit = "edit";
                        while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit && commandanswer1 != exit)
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
                            edit4();
                        }

                    }

                }

                edit5();
                static void edit5()
                {
                    string[] quests = { "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT" };
                    Console.Title = "Quest Slot 1";
                    Console.WriteLine("Please enter your new quest below...");
                    Console.Write("New Quest:"); quests[4] = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Edit Complete");
                    Console.Write("New Quest:"); Console.WriteLine(quests[4]);
                    Console.WriteLine("(press enter to continue)");
                    Console.ReadKey();
                    Console.Clear();


                    Console.WriteLine("These are your Quests for today...");//lists of quests are shown below[DEFAULT QUESTS]
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
                        EXITPANEL EXIT1 = new EXITPANEL();
                    }


                    if (command1 == "d")
                    {
                        Console.Clear();
                        Console.WriteLine("What do you want to do to this Quest?\n");
                        Console.Write("Quests:A."); Console.WriteLine(quests[4] + "\n");
                        Console.WriteLine("(comment 'remove' if you want to delete the quest or comment 'edit' if you want to edit or replace the quest)\a");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("(Note: You cannot go back to the main menu once you added a quest on the first slot)");

                        Console.ResetColor();
                        Console.Write("Command:"); string commandanswer1 = Console.ReadLine().ToLower();
                        string mainmenu = "mainmenu";
                        string remove = "remove";
                        string edit = "edit";
                        while (commandanswer1 != mainmenu && commandanswer1 != remove && commandanswer1 != edit && commandanswer1 != exit)
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
                            edit5();
                        }

                    }

                }


                ///////     ///////    /////////   //////    //     //   //////              //////////  //   //   //////  /////
                //   //     //        //  //  //   //  //     //   //    //                      //      ///////     //    //
                /////       ///        // //  //   //  //      // //     ///                     //      //   //     //      ///
                //  ///     ////////   //     //   //////       ///      ///////                 //      //   //   /////  /////


        }
    }
}


