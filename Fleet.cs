using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Fleet
    {
        public List<Robot> Robots = new List<Robot>()
        {
        new Robot("Mandark", 5, 5),
        new Robot("DeeDee", 5, 8),
        new Robot("Dexter", 5, 6),
        };

        //member method (FLEET CAN DO)
        public void PopulateFleet()
        {
            //instantiate three objects and then add them to the list
            for (int i = 0; i < Robots.Count; i++)
            {
                Console.WriteLine(Robots[i].RobotName);
              
            }
            Console.ReadLine();
        }
    }
}
