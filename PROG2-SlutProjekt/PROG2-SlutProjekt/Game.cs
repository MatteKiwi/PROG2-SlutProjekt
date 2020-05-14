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
        //En konsturktor av Game som innehåller hela "spelet", dess syfte är att köra spelet.
        public Game()
        {
            //skapar två instanter från klasserna Enemy samt Player
            Enemy E1 = new Enemy();
            Player P1 = new Player();
            //Lägger in instanerna E1 samt P1 i en lista.
            CharacterList(E1, P1);
            //Skapar en instans av klassen Story samt köra Welcome metoden
            Story story = new Story();
            story.Welcome();
            //En bool för while loopen
            bool gameOver = false;
            //While loop som innehåller det viktagaste av spelet.
            while (!gameOver)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "y")
                {
                    StoryTime(story);//kör storytime metoden som innehåller "början" av spelet.
                    int n = UserInput();

                    if (n == 2)
                    {
                        Battle(story, E1, P1);//kör hela fight metoden där hela spelets "fight" finns i.

                        gameOver = true; 
                    }

                    else if (n == 3) //avslutar spelet ifall spelaren försöker springa iväg.
                    {
                        story.Run();
                        gameOver = true;
                    }

                    else if (n == 4) //Jag skulle istället ha velat haft en while loop men jag hann inte implantera en på ett effektivt sätt
                    {
                        Console.Clear();
                        Weapon W1 = new Weapon();
                        Console.WriteLine("Name: " + W1.Name + " type: " + W1.Type);
                        Console.WriteLine("Press y to return to combat");
                        continue;
                    }

                }
                else if (input.ToLower() == "n") //avslutar spelet ifall spelaren svarar nej på " the quest"
                {
                    gameOver = true;
                }

            }

            Console.ReadLine();
        }
        //En metod med en lista som innehåller E1 och P1
        private void CharacterList(Enemy E1, Player P1)
        {
            List<Character> allCharacters = new List<Character>();
            allCharacters.Add(E1);
            allCharacters.Add(P1);
        }
        //Metod som innehåller the "battle" i spelet.
        private void Battle(Story story, Enemy E1, Player P1)
        {
            Console.Clear();
            Console.WriteLine("You: " + P1.GetHp() + " Enemy: " + E1.GetHp());
            story.Battle();

            P1.Hurt(E1.Attack(80));
            E1.Hurt(P1.Attack(50));          

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("You: " + P1.GetHp() + " Enemy: " + E1.GetHp());
            story.SecondBattle();

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("You: " + P1.GetHp() + " Enemy: " + E1.GetHp());
            E1.Hurt(P1.Attack(99));

            Console.Clear();

            Console.WriteLine("You: " + P1.GetHp() + " Enemy: " + E1.GetHp());
            story.FinalBattle();
            P1.Hurt(E1.Attack(20));

            Console.ReadLine();
            Console.Clear();
            story.Death();
            Thread.Sleep(1000);
        }
        //nåt försök på generisk klass
        private static void CharacterListTest()
        {
            /*nåt försök på polymorfism tror jag?
            List<Character> allCharacters = new List<Character>();

            for (int i = 0; i < 100; i++)
            {
                allCharacters.Add(new Enemy());
                allCharacters.Add(new Player());
            }
            */
        }
        //En metod med "Storyn" som presenteras i början av spelet
        private void StoryTime(Story story)
        {
            Console.Clear();
            story.Mines();
            Console.ReadLine();
            story.Options();
        }
        //En metod som innehåller en simpel Userinput som använder sig av while loop och tryparse
        private int UserInput()
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
