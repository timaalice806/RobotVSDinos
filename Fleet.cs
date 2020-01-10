using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Fleet
    {
        List<Robot> Robots = new List<Robot>();

        //member method (FLEET CAN DO)
        public void CreateFleet()
        {
            //instantiate three objects and then add them to the list

            Robot Mandark = new Robot("Mandark", 10, 10);
            Robot DeeDee = new Robot("DeeDee", 10, 8);
            Robot Dexter = new Robot("Dexter", 10, 6);

            Robots.Add(Mandark);
            Robots.Add(DeeDee);
            Robots.Add(Dexter);

            foreach (Robot Robot in Robots)
            {
                Console.WriteLine(Robots);
                Console.ReadLine();
            }
        }

        
    }
}
