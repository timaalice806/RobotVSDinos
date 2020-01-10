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
        public int HealthLevel;
        public int PowerLevel;
        public Weapon Weapon;


        //contructor (ROBOT DEFAULT Settings)
        public Robot(string RobotName, int HealthLevel, int PowerLevel)
        {
            this.RobotName = RobotName;
            this.HealthLevel =  HealthLevel;
            this.PowerLevel = PowerLevel;
            Weapon = new Weapon();
        }

        //member methods (ROBOTS CAN DO)

        public void AttackDino()
        {
           
        }

    }
}
