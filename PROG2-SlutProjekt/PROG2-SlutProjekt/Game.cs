using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PROG2_SlutProjekt
{
    class Game
    {
        public void game()
        {
            // CharacterList();

            Story story = new Story();
            story.Welcome();

            Enemy E1 = new Enemy();
            Character C1 = new Character();

            bool gameOver = false;
            while (!gameOver)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "y")
                {
                    StoryTime(story);
                    int n = UserInput();

                    if (n == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("You: " + C1.GetHp() + " Enemy: " + E1.GetHp());
                        story.Battle();
                       
                        C1.Hurt(80);
                        E1.Hurt(50);

                        Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine("You: " + C1.GetHp() + " Enemy: " + E1.GetHp());
                        story.SecondBattle();

                        Console.ReadLine();
                        Console.Clear();

                        E1.Hurt(99);
                        Console.WriteLine("You: " + C1.GetHp() + " Enemy: " + E1.GetHp());
                        
                        story.FinalBattle();
                        C1.Hurt(20);
                        Console.WriteLine("You: " + C1.GetHp() + " Enemy: " + E1.GetHp());

                        Console.ReadLine();
                        Console.Clear();
                        story.Death();
                        Thread.Sleep(1000);

                        gameOver = true;
                    }

                    else if (n == 3)
                    {
                        story.Run();
                        gameOver = true;
                    }

                    else if (n == 4)
                    {
                        Weapon W1 = new Weapon();
                        Console.WriteLine("Name: " + W1.Name + " type: " + W1.Type);
                        Console.WriteLine("Press y to return to combat");
                        continue;
                    }

                }
                else if (input.ToLower() == "n")
                {
                    gameOver = true;
                }
               
            }

            Console.ReadLine();
        }

        private static void CharacterList()
        {
            //nåt försök på polymorfism tror jag?
            List<Character> allCharacters = new List<Character>();

            for (int i = 0; i < 100; i++)
            {
                allCharacters.Add(new Enemy());
            }

            for (int i = 0; i < allCharacters.Count; i++)
            {
                allCharacters[i].Hurt(5);
            }
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
