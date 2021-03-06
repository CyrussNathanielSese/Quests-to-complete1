using System;
using System.IO;
using System.Collections.Generic;

namespace Quests_to_complete1
{
    class MainProgram
    {
    
         static void Main(string[] args)
         {
                Console.Title = "Quests To Complete";
                DateTime now = DateTime.Now;
                Console.WriteLine(now.ToString());
                //START OF INTRODUCTION//
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Welcome to Quests To Complete!");
                Console.ResetColor();
                Console.WriteLine("What can you do on this application?\nThis App will allow you to store things that you will do in your computer in a classy-command block look.\nJust simply follow the guidelines that will be implemented by the app.");
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("(Remember that if you close this program, all of the things that you put on this program will be LOST)");
                Console.ResetColor();
                Console.WriteLine("ENJOY :)\n");
                Console.Write("(press any key to continue)");
                Console.ReadKey();
                Console.Clear();
                intro1();
         }
           static void intro1()
           {
                Console.Title = "YES OR NO?";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Do you want to proceed to the program?");
                Console.ResetColor();
                Console.WriteLine("(please type 'yes' or 'no' to continue)");//There will be two choices for this part

                Console.Write("Answer:"); string response1 = Console.ReadLine().ToLower();
                string yes1 = "yes";
                string no1 = "no";

                while (response1 != yes1 && response1 != no1)//If the user type anything else aside from 'yes' or 'no', he/she will be asked to write a right command.
                {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("(please enter a correct command)");
                Console.ResetColor();
                Console.WriteLine("(please type 'yes' or 'no' to continue)");
                Console.Write("Response:"); response1 = Console.ReadLine().ToLower();
                //THIS LOOP WILL BE REPEATED ONCE THE USER DID NOT TYPE 'YES' OR 'NO'//
                }


                if (response1 == "yes")//if the user say 'yes', the program will move the user into the another class
                {
                    ListOfQuestsPANEL L1 = new ListOfQuestsPANEL();
                }

                else if (response1 == "no")

                //THE PROGRAM WILL ASK THE PERSON IF HE/SHE WANTS TO QUIT THE PROGRAM//
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Do you want to exit the program?");
                    Console.ResetColor();
                    Console.WriteLine("(if you close the program, all of the quests that you added will be removed)");
                    Console.WriteLine("(please type 'yes' or 'no' to continue)");
                    Console.Write("Response:"); string response2 = Console.ReadLine().ToLower();

                    string yes2 = "yes";
                    string no2 = "no";

                    while (response2 != yes2 && response2 != no2)
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("please enter a correct command");
                    Console.ResetColor();
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
