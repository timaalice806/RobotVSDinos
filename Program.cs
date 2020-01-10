using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot tallRobot = new Robot("mike", 1 , 1);
            tallRobot.Weapon.type = "gun";

            List<Robot> robots = new List<Robot>();
            robots.Add(tallRobot);

            Battlefield startGame = new Battlefield();
            startGame.PlayGame();

        }
    }
}
