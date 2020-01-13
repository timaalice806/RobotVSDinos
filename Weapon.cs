using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Weapon
    {
        //member variables (WEAPONS HAVE A)

        public string type;
        public int AttackPower;

        //constructor (DEFAULT SETTINGS)
        public Weapon(string type, int AttackPower)
        {
            this.type = type;
            this.AttackPower = AttackPower;
        }

    }


}
