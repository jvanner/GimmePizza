using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimmePizza
{
    class FoodItem
    {
        private string name;
        private string image;
        private double price;

        public string Name { get => name; set => name = value; }
        public string Image { get => image; set => image = value; }
        public double Price { get => price; set => price = value; }

        public FoodItem(string name, string image, double price)
        {
            this.name = name;
            this.image = image;
            this.price = price;
        }
    }
}
