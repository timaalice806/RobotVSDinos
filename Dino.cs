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
        public int HealthLevel = 10;
        public int EnergyLevel = 10;
        public int AttackPower = 8;

        //contructor (DINO DEFAULT Settings)
        public Dino(string DinoType, int HealthLevel, int EnergyLevel, int AttackPower)
        {
            this.DinoType = DinoType;
            this.HealthLevel = HealthLevel;
            this.EnergyLevel = EnergyLevel;
            this.AttackPower = AttackPower;
        }

        //member methods (DINOS CAN DO)

        public void AttackRobot(Robot robo)
        {
            //robo.RobotName
        }
    }
}
