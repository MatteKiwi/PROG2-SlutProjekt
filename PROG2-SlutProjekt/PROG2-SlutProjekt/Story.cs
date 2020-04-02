using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_SlutProjekt
{
    class Story
    {
        
    
        public void Welcome()
        {     
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("        - Well hello there! Dear traveler I have a quest for you -"       );
            Console.WriteLine(" -You see the mines here in Whiterun a have been overun by vicious creatures! -");
            Console.WriteLine("          - Will you please help us to take back the mines? -");
            Console.WriteLine("                      - 2. Yes 3. No -                             ");
            Console.WriteLine("-----------------------------------------------------------------------------");
        }

        public void Mines()
        {
            Enemy e1 = new Enemy();
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("              -As you enter the mines you hear a loud roar -");
            Console.WriteLine("                              - GRRRRR! - ");
            Console.WriteLine("              -From no where! A: " + e1.Name +  " jumps right infront of you-");
            Console.WriteLine("-------------------------------------------------------------------------------");
        }

        public void Options()
        {
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Run");
            Console.WriteLine("3. Inspect");
        }
    }
}
