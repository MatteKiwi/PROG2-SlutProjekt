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
                string input = Console.ReadLine();
                int x = 0;
                while(x == 0)
                {
                    if(input.ToLower() == "y")
                    {
                        x = 1;
                    }
                    else if(input.ToLower() == "n")
                    {
                        gameOver = true;
                    }
                    
                    Console.WriteLine("no");
                    Console.ReadLine();
                }





                if (input.ToLower() == "y")
                {
                    StoryTime(story);
                    int n = UserInput();
                    if (n == 2)
                    {
                        Console.WriteLine("yo");
                    }

                    else if (n == 3)
                    {
                        gameOver = true;
                    }

                    else if (n == 4)
                    {
                        Weapon W1 = new Weapon();
                        Console.WriteLine(W1.Name + W1.Type);
                    }

                }
                else if (input.ToLower() == "n")
                {
                    gameOver = true;
                }

                // gameOver = true;
            }

            Console.ReadLine();
        }

        private static void StoryTime(Story story)
        {
            Console.Clear();
            story.Mines();
            Console.ReadLine();
            story.Options();
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
