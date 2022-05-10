using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_With_Unity
{
    public interface IProduct
    {
        string InsertProduct();
    }

    public interface IOrder
    {
        void Display();
    }

    class MyOrder : IOrder
    {
        public void Display()
        {
            Console.WriteLine("Your Order Details....");
        }
    }
}
