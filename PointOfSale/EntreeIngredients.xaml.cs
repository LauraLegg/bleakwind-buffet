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
        /// Holds the name of the entree button.
        /// </summary>
        private string itemName;

        /// <summary>
        /// Contructor for the entree control.
        /// </summary>
        /// <param name="item">Name of the entree button</param>
        public EntreeIngredients(string item)
        {
            InitializeComponent();
            itemName = item;
            EntreeSpecialInstructions();

        }

        /// <summary>
        /// Method finds and displays the correct list of special ingredients
        /// </summary>
        void EntreeSpecialInstructions()
        {
            if (itemName == "briarheartButton")
            {
                CheckBox bun = new CheckBox();
                bun.Content = "Bun";
                bun.IsChecked = true;
                ingredients.Items.Add(bun);

                CheckBox ketchup = new CheckBox();
                ketchup.Content = "Ketchup";
                ketchup.IsChecked = true;
                ingredients.Items.Add(ketchup);

                CheckBox mustard = new CheckBox();
                mustard.Content = "Mustard";
                mustard.IsChecked = true;
                ingredients.Items.Add(mustard);

                CheckBox pickles = new CheckBox();
                pickles.Content = "Pickles";
                pickles.IsChecked = true;
                ingredients.Items.Add(pickles);

                CheckBox cheese = new CheckBox();
                cheese.Content = "Cheese";
                cheese.IsChecked = true;
                ingredients.Items.Add(cheese);
            }
            
            else if (itemName == "draugrButton")
            {
                CheckBox bun = new CheckBox();
                bun.Content = "Bun";
                bun.IsChecked = true;
                ingredients.Items.Add(bun);

                CheckBox ketchup = new CheckBox();
                ketchup.Content = "Ketchup";
                ketchup.IsChecked = true;
                ingredients.Items.Add(ketchup);

                CheckBox mustard = new CheckBox();
                mustard.Content = "Mustard";
                mustard.IsChecked = true;
                ingredients.Items.Add(mustard);

                CheckBox pickles = new CheckBox();
                pickles.Content = "Pickles";
                pickles.IsChecked = true;
                ingredients.Items.Add(pickles);

                CheckBox cheese = new CheckBox();
                cheese.Content = "Cheese";
                cheese.IsChecked = true;
                ingredients.Items.Add(cheese);

                CheckBox tomato = new CheckBox();
                tomato.Content = "Tomato";
                tomato.IsChecked = true;
                ingredients.Items.Add(tomato);

                CheckBox lettuce = new CheckBox();
                lettuce.Content = "Lettuce";
                lettuce.IsChecked = true;
                ingredients.Items.Add(lettuce);

                CheckBox mayo = new CheckBox();
                mayo.Content = "Mayo";
                mayo.IsChecked = true;
                ingredients.Items.Add(mayo);
            }

            else if (itemName == "thalmorButton")
            {
                CheckBox bun = new CheckBox();
                bun.Content = "Bun";
                bun.IsChecked = true;
                ingredients.Items.Add(bun);

                CheckBox ketchup = new CheckBox();
                ketchup.Content = "Ketchup";
                ketchup.IsChecked = true;
                ingredients.Items.Add(ketchup);

                CheckBox mustard = new CheckBox();
                mustard.Content = "Mustard";
                mustard.IsChecked = true;
                ingredients.Items.Add(mustard);

                CheckBox pickles = new CheckBox();
                pickles.Content = "Pickles";
                pickles.IsChecked = true;
                ingredients.Items.Add(pickles);

                CheckBox cheese = new CheckBox();
                cheese.Content = "Cheese";
                cheese.IsChecked = true;
                ingredients.Items.Add(cheese);

                CheckBox tomato = new CheckBox();
                tomato.Content = "Tomato";
                tomato.IsChecked = true;
                ingredients.Items.Add(tomato);

                CheckBox lettuce = new CheckBox();
                lettuce.Content = "Lettuce";
                lettuce.IsChecked = true;
                ingredients.Items.Add(lettuce);

                CheckBox mayo = new CheckBox();
                mayo.Content = "Mayo";
                mayo.IsChecked = true;
                ingredients.Items.Add(mayo);

                CheckBox bacon = new CheckBox();
                bacon.Content = "Bacon";
                bacon.IsChecked = true;
                ingredients.Items.Add(bacon);

                CheckBox egg = new CheckBox();
                egg.Content = "Egg";
                egg.IsChecked = true;
                ingredients.Items.Add(egg);
            }

            else if (itemName == "skeletonButton")
            {
                CheckBox sausage = new CheckBox();
                sausage.Content = "Sausage Link";
                sausage.IsChecked = true;
                ingredients.Items.Add(sausage);

                CheckBox egg = new CheckBox();
                egg.Content = "Eggs";
                egg.IsChecked = true;
                ingredients.Items.Add(egg);

                CheckBox hashBrowns = new CheckBox();
                hashBrowns.Content = "Hash Browns";
                hashBrowns.IsChecked = true;
                ingredients.Items.Add(hashBrowns);

                CheckBox pancake = new CheckBox();
                pancake.Content = "Pancakes";
                pancake.IsChecked = true;
                ingredients.Items.Add(pancake);
            }

            else if (itemName == "omeletteButton")
            {
                CheckBox broccoli = new CheckBox();
                broccoli.Content = "Broccoli";
                broccoli.IsChecked = true;
                ingredients.Items.Add(broccoli);

                CheckBox mushrooms = new CheckBox();
                mushrooms.Content = "Mushrooms";
                mushrooms.IsChecked = true;
                ingredients.Items.Add(mushrooms);

                CheckBox tomato = new CheckBox();
                tomato.Content = "Tomato";
                tomato.IsChecked = true;
                ingredients.Items.Add(tomato);

                CheckBox cheddar = new CheckBox();
                cheddar.Content = "Cheddar";
                cheddar.IsChecked = true;
                ingredients.Items.Add(cheddar);
            }

            else if (itemName == "poacherButton")
            {
                CheckBox sirloin = new CheckBox();
                sirloin.Content = "Sirloin";
                sirloin.IsChecked = true;
                ingredients.Items.Add(sirloin);

                CheckBox onion = new CheckBox();
                onion.Content = "Onion";
                onion.IsChecked = true;
                ingredients.Items.Add(onion);

                CheckBox roll = new CheckBox();
                roll.Content = "Roll";
                roll.IsChecked = true;
                ingredients.Items.Add(roll);
            }

            else if (itemName == "tBoneButton")
            {

            }
        }
    }
}
