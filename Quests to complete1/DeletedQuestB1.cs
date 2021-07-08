using System;
using System.Collections.Generic;
using System.Text;

namespace Quests_to_complete1
{
    class DeletedQuestB1 : QuestsLIST
    {
        public DeletedQuestB1()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Do you want to Delete this quest?\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Quest B:"); Console.WriteLine(Quests[1] + "\n");
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
                Quests[1] = "DELETED QUEST";
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
