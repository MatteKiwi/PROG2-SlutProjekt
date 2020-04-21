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
            Console.WriteLine("                      - y = Yes--n = No -                             ");
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
            Console.WriteLine("----------------------");
            Console.WriteLine(" -What will you do?- ");
            Console.WriteLine("2. Attack");
            Console.WriteLine("3. Run");
            Console.WriteLine("4. Inspect Weapon");
            Console.WriteLine("----------------------");
        }
    }
}
