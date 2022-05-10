using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Shark : Animal
    { 
        public string speak()
        {
            return "Dont know to speak";
        }
    }
}
