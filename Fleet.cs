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

        public void CreateFleet()
        {
            //instantiate three objects and then add them to the list

            Robot FirstRobot = new Robot("Mandark");
            Robot SecondRobot = new Robot("DeeDee");
            Robot ThirdRobot = new Robot("Dexter");

            Robots.Add(FirstRobot);
            Robots.Add(SecondRobot);
            Robots.Add(ThirdRobot);

            foreach (Robot Robot in Robots);
            {
                Console.WriteLine(Robot);
            }
        }

        
    }
}
