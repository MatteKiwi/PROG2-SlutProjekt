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

        public void Run()
        {
            Console.Clear();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("          -As you tried to run away-              ");
            Console.WriteLine("  -You somehow manged to trip and hit your head-  ");
            Console.WriteLine("               - YOU DIED -                       ");
            Console.WriteLine("--------------------------------------------------");
        }

        public void Battle()
        {
            Enemy E1 = new Enemy();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("    -As: " + E1.Name + "tried to slash you- "      );
            Console.WriteLine("  -You performed a lovely pirouette as u stabed-  ");
            Console.WriteLine("     -" + E1.Name + "for 50 health points!-"       );
            Console.WriteLine("  -In a furious rage" + E1.Name + "slashed u back-");
            Console.WriteLine("         -You lost 80 health points!- "            );
            Console.WriteLine("--------------------------------------------------");
        }

        public void SecondBattle()
        {
            Enemy E1 = new Enemy();

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("    -You hear a loud scream from " + E1.Name                      );
            Console.WriteLine("          -As he screams in anguish                              ");
            Console.WriteLine(" - You notice " + E1.Name + " is hunching for a final blow -     ");
            Console.WriteLine(" - But before he can reach you, you perform a double pirouette - ");
            Console.WriteLine(" - In which strikes " + E1.Name + "for 99 healthpoints -         ");
            Console.WriteLine("-----------------------------------------------------------------");

           
        }

        public void FinalBattle()
        {
            Enemy E1 = new Enemy();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("         - Oh no! -                  ");
            Console.WriteLine("  - It seems like: " + E1.Name        );
            Console.WriteLine(" - Survived! And with a quick swoop -");
            Console.WriteLine("   - He took 20 health points - "     );
            Console.WriteLine("-------------------------------------");
        }

        public void Death()
        {
            Console.WriteLine(@" __     ______  _    _   _____ _____ ______ _____  
 \ \   / / __ \| |  | | |  __ \_   _|  ____|  __ \ 
  \ \_/ / |  | | |  | | | |  | || | | |__  | |  | |
   \   /| |  | | |  | | | |  | || | |  __| | |  | |
    | | | |__| | |__| | | |__| || |_| |____| |__| |
    |_|  \____/ \____/  |_____/_____|______|_____/ 
                                                   ");
        }

    }
}
