using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Herd
    {
        List<Dino> Dinos = new List<Dino>();

        //member method (HERD CAN DO)
        public void CreateHerd()
        {
            //instantiate three objects and then add them to the list

            Dino FirstDino = new Dino("Littlefoot", 10, 10, 10);
            Dino SecondDino = new Dino("Petrie", 10, 8, 8);
            Dino ThirdDino = new Dino("Spike", 10, 6, 6);

            Dinos.Add(FirstDino);
            Dinos.Add(SecondDino);
            Dinos.Add(ThirdDino);
        }
    }
}
