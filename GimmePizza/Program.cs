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
            //string[] foodFileItems = {};
            //List<FoodItem> food_list = new List<FoodItem>();
            //try
            //{
            //    foodFileItems = File.ReadAllLines("C:\\Users\\Joshua\\Documents\\GitHub\\GimmePizza\\GimmePizza\\FoodData\\food_data.txt");
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("HALP");
            //    Environment.Exit(0);
            //}
            //foreach (string item in foodFileItems)
            //{
            //    string[] itemSplit = item.Split(',');
            //    FoodItem nextItem = new FoodItem(itemSplit[0], itemSplit[1], Convert.ToDouble(itemSplit[2]));
            //    food_list.Add(nextItem);
            //}
            List<FoodItem> food_list = FoodItem.ReadFoodData("C:\\Users\\Joshua\\Documents\\GitHub\\GimmePizza\\GimmePizza\\FoodData\\food_data.txt");
            Order order2 = new Order();
            foreach(FoodItem food in food_list)
            {
                order2.item_list.Add(food);
            }

            order2.printOrder();
            Console.ReadKey();

            
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
