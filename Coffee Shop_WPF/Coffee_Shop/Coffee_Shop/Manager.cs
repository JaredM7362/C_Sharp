using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop
{
    internal class Manager : Order
    {
        public Manager(string coffee, string sizeOfCoffee, string ingredients, int quantity, int price) : base(coffee, sizeOfCoffee, ingredients, quantity, price)
        {
        }


    }
}
