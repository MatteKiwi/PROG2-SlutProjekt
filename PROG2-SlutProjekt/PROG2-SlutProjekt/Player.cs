using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_SlutProjekt
{
    //Ärver ifrån Character klassen
    class Player: Character
    {
        //En property som leder till inkappsling av string Name
        public string Name { get; private set; }
        //En private int som användas som värdet av Players "livs poäng"
        private int playerHp = 100;
        //Konstruktor av player som ger spelaren ett namn
        public Player()
        {
            Name = "???";
            GetHp();           
        }
        //En override på metoden GetHp från Character, den ersätter det värde den fick ifrån Character men värdet ifrån playerHP
        public override int GetHp()
        {
            return playerHp;
        }
        //Override på Hurt metoden ifrån Character, den gör så att Players "livspoäng" går ner med det värde man ger "amount"
        public override void Hurt(int amount)
        {          
            playerHp -= amount;

            if (playerHp < 0)
            {
                playerHp = 0;
            }
        }
        //Override på Attack metoden, den gör så att jag kan bestämma hur mycket jag vill att Player ska kunna "skada" andra med denna metod.
        public override int Attack(int dmg)
        {            
            return dmg;
        }
    }
}
