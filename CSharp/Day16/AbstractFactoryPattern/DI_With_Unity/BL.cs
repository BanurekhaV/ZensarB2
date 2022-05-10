using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_With_Unity
{
    public class BL
    {
        private IProduct productobj;
        private IOrder orderobj;

        public BL(IProduct ip, IOrder io) // injecting the type object that implements the interface object
        {
            productobj = ip;
            orderobj = io;
        }

        public void InsertProduct()
        {
            productobj.InsertProduct(); //actually this call will be for the DL.InsertProduct
                                        // but through the Iproduct object            
        }

       public void Display()
        {
            orderobj.Display(); //the call is for Myorder.Display
        }
    }
}
