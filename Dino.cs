using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Dino
    {
        //member variables (DINOS HAVE A)

        public string DinoType;
        public int HealthLevel;
        public int EnergyLevel;
        public int AttackPower;

        //contructor (DINO DEFAULT Settings)
        public Dino(string DinoType, int HealthLevel, int EnergyLevel, int AttackPower)
        {
            DinoType = "LongNeck";
            HealthLevel = 100;
            EnergyLevel = 100;
            AttackPower = 10;
        }

        //member methods (DINOS CAN DO)

        public void AttackRobot()
        {

        }
    }
}
