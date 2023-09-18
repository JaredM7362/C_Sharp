using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop
{
    internal class Order: Interface1
    {
        private string coffee, SizeOfCoffee, ingredients;
        private int quantity, price;

        public Order(string coffee, string sizeOfCoffee, string ingredients, int quantity, int price)
        {
            this.coffee = coffee;
            SizeOfCoffee = sizeOfCoffee;
            this.ingredients = ingredients;
            this.quantity = quantity;
            this.price = price;
        }

        public string Coffee
        {
            get { return coffee; }
        }
        public string SizeofCoffee
        {
            get { return SizeOfCoffee; }
        }
        public string Ingredients
        {
            get { return ingredients; }
        }
        public int Price
        {
            get { return price; }
        }
        public int Quantity
        {
            get { return quantity; }
        }
    

        public virtual string TotalOrderSummary()
        {
            int Total = quantity * price;
            string total = Total.ToString();
            string order = 
                            quantity+"\t "+coffee+""+SizeOfCoffee+""+ingredients+"\t "+price+"\t "+total;
            return total;

        }

    }
}
