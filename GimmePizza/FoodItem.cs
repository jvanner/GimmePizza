using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimmePizza
{
    /***************************************************************/
    /* Class that represents a food item that is added to an order */
    /***************************************************************/
    class FoodItem
    {
        private string name;
        private string image;
        private double price;

        public string Name { get => name; set => name = value; }
        public string Image { get => image; set => image = value; }
        public double Price { get => price; set => price = value; }

        public FoodItem()
        {
            this.name = "";
            this.image = "";
            this.price = 0;
        }

        public FoodItem(string name, string image, double price)
        {
            this.name = name;
            this.image = image;
            this.price = price;
        }

        public static List<FoodItem> ReadFoodData(string filePath)
        {
            List<FoodItem> foodList = new List<FoodItem>();
            string[] foodFileItems = { };
            try
            {
                foodFileItems = File.ReadAllLines(filePath);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File path not found. Please provide a different file");
            }
            foreach (string item in foodFileItems)
            {
                string[] itemSplit = item.Split(',');
                FoodItem nextItem = new FoodItem(itemSplit[0], itemSplit[1], Convert.ToDouble(itemSplit[2]));
                foodList.Add(nextItem);
            }
            return foodList;
        }
    }
}
