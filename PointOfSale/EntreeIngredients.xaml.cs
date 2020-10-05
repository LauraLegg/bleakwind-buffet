using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
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
    /// Interaction logic for EntreeIngredients.xaml
    /// </summary>
    public partial class EntreeIngredients : UserControl
    {
        /// <summary>
        /// Reference the the Menubuttons so the screen can be switched back
        /// </summary>
        MenuButtons buttons;

        /// <summary>
        /// Holds the name of the entree
        /// </summary>
        private string name;

        /// <summary>
        /// Contructor for the entree control.
        /// </summary>
        /// <param name="item">Name of the entree button</param>
        public EntreeIngredients(MenuButtons buttons, string name)
        {
            InitializeComponent();
            this.buttons = buttons;
            this.name = name;
            EntreeSpecialInstructions();
            entreeNameLabel.Content = name;
        }

        /// <summary>
        /// Switches screen back to menu buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            buttons.SwitchScreen(4, name);
        }

        /// <summary>
        /// Method finds and displays the correct list of special ingredients
        /// </summary>
        void EntreeSpecialInstructions()
        {
            if (name == "Briarheart Burger" || name == "Double Draugr" || name == "Thalmor Triple")
            {
                CheckBox bun = new CheckBox();
                bun.Content = "Bun";
                specialInstructions.Items.Add(bun);

                CheckBox ketchup = new CheckBox();
                ketchup.Content = "Ketchup";
                specialInstructions.Items.Add(ketchup);

                CheckBox mustard = new CheckBox();
                mustard.Content = "Mustard";
                specialInstructions.Items.Add(mustard);

                CheckBox pickles = new CheckBox();
                pickles.Content = "Pickles";
                specialInstructions.Items.Add(pickles);

                CheckBox cheese = new CheckBox();
                cheese.Content = "Cheese";
                specialInstructions.Items.Add(cheese);

                if (name == "Double Draugr" || name == "Thalmor Triple")
                {
                    CheckBox tomato = new CheckBox();
                    tomato.Content = "Tomato";
                    specialInstructions.Items.Add(tomato);

                    CheckBox lettuce = new CheckBox();
                    lettuce.Content = "Lettuce";
                    specialInstructions.Items.Add(lettuce);

                    CheckBox mayo = new CheckBox();
                    mayo.Content = "Mayo";
                    specialInstructions.Items.Add(mayo);

                    if (name == "onThalmorTriple")
                    {
                        CheckBox bacon = new CheckBox();
                        bacon.Content = "Bacon";
                        specialInstructions.Items.Add(bacon);

                        CheckBox egg = new CheckBox();
                        egg.Content = "Egg";
                        specialInstructions.Items.Add(egg);
                    }
                }
            }

            else if (name == "Smokehouse Skeleton")
            {
                CheckBox sausage = new CheckBox();
                sausage.Content = "Sausage Link";
                specialInstructions.Items.Add(sausage);

                CheckBox egg = new CheckBox();
                egg.Content = "Eggs";
                specialInstructions.Items.Add(egg);

                CheckBox hashBrowns = new CheckBox();
                hashBrowns.Content = "Hash Browns";
                specialInstructions.Items.Add(hashBrowns);

                CheckBox pancake = new CheckBox();
                pancake.Content = "Pancakes";
                specialInstructions.Items.Add(pancake);
            }

            else if (name == "Garden Orc Omelette")
            {
                CheckBox broccoli = new CheckBox();
                broccoli.Content = "Broccoli";
                specialInstructions.Items.Add(broccoli);

                CheckBox mushrooms = new CheckBox();
                mushrooms.Content = "Mushrooms";
                specialInstructions.Items.Add(mushrooms);

                CheckBox tomato = new CheckBox();
                tomato.Content = "Tomato";
                specialInstructions.Items.Add(tomato);

                CheckBox cheddar = new CheckBox();
                cheddar.Content = "Cheddar";
                specialInstructions.Items.Add(cheddar);
            }

            else if (name == "Philly Poacher")
            {
                CheckBox sirloin = new CheckBox();
                sirloin.Content = "Sirloin";
                specialInstructions.Items.Add(sirloin);

                CheckBox onion = new CheckBox();
                onion.Content = "Onion";
                specialInstructions.Items.Add(onion);

                CheckBox roll = new CheckBox();
                roll.Content = "Roll";
                specialInstructions.Items.Add(roll);
            }

            foreach (Control c in specialInstructions.Items)
            {
                c.FontSize = 15;
            }
        }
    }
}
