using System;
using System.Collections.Generic;
using System.Text;

namespace Quests_to_complete1
{
    class EXITPANEL
    {
        public EXITPANEL()
        {
            Exitpanel();
            static void Exitpanel()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("OK, have a good day :)");
                Console.ResetColor();
                Console.WriteLine("(press any key to continue)");
            }
        }
    }
}
