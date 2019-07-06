using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GimmePizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimme Pizza!");

            MainForm form_main = new MainForm();

            Order order1 = new Order();
            FoodItem item1 = new FoodItem("Garlic Bread", "Yes", 3.99);
            FoodItem item2 = new FoodItem("Large Pizza", "Maybe", 12.95);
            order1.item_list.Add(item1);
            order1.item_list.Add(item2);
            order1.printOrder();

            List<FoodItem> food_list = FoodItem.ReadFoodData("..\\..\\FoodData\\food_data.txt");
            Order order2 = new Order();
            foreach(FoodItem food in food_list)
            {
                order2.item_list.Add(food);
            }

            order2.printOrder();

            Application.Run(new MainForm());
        }
    }
}
