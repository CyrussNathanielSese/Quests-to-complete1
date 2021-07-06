using System;
using System.Collections.Generic;
using System.Text;

namespace Quests_to_complete1
{
    class DeletedQuestA0
    {
     
        public DeletedQuestA0()
            {
            Console.Clear();
            string[] quests = { "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT", "EMPTY SLOT" };
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Do you want to Delete this quest?\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Quest A:"); Console.WriteLine(quests[0] + "\n");
            Console.ResetColor();
            Console.WriteLine("(type 'yes' if you wish to delete the quest or type 'no')");
            Console.Write("Reponse:"); string deleteresponse1 = Console.ReadLine().ToLower();
             string deleteYES = "yes";
             string deleteNO = "no";

             while (deleteresponse1 != deleteYES && deleteresponse1 != deleteNO)
             {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("(Please type 'yes' or 'no' to continue with the command)");
                Console.ResetColor();
                Console.Write("Reponse:"); deleteresponse1 = Console.ReadLine().ToLower();
             }
            if (deleteresponse1 == "yes")
            {
                quests[0] = "EMPTY QUEST";
                Console.WriteLine("Command Complete");
                Console.WriteLine("(press any key to continue)");
                Console.ReadKey();
                Console.WriteLine("Do you want to go back to the main menu?");
                Console.Write("Reponse:"); string afterdeleteRESPONSE = Console.ReadLine().ToLower();
                string afterdeleteYES = "yes";
                string afterdeleteNO = "no";

                while (afterdeleteRESPONSE != afterdeleteYES && afterdeleteRESPONSE != afterdeleteNO)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please type 'yes' or 'no' to continue");
                    Console.ResetColor();
                    Console.Write("Reponse:"); afterdeleteRESPONSE = Console.ReadLine();
                }
                if (afterdeleteRESPONSE == "yes")
                {
                    MainProgram A0 = new MainProgram();
                }
                else if (afterdeleteRESPONSE == "no")
                {
                    Console.WriteLine("You wll be automatically moved in the exit panel");
                    Console.WriteLine("(press any key to continue)");
                    Console.ReadKey();
                    Console.Clear();
                    EXITPANEL X1 = new EXITPANEL();
                }
            }
            else if (deleteresponse1 == "no")
            {
                string mainmenuResponseYES = "yes";
                string mainmenuResponseNO = "no";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Do you wish to go back to the main menu?");
                Console.ResetColor();
                Console.WriteLine("type 'yes' or 'no' to continue");
                Console.Write("Reponse:"); string mainmenuResponse = Console.ReadLine().ToLower();
                while (mainmenuResponse != mainmenuResponseYES && mainmenuResponse != mainmenuResponseNO)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a right command");
                    Console.ResetColor();
                    Console.WriteLine("type 'yes' or 'no' to continue");
                    Console.Write("Reponse:"); mainmenuResponse = Console.ReadLine();
                }
                if (mainmenuResponseYES  == "yes")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You will be moved to the main menu shortly");
                    Console.WriteLine("(press any key to continue)");
                    Console.ReadKey();
                    Console.Clear();
                    ListOfQuests L1 = new ListOfQuests();
                }
                      
            }
        }
    }
}
