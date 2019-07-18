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
        public MainForm()
        {
            InitializeComponent();
            List<FoodItem> food_list = FoodItem.ReadFoodData("..\\..\\FoodData\\food_data.txt");
            foreach(FoodItem item in food_list)
            {
                this.listBoxFoodItems.Items.Add(item.Name);
            }
        }

        private void listBoxFoodItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("You clicked " + listBoxFoodItems.SelectedItem.ToString());
        }

        private void listBoxFoodItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FoodItem item = new FoodItem(listBoxFoodItems.SelectedItem.ToString(), "test.png", 20);
            Console.WriteLine(item.Name + " added to order");
        }


    }
}
