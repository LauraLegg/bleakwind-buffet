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
        MenuButtons buttons;

        private string name;

        /// <summary>
        /// Constructor for the drinks.
        /// </summary>
        /// <param name="item">The name of the drink button.</param>
        public DrinkIngredients(MenuButtons buttons, string name)
        {
            InitializeComponent();
            this.name = name;
            this.buttons = buttons;
            DrinksSpecialIngredients();
        }

        /// <summary>
        /// Event handler for the done button. Switches screen back to menu buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneButton_Click(object sender, RoutedEventArgs e)
        {
           buttons.SwitchScreen(4, name);
        }


        /// <summary>
        /// Method displaying the correct special ingredients
        /// </summary>
        void DrinksSpecialIngredients()
        {
            RadioButton small = new RadioButton();
            small.Content = "Small";
            specialInstructions.Items.Add(small);

            RadioButton medium = new RadioButton();
            medium.Content = "Medium";
            specialInstructions.Items.Add(medium);

            RadioButton large = new RadioButton();
            large.Content = "Large";
            specialInstructions.Items.Add(large);

            CheckBox ice = new CheckBox();
            ice.Content = "Ice";
            specialInstructions.Items.Add(ice);
            
            if (name == "onSailorSoda")
            {

                RadioButton blackberry = new RadioButton();
                blackberry.Content = "Blackberry";
                specialInstructions.Items.Add(blackberry);

                RadioButton cherry = new RadioButton();
                cherry.Content = "Cherry";
                specialInstructions.Items.Add(cherry);

                RadioButton grapefruit = new RadioButton();
                grapefruit.Content = "Grapefruit";
                specialInstructions.Items.Add(grapefruit);

                RadioButton lemon = new RadioButton();
                lemon.Content = "Lemon";
                specialInstructions.Items.Add(lemon);

                RadioButton peach = new RadioButton();
                peach.Content = "Peach";
                specialInstructions.Items.Add(peach);

                RadioButton watermelon = new RadioButton();
                watermelon.Content = "Watermelon";
                specialInstructions.Items.Add(watermelon);
            }

            else if (name == "onCandlehearthCoffee")
            {
                CheckBox decaf = new CheckBox();
                decaf.Content = "Decaf";
                specialInstructions.Items.Add(decaf);

                CheckBox cream = new CheckBox();
                cream.Content = "Cream";
                specialInstructions.Items.Add(cream);
            }

            else if (name == "onWarriorWater")
            {
                CheckBox lemon = new CheckBox();
                lemon.Content = "Lemon";
                specialInstructions.Items.Add(lemon);
            }
        }
    }
}
