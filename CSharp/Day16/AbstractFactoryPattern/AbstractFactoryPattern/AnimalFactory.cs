using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
   public abstract class AnimalFactory
    {
        public abstract Animal GetAnimal(string Animaltype);

        public static AnimalFactory CreateAnimalFactory(string FactoryType)
        {
            if (FactoryType.Equals("Land"))
                return new LandAnimalFactory();
            else
                return new SeaAnimalFactory();
        }
    }
}
