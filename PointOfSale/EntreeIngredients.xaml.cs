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
            if (itemName == "thalmorButton" || itemName == "draugrButton" || itemName == "briarheartButton")
            {
                CheckBox bun = new CheckBox();
                bun.FontFamily = new FontFamily("arial");
                bun.FontSize = 20;
                bun.Content = "Bun";
                ingredients.Items.Add(bun);

                CheckBox ketchup = new CheckBox();
                ketchup.FontFamily = new FontFamily("arial");
                ketchup.FontSize = 20;
                ketchup.Content = "Ketchup";
                ingredients.Items.Add(ketchup);

                CheckBox mustard = new CheckBox();
                mustard.FontFamily = new FontFamily("arial");
                mustard.FontSize = 20;
                mustard.Content = "Mustard";
                ingredients.Items.Add(mustard);

                CheckBox pickles = new CheckBox();
                pickles.FontFamily = new FontFamily("arial");
                pickles.FontSize = 20;
                pickles.Content = "Pickles";
                ingredients.Items.Add(pickles);

                CheckBox cheese = new CheckBox();
                cheese.FontFamily = new FontFamily("arial");
                cheese.FontSize = 20;
                cheese.Content = "Cheese";
                ingredients.Items.Add(cheese);

                if (itemName == "thalmorButton" || itemName == "draugrButton")
                {
                    CheckBox tomato = new CheckBox();
                    tomato.FontFamily = new FontFamily("arial");
                    tomato.FontSize = 20;
                    tomato.Content = "Tomato";
                    ingredients.Items.Add(tomato);

                    CheckBox lettuce = new CheckBox();
                    lettuce.FontFamily = new FontFamily("arial");
                    lettuce.FontSize = 20;
                    lettuce.Content = "Lettuce";
                    ingredients.Items.Add(lettuce);

                    CheckBox mayo = new CheckBox();
                    mayo.FontFamily = new FontFamily("arial");
                    mayo.FontSize = 20;
                    mayo.Content = "Mayo";
                    ingredients.Items.Add(mayo);

                    if (itemName == "thalmorButton")
                    {
                        CheckBox bacon = new CheckBox();
                        bacon.FontFamily = new FontFamily("arial");
                        bacon.FontSize = 20;
                        bacon.Content = "Bacon";
                        ingredients.Items.Add(bacon);

                        CheckBox egg = new CheckBox();
                        egg.FontFamily = new FontFamily("arial");
                        egg.FontSize = 20;
                        egg.Content = "Egg";
                        ingredients.Items.Add(egg);
                    }
                }
            }

            else if (itemName == "skeletonButton")
            {
                CheckBox sausage = new CheckBox();
                sausage.FontFamily = new FontFamily("arial");
                sausage.FontSize = 20;
                sausage.Content = "Sausage Link";
                ingredients.Items.Add(sausage);

                CheckBox egg = new CheckBox();
                egg.FontFamily = new FontFamily("arial");
                egg.FontSize = 20;
                egg.Content = "Eggs";
                ingredients.Items.Add(egg);

                CheckBox hashBrowns = new CheckBox();
                hashBrowns.FontFamily = new FontFamily("arial");
                hashBrowns.FontSize = 20;
                hashBrowns.Content = "Hash Browns";
                ingredients.Items.Add(hashBrowns);

                CheckBox pancake = new CheckBox();
                pancake.FontFamily = new FontFamily("arial");
                pancake.FontSize = 20;
                pancake.Content = "Pancakes";
                ingredients.Items.Add(pancake);
            }

            else if (itemName == "omeletteButton")
            {
                CheckBox broccoli = new CheckBox();
                broccoli.FontFamily = new FontFamily("arial");
                broccoli.FontSize = 20;
                broccoli.Content = "Broccoli";
                ingredients.Items.Add(broccoli);

                CheckBox mushrooms = new CheckBox();
                mushrooms.Content = "Mushrooms";
                ingredients.Items.Add(mushrooms);

                CheckBox tomato = new CheckBox();
                tomato.FontFamily = new FontFamily("arial");
                tomato.FontSize = 20;
                tomato.Content = "Tomato";
                ingredients.Items.Add(tomato);

                CheckBox cheddar = new CheckBox();
                cheddar.FontFamily = new FontFamily("arial");
                cheddar.FontSize = 20;
                cheddar.Content = "Cheddar";
                ingredients.Items.Add(cheddar);
            }

            else if (itemName == "poacherButton")
            {
                CheckBox sirloin = new CheckBox();
                sirloin.FontFamily = new FontFamily("arial");
                sirloin.FontSize = 20;
                sirloin.Content = "Sirloin";
                ingredients.Items.Add(sirloin);

                CheckBox onion = new CheckBox();
                onion.FontFamily = new FontFamily("arial");
                onion.FontSize = 20;
                onion.Content = "Onion";
                ingredients.Items.Add(onion);

                CheckBox roll = new CheckBox();
                roll.FontFamily = new FontFamily("arial");
                roll.FontSize = 20;
                roll.Content = "Roll";
                ingredients.Items.Add(roll);
            }
        }
    }
}
