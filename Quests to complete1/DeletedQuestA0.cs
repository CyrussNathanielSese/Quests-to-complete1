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
             string[] quests = { "nothing", "nothing2", "nothing3", "nothing4", "nothing5" };
             Console.WriteLine("Do you want to Delete this quest?\n");
             Console.WriteLine("(type 'yes' if you wish to delete the quest or type 'no')");
             Console.Write("Quest:A."); Console.WriteLine(quests[0] + "\n");
             Console.Write("Reponse:"); string deleteresponse1 = Console.ReadLine().ToLower();
             string deleteYES = "yes";
             string deleteNO = "no";

             while (deleteresponse1 != deleteYES && deleteresponse1 != deleteNO)
             {
                Console.WriteLine("Please type 'yes' or 'no' to continue with the command");
                Console.Write("Reponse:"); deleteresponse1 = Console.ReadLine().ToLower();
             }
             if (deleteresponse1 == "yes")
             {
                quests[0] = "EMPTY QUEST";
                Console.WriteLine("Command Complete");
                Console.WriteLine("(press any key to continue)");
                Console.ReadKey();
                Console.WriteLine("Do you want to go back to the main menu?");
                Console.Write("Reponse:"); string afterdeleteRESPONSE = Console.ReadLine();
                string afterdeleteYES = "yes";
                string afterdeleteNO = "no";

                    while (afterdeleteRESPONSE != afterdeleteYES && afterdeleteRESPONSE != afterdeleteNO)
                    {
                    Console.WriteLine("Please type 'yes' or 'no' to continue");
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
        }
    }
}
