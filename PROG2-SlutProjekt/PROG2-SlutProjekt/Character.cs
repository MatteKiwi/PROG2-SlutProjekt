using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_SlutProjekt
{
    class Character
    {
        protected int hp = 100;
        private int xp = 0;

        public virtual void Hurt(int amount)
        {
            hp -= amount;

            if (hp < 0)
            {
                hp = 0;
            }
        }

        public virtual void Health(int newHp)
        {
            hp = newHp;
        }

        public virtual int GetHp()
        {
            return hp;
        }

        public void AddXp(int amount)
        {
            xp += Math.Max(0, amount);
        }

        public int GetLevel()
        {
            return (xp / 10) + 1;
        }

    }
}
