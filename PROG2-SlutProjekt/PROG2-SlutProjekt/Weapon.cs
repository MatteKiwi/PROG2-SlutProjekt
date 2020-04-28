using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_SlutProjekt
{
    class Weapon : Player
    {
        //två "properties" som leder till inkappsling av strings Name och Type
        public new string Name { get; private set; }
        public string Type { get; private set; }
        //en konsturktur som ger namn till Weapons name och type
        public Weapon()
        {
            Name = "Excalibur";
            Type = "Sword";
        }
        //En public override som "override:ar" Hurt metoden som denna klass ärver från Player klassen.
        public override void Hurt(int amount)
        {          
            base.Hurt(-amount);
        }

    }
}



