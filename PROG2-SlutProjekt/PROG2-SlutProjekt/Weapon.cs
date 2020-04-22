using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_SlutProjekt
{
    class Weapon : Character
    {
        public string Name { get; private set; }
        public string Type { get; private set; }

        public Weapon()
        {
            Name = "Excalibur";
            Type = "Sword";
        }

        public override void Hurt(int amount)
        {          
            base.Hurt(-amount);
        }

    }
}



