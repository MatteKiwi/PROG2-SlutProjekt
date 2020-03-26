using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_SlutProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> allCharacters = new List<Character>();

            for (int i = 0; i < 100; i++)
            {
                allCharacters.Add(new Enemy());
            }

            for (int i = 0; i < allCharacters.Count; i++)
            {
                allCharacters[i].Hurt(5);
            }

            Enemy e1 = new Enemy();
            Character c1 = new Character();

            e1.Hurt(80);
            e1.AddXp(500);

            Story Welcome = new Story();

            Welcome.Welcome();

            Game game = new Game();

            game.game();

            Console.WriteLine("Name: " + e1.Name + "Hp: " + e1.GetHp() + " Level: " + e1.GetLevel());
            Console.ReadLine();

        }
    }
}
