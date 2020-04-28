using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_SlutProjekt
{
    class Character
    {
        //Två variabler som är protected samt private
        protected int hp = 100;
        private int xp = 0;
        //En enkel virtual Hurt metod som använder sig av int hp som "bas" för att ta bort "livspoäng", denna metod användes därefter av både player och enemy
        public virtual void Hurt(int amount)
        {
            hp -= amount;

            if (hp < 0)
            {
                hp = 0;

            }
        }
        //En virtual "Health" metod som ger int hp ett nytt värde. 
        public virtual void Health(int newHp)
        {
            hp = newHp;
        }
        //En metod som returnar värdet på int hp
        public virtual int GetHp()
        {
            return hp;
        }
        //En metod som bestämer vilket värdet på int xp ska vara. Använder sig av Math.Max metoden vilket retunerna det större talet mellan 0 och int amount
        public void AddXp(int amount)
        {
            xp += Math.Max(0, amount);
        }
        //Metod som retunerar värdet på xp, dessutom så delar den xp på 10 och lägger till en etta.
        public int GetLevel()
        {
            return (xp / 10) + 1;
        }
        //Metod för att göra "skada", retunera int dmg vilkets värde går att bestämma.
        public virtual int Attack(int dmg)
        {
            return dmg;
        }

    }
}
