using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimmePizza
{
    /***************************************************************/
    /* Class that represents an order a person places for delivery */
    /***************************************************************/
    class Order
    {
        public List<FoodItem> item_list;

        public Order()
        {
            item_list = new List<FoodItem>();
        }

        public double getPrice()
        {
            double price = 0;
            for (int i = 0; i < item_list.Count; i++)
                price += item_list[i].Price;
            return price;
        }

        public void printOrder()
        {
            for (int i = 0; i < item_list.Count; i++)
            {
                System.Console.Write(item_list[i].Name + ", $" + item_list[i].Price);
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Total Price: $" + this.getPrice());
        }
        
    }
}
