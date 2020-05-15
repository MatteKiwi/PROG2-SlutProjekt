using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_SlutProjekt
{
    class Story //Denna klass innehåller allt "content" inom spelet och dess syftet är att hålla all "dialog" på ett ställe för att inte göra det kluddigt i Game klassen.
    {
        //Denna metod välkommnar spelaren och presenterar den ett val
        public void Welcome()
        {
            GetValue<string> obj = new GetValue<string>();
            obj.Value = "- y = Yes/n = No -";

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("        - Well hello there! Dear traveler I have a quest for you -"       );
            Console.WriteLine(" -You see the mines here in Whiterun a have been overun by vicious creatures! -");
            Console.WriteLine("          - Will you please help us to take back the mines? -");
            Console.WriteLine("                     " + obj.Value);
            Console.WriteLine("-----------------------------------------------------------------------------");
        }
        //Denna metod förklara "figthen" för spelaren dessutom presenterar den Enemy.
        public void Mines(Enemy E1)
        {
         
            E1.AddXp(Utils.generator.Next(1, 1000));
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("              -As you enter the mines you hear a loud roar -");
            Console.WriteLine("                              - GRRRRR! - ");
            Console.WriteLine("              -From no where! a level:" + E1.GetLevel() + " " + E1.Name );
            Console.WriteLine("                     -Jumps right infront of you-" );
            Console.WriteLine("-------------------------------------------------------------------------------");
        }
        //Visar alla val som spelaren har
        public void Options()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine(" -What will you do?- ");
            Console.WriteLine("2. Attack");
            Console.WriteLine("3. Run");
            Console.WriteLine("4. Inspect Weapon");
            Console.WriteLine("----------------------");
        }
        //Meddlande som visar ifall spelaren väljer att springa iväg
        public void Run()
        {
            Console.Clear();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("          -As you tried to run away-              ");
            Console.WriteLine("  -You somehow manged to trip and hit your head-  ");
            Console.WriteLine("               - YOU DIED -                       ");
            Console.WriteLine("--------------------------------------------------");
        }
        //Texten bakom den första striden mellan spelare och enemy
        public void Battle(Enemy E1)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("    -As: " + E1.Name + "tried to slash you- "      );
            Console.WriteLine("  -You performed a lovely pirouette as u stabed-  ");
            Console.WriteLine("     -" + E1.Name + "for 50 health points!-"       );
            Console.WriteLine("  -In a furious rage" + E1.Name + "slashed u back-");
            Console.WriteLine("         -You lost 80 health points!- "            );
            Console.WriteLine("--------------------------------------------------");
        }
        //Text bakom den andra delen av striden mellan spelare och enemy
        public void SecondBattle(Enemy E1)
        {

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("    -You hear a loud scream from " + E1.Name                      );
            Console.WriteLine("          -As he screams in anguish                              ");
            Console.WriteLine(" - You notice " + E1.Name + " is hunching for a final blow -     ");
            Console.WriteLine(" - But before he can reach you, you perform a double pirouette - ");
            Console.WriteLine(" - In which strikes " + E1.Name + "for 99 healthpoints -         ");
            Console.WriteLine("-----------------------------------------------------------------");

           
        }
        //Text bakom den sista delan av striden mellan spelare samt enemy
        public void FinalBattle(Enemy E1)
        {

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("         - Oh no! -                  ");
            Console.WriteLine("  - It seems like: " + E1.Name        );
            Console.WriteLine(" - Survived! And with a quick swoop -");
            Console.WriteLine("   - He took 20 health points - "     );
            Console.WriteLine("-------------------------------------");
        }
        //En ascii art som presenteras när man dör
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
