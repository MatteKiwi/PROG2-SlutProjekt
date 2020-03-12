using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_SlutProjekt
{
    class Enemy:Character
    {
        public string Name { get; private set;}
        public int HealthPoints { get; private set; }

        public Enemy()
        {
            Name = "Clas Göran";
            HealthPoints = 100;
        }
        


    }
}
