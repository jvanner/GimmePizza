using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimmePizza
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Gimme Pizza!");

            Order order1 = new Order();
            FoodItem item1 = new FoodItem("Garlic Bread", "Yes", 3.99);
            FoodItem item2 = new FoodItem("Large Pizza", "Maybe", 12.95);
            order1.item_list.Add(item1);
            order1.item_list.Add(item2);

            order1.printOrder();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
