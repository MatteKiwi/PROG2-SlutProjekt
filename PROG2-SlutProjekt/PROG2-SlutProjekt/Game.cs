using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_SlutProjekt
{
    class Game
    {    
        public void game()
        {
            Story story = new Story();
            story.Welcome();
     
            bool gameOver = false;
            while (!gameOver)
            {
                int n = UserInput();

                if (n == 2)
                {
                    Console.Clear();
                    story.Mines();
                }
                else if(n == 3)
                {
                    gameOver = true;
                }

                gameOver = true;
            }

            Console.ReadLine();
        }

        private static int UserInput()
        {
            int n = 0;
            while (n <= 1) //en enekel while loop som kollar ifall användaren har skrivit ett nummer och inte en bokstav, ifall användaren har skrivit ett nummer så går den vidare
            {
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    continue;
                }
                Console.WriteLine("Icke sa micke! försök igen!!"); //felmeddelande
            }

            return n;
        }

    }
}
