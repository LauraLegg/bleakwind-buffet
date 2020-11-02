/*
 * Author: Laura Legg
 * Class name: CoffeeSpecialInstructions.xaml.cs
 * Purpose: Used to display the special instruction for a Candlehearth Coffee in a combo.
 */
using BleakwindBuffet.Data.Drinks;
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
    /// Interaction logic for CoffeeSpecialInstructions.xaml
    /// </summary>
    public partial class CoffeeSpecialInstructions : UserControl
    {

        /// <summary>
        /// Constructor for the CoffeeSpecialInstruction partial class.
        /// It sets the DataContext of the specialInstructions list 
        /// view to a new instance of a Candlehearth Coffee.
        /// </summary>
        public CoffeeSpecialInstructions()
        {
            InitializeComponent();
            specialInstructions.DataContext = new CandlehearthCoffee();
        }

        /// <summary>
        /// Handles when a different size is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (specialInstructions.DataContext is CandlehearthCoffee drink)
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
    }
}
