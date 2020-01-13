using System;

namespace RobotsVsDinos
{
    public class Battlefield
    {

        //instantiate FLEET & HERD objects 

        Fleet RoboFleet = new Fleet();
        Herd DinoHerd = new Herd();
        Dino dino = new Dino("Littlefoot", 10, 10, 5);
        Robot robot = new Robot("Mandark", 10, 5);
        
        public void PlayGame()
        {
            ChoosePlayer();

          

            //robotChoice.Weapon.type = 

            //Dino dinoChoice = ChooseDino();

            //dinoChoice.

        }

        public void ChoosePlayer()
        {
            //Robot robot = RoboFleet.Robots[0];
            Console.WriteLine("Welcome to Robots versus Dinosaurs! Please choose a player, Robots or Dinosaurs. \nPlease enter 1 for Robots or 2 for Dinosaurs: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("You are a Robot.");
                Console.ReadLine();
                RoboFleet.PopulateFleet();
                FightRoboDino(robot, dino);
            }
            else if (userInput == "2")
            {
                Console.WriteLine("You are Dinosaur.");
                Console.ReadLine();
                DinoHerd.PopulateHerd();
                FightRoboDino(robot, dino);
            }
            else
            {
                Console.WriteLine("You must choose 1 or 2, those are your only options");
                Console.ReadLine();
                PlayGame();
            }

            //for (int i = 0; i < RoboFleet.Robots.Count; i++)
            //{
            //    if (userInput == RoboFleet.Robots[i].RobotName)
            //    {
            //        return RoboFleet.Robots[i];
            //    }
            //}
            //return robot;
        }

        public void FightRoboDino(Robot robot, Dino dino)
        {
            robot.HealthLevel = robot.HealthLevel - dino.AttackPower;
            dino.HealthLevel = robot.PowerLevel - dino.HealthLevel;

                if (robot.HealthLevel < 10)
                {
                    Console.WriteLine("Robot has died." + robot.HealthLevel);
                    Console.ReadLine();
                }
                else if (dino.HealthLevel < 10)
                {
                Console.WriteLine("Dino is dead. " + dino.HealthLevel);
                Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("No one wins, all players dead.");
                    Console.ReadLine();
                }
        }

        //public Dino ChooseDino()
        //{
        //    Dino dino = DinoHerd.Dinos[0];
        //    Console.WriteLine("Please choose from the following list of dinosaurs:");
        //    DinoHerd.PopulateHerd();
        //    string userInput = Console.ReadLine();

        //    for (int i = 0; i < DinoHerd.Dinos.Count; i++)
        //    {
        //        if (userInput == DinoHerd.Dinos[i].DinoType)
        //        {
        //            return DinoHerd.Dinos[i];
        //        }
        //    }
        //    return dino;
        //}
    }
}
