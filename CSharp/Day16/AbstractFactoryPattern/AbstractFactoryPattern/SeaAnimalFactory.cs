using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
   public class SeaAnimalFactory : AnimalFactory
    {
        public override Animal GetAnimal(string Animaltype)
        {
            if (Animaltype.Equals("Shark"))
            {
                return new Shark();
            }
            else if (Animaltype.Equals("Octopus"))
                return new Octopus();
            else
                return null;
        }
    }
}
