using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Battlefield
    {
        public void PlayGame()
        {
            Console.WriteLine("Welcome to Robots versus Dinosaurs! Please choose a player.");
            string RobotName = Console.ReadLine();

            if (RobotName == "Mandark")
            {
                Console.WriteLine(RobotName[0]);
                Console.ReadLine();
            }
            if (RobotName == "DeeDee")
            {
                Console.WriteLine(RobotName[1]);
                Console.ReadLine();
            }
            if (RobotName == "Dexter")
            {
                Console.WriteLine(RobotName[2]);
                Console.ReadLine();
            }
            else
            {
               
            }

        }

    }
}
