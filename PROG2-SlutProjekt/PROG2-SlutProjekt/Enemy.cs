using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_SlutProjekt
{
    class Enemy:Character
    { 
        public string Name { get; private set; }
        public int maxDmg { get; private set; } 
        public int minDmg { get; private set; }

        public Enemy()
        {
            Name = "Clas Göran ";
            GetHp();
            AddXp(3);
        }

        public override int GetHp()
        {
            hp = 150;
            return hp;
        }

        public override void Hurt(int amount)
        {
            if (amount % 3 == 0)
            {
                base.Hurt(-amount);
            }
            else
            {
                base.Hurt(amount);
            }
        }




    }
}
