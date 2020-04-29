using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_SlutProjekt
{
    class Enemy:Character
    { 
        //en proprety som leder till inkappslingen av stringen name, som avnändes för att visa namnet på "enemy"
        public string Name { get; private set; }
        //En int för enemys "livspoäng" som är satt på 150
        private int enemyHp = 150;
        //Konsturktor för enemy class, innehåller namnet på alla "enemies" som "spawnar"
        public Enemy()
        {
            Name = "Clas Göran ";
            GetHp();
        }
        //En override på GetHp metoden ifrån Character, den byter ut det "hp:et" som den ärver från den klassen med enemyHp 
        public override int GetHp()
        {         
            return enemyHp;
        }
        //En override på Hurt metoden ifrån Character.
        public override void Hurt(int amount)
        {         
            enemyHp -= amount;

            if (enemyHp < 0)
            {
                enemyHp = 0;
            }
        }
        //En override på Attack metoden, inget speciellt med den
        public override int Attack(int dmg)
        {
            return dmg;
        }

    }
}
