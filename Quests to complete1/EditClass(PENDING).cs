using System;
using System.Collections.Generic;
using System.Text;

namespace Quests_to_complete1
{
    class EditClass
    {
        public EditClass()
        {
            static void edit()
                
            {
                string[] quests = { "nothing", "nothing2", "nothing3", "nothing4", "nothing5" };


                Console.WriteLine("What do you want to do to this quest?");
                Console.WriteLine(quests[0]);
            }

        }
    }
}
