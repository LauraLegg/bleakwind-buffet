/*
 * Author: Laura Legg
 * Class name: SodaSpecialInstructions.xaml.cs
 * Purpose: Displays the special instructions for the sailor soda in the combo selection screen
 */
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
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
    /// Interaction logic for SodaSpecialInstructions.xaml
    /// </summary>
    public partial class SodaSpecialInstructions : UserControl
    {
        /// <summary>
        /// Constructor for the SodaSpecialInstructions partial class
        /// </summary>
        public SodaSpecialInstructions()
        {
            InitializeComponent();
            specialInstructions.DataContext = new SailorSoda();
        }

        /// <summary>
        /// Handles when a different size is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (specialInstructions.DataContext is SailorSoda drink)
            {
                if (comboBox.SelectedItem == Small)
                {
                    drink.Size = BleakwindBuffet.Data.Enums.Size.Small;
                }
                else if (comboBox.SelectedItem == Medium)
                {
                    drink.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                }
                else if (comboBox.SelectedItem == Large)
                {
                    drink.Size = BleakwindBuffet.Data.Enums.Size.Large;
                }
            }
        }

        /// <summary>
        /// Handles when a different flavor is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Flavor_ComboBoxSelection(object sender, SelectionChangedEventArgs e)
        {
            if (specialInstructions.DataContext is SailorSoda drink)
            {
                if (flavorComboBox.SelectedItem == Blackberry)
                {
                    drink.Flavor = SodaFlavor.Blackberry;
                }
                else if (flavorComboBox.SelectedItem == Cherry)
                {
                    drink.Flavor = SodaFlavor.Cherry;
                }
                else if (flavorComboBox.SelectedItem == Grapefuit)
                {
                    drink.Flavor = SodaFlavor.Grapefruit;
                }
                else if (flavorComboBox.SelectedItem == Lemon)
                {
                    drink.Flavor = SodaFlavor.Lemon;
                }
                else if (flavorComboBox.SelectedItem == Peach)
                {
                    drink.Flavor = SodaFlavor.Peach;
                }
                else if (flavorComboBox.SelectedItem == Watermelon)
                {
                    drink.Flavor = SodaFlavor.Watermelon;
                }
            }
        }
    }
}
