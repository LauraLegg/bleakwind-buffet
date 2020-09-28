using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkIngredients.xaml
    /// </summary>
    public partial class DrinkIngredients : UserControl
    {
        /// <summary>
        /// Holds the name of the entree button.
        /// </summary>
        private string itemName;

        /// <summary>
        /// Constructor for the drinks.
        /// </summary>
        /// <param name="item">The name of the drink button.</param>
        public DrinkIngredients(string item)
        {
            InitializeComponent();
            itemName = item;
            DrinksSpecialIngredients();
        }
        
        /// <summary>
        /// Method displaying the correct special ingredients
        /// </summary>
        void DrinksSpecialIngredients()
        {
            RadioButton small = new RadioButton();
            small.Content = "Small";
            ingredients.Items.Add(small);

            RadioButton medium = new RadioButton();
            medium.Content = "Medium";
            ingredients.Items.Add(medium);

            RadioButton large = new RadioButton();
            large.Content = "Large";
            ingredients.Items.Add(large);

            TextBlock space = new TextBlock();
            space.Text = "";
            ingredients.Items.Add(space);

            CheckBox ice = new CheckBox();
            ice.Content = "Ice";
            ingredients.Items.Add(ice);

            if (itemName == "sodaButton")
            {
                RadioButton blackberry = new RadioButton();
                blackberry.Content = "Blackberry";
                ingredients.Items.Add(blackberry);

                RadioButton cherry = new RadioButton();
                cherry.Content = "Cherry";
                ingredients.Items.Add(cherry);

                RadioButton grapefruit = new RadioButton();
                grapefruit.Content = "Grapefruit";
                ingredients.Items.Add(grapefruit);

                RadioButton lemon = new RadioButton();
                lemon.Content = "Lemon";
                ingredients.Items.Add(lemon);

                RadioButton peach = new RadioButton();
                peach.Content = "Peach";
                ingredients.Items.Add(peach);

                RadioButton watermelon = new RadioButton();
                watermelon.Content = "Watermelon";
                ingredients.Items.Add(watermelon);
            }

            else if (itemName == "coffeeButton")
            {
                CheckBox decaf = new CheckBox();
                decaf.Content = "Decaf";
                ingredients.Items.Add(decaf);

                CheckBox cream = new CheckBox();
                cream.Content = "Cream";
                ingredients.Items.Add(cream);
            }

            else if (itemName == "waterButton")
            {
                CheckBox lemon = new CheckBox();
                lemon.Content = "Lemon";
                ingredients.Items.Add(lemon);
            }
        }

    }
}
