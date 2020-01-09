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
        public Robot(string RobotName, int HealthLevel, )
        {
            this.RobotName = RobotName;
            this.HealthLevel = HealthLevel;


            Weapon = new Weapon();
        }

        //member methods (ROBOTS CAN DO)

        public void AttackDino()
        {

        }

        public void Mandark()
        {

        }
        public void DeeDee()
        {

        }
        public void Dexter()
        {

        }

    }
}
