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
            small.FontFamily = new FontFamily("arial");
            small.FontSize = 20;
            small.Content = "Small";
            ingredients.Items.Add(small);

            RadioButton medium = new RadioButton();
            medium.FontFamily = new FontFamily("arial");
            medium.FontSize = 20;
            medium.Content = "Medium";
            ingredients.Items.Add(medium);

            RadioButton large = new RadioButton();
            large.FontFamily = new FontFamily("arial");
            large.FontSize = 20;
            large.Content = "Large";
            ingredients.Items.Add(large);

            SpaceAdder();

            CheckBox ice = new CheckBox();
            ice.Content = "Ice";
            ice.FontFamily = new FontFamily("arial");
            ice.FontSize = 20;
            ingredients.Items.Add(ice);

            if (itemName == "sodaButton")
            {
                SpaceAdder();

                RadioButton blackberry = new RadioButton();
                blackberry.FontFamily = new FontFamily("arial");
                blackberry.FontSize = 20;
                blackberry.Content = "Blackberry";
                ingredients.Items.Add(blackberry);

                RadioButton cherry = new RadioButton();
                cherry.FontFamily = new FontFamily("arial");
                cherry.FontSize = 20;
                cherry.Content = "Cherry";
                ingredients.Items.Add(cherry);

                RadioButton grapefruit = new RadioButton();
                grapefruit.FontFamily = new FontFamily("arial");
                grapefruit.FontSize = 20;
                grapefruit.Content = "Grapefruit";
                ingredients.Items.Add(grapefruit);

                RadioButton lemon = new RadioButton();
                lemon.FontFamily = new FontFamily("arial");
                lemon.FontSize = 20;
                lemon.Content = "Lemon";
                ingredients.Items.Add(lemon);

                RadioButton peach = new RadioButton();
                peach.FontFamily = new FontFamily("arial");
                peach.FontSize = 20;
                peach.Content = "Peach";
                ingredients.Items.Add(peach);

                RadioButton watermelon = new RadioButton();
                watermelon.FontFamily = new FontFamily("arial");
                watermelon.FontSize = 20;
                watermelon.Content = "Watermelon";
                ingredients.Items.Add(watermelon);
            }

            else if (itemName == "coffeeButton")
            {
                CheckBox decaf = new CheckBox();
                decaf.FontFamily = new FontFamily("arial");
                decaf.FontSize = 20;
                decaf.Content = "Decaf";
                ingredients.Items.Add(decaf);

                CheckBox cream = new CheckBox();
                cream.FontFamily = new FontFamily("arial");
                cream.FontSize = 20;
                cream.Content = "Cream";
                ingredients.Items.Add(cream);
            }

            else if (itemName == "waterButton")
            {
                CheckBox lemon = new CheckBox();
                lemon.FontFamily = new FontFamily("arial");
                lemon.FontSize = 20;
                lemon.Content = "Lemon";
                ingredients.Items.Add(lemon);
            }
        }
        
        /// <summary>
        /// Method for adding a space between different check boxes / radio buttons.
        /// </summary>
        private void SpaceAdder()
        {
            TextBlock space = new TextBlock();
            space.Text = "";
            space.FontSize = 5;
            ingredients.Items.Add(space);
        }
    }
}
