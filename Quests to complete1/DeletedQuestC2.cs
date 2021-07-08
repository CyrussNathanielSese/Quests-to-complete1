using System;
using System.Collections.Generic;
using System.Text;

namespace Quests_to_complete1
{
    class DeletedQuestC2 : QuestsLIST
    {
        public DeletedQuestC2()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Do you want to Delete this quest?\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Quest C:"); Console.WriteLine(Quests[2] + "\n");
            Console.ResetColor();
            Console.WriteLine("(type 'yes' if you wish to delete the quest or type 'no')");
            Console.Write("Response:"); string deleteresponse1 = Console.ReadLine().ToLower();
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
                Console.Clear();
                Quests[2] = "DELETED QUEST";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Command Complete");
                Console.ResetColor();
                Console.WriteLine("(press any key to continue)");
                Console.ReadKey();
                Console.Clear();
                ListOfQuestsPANEL L1 = new ListOfQuestsPANEL();
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
                if (mainmenuResponseYES == "yes")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You will be moved to the main menu shortly");
                    Console.WriteLine("(press any key to continue)");
                    Console.ReadKey();
                    Console.ResetColor();
                    Console.Clear();
                    ListOfQuestsPANEL L1 = new ListOfQuestsPANEL();
                }

            }
        }
    }
}
