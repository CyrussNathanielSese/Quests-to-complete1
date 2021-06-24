using System;
using System.IO;
using System.Collections.Generic;

namespace Quests_to_complete1
{
    class MainProgram
    {
    
         static void Main(string[] args)
         {
                Console.Title = "WELCOME";
                DateTime now = DateTime.Now;
                Console.WriteLine(now.ToString());
                //INTRODUCTION//
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Welcome to Quests To Complete!");
                Console.ResetColor();
                Console.WriteLine("What can you do on this application?\nThis App will allow you to store things the you will do in your computer in a classy-command block look.\nJust simply follow the guidelines that will be implemented by this app.");
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("(Remember that if you close this program, All of the things that you put on this application will be lost)");
                Console.ResetColor();
                Console.WriteLine("ENJOY :)\n");
                Console.Write("(press any key to continue)");
                Console.ReadKey();
                Console.Clear();
                intro1();
         }
           static void intro1()
           {
            //THERE WILL BE A DEFAULT LIST OF QUESTS THAT WILL BE SHOWN//
            //THE DEFAULT QUESTS ARE LISTED IN AN ARRAY
                Console.Title = "YES OR NO?";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Do you want to look to your Quests for today?");
                Console.ResetColor();
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
                    ListOfQuests L1 = new ListOfQuests();
                }

                else if (response1 == "no")

                //THE PROGRAM WILL ASK THE PERSON IF HE/SHE WANTS TO QUIT THE PROGRAM//
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Do you want to exit the program?");
                    Console.ResetColor();
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