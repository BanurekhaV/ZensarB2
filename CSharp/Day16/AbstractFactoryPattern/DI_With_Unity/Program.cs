using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace DI_With_Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an unity container
            UnityContainer UC = new UnityContainer();

            //register all types
            UC.RegisterType<BL>();
            UC.RegisterType<DL>();
            UC.RegisterType<IProduct, DL>();
            UC.RegisterType<IOrder, MyOrder>();
            BL bl = UC.Resolve<BL>();
            bl.InsertProduct(); // BLs insert Product()
            bl.Display();//Bls Display()
            Console.Read();
        }
    }
}
