using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Herd
    {
        public List<Dino> Dinos = new List<Dino>()
       {
        new Dino("Littlefoot", 10, 10, 2),
        new Dino("Petrie", 10, 8, 2),
        new Dino("Spike", 10, 6, 2),
        };

        //member method (HERD CAN DO)
        public void PopulateHerd()
        {
            foreach (Dino Dino in Dinos)
            {
                Console.WriteLine(Dino.DinoType);
            }
            Console.ReadLine();
        }
    }
      
}
