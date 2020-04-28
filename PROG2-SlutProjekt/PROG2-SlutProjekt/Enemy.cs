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

        private int enemyHp = 150;
      
        public Enemy()
        {
            Name = "Clas Göran ";
            GetHp();
        }

        public override int GetHp()
        {         
            return enemyHp;
        }

        public override void Hurt(int amount)
        {         
            enemyHp -= amount;

            if (enemyHp < 0)
            {
                enemyHp = 0;
            }
        }

        public override int Attack(int dmg)
        {
            return dmg;
        }

    }
}
