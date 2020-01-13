using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Robot
    {
        //member variables (ROBOTS HAVE A)

        public string RobotName;
        public int HealthLevel = 5;
        public int PowerLevel = 10;
        public Weapon Weapon;

        //contructor (ROBOT DEFAULT Settings)
        public Robot(string RobotName, int HealthLevel, int PowerLevel)
        {
            this.RobotName = RobotName;
            this.HealthLevel =  HealthLevel;
            this.PowerLevel = PowerLevel;
            Weapon = new Weapon("gun", 50);
        }

        //member methods (ROBOTS CAN DO)

        public void AttackDino(Dino dino)
        {
           //dino.DinoType

        }

    }
}
