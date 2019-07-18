using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GimmePizza
{
    public partial class MainForm : Form
    {
        Order current_order = new Order();
        public MainForm()
        {
            InitializeComponent();
            List<FoodItem> food_list = FoodItem.ReadFoodData("..\\..\\FoodData\\food_data.txt");
            foreach(FoodItem item in food_list)
            {
                this.listBoxFoodItems.Items.Add(item.Name + ", " + item.Price);
            }
            this.listBoxCurrentOrder.Items.Clear();
        }

        private void listBoxFoodItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("You clicked " + listBoxFoodItems.SelectedItem.ToString().Split(',')[0]);
        }

        private void listBoxFoodItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string[] foodString = listBoxFoodItems.SelectedItem.ToString().Split(',');
            FoodItem new_item = new FoodItem(foodString[0], "test.png", Convert.ToDouble(foodString[1]));
            current_order.item_list.Add(new_item);
            Console.WriteLine(new_item.Name + " added to order");
            Console.WriteLine("Total Price: " + current_order.getPrice().ToString());
            this.listBoxCurrentOrder.Items.Clear();
            foreach (FoodItem item in current_order.item_list)
            {
                this.listBoxCurrentOrder.Items.Add(item.Name + ", " + item.Price);
            }
        }
    }
}
