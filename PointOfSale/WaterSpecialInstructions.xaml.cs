/*
 * Author: Laura Legg
 * Class name: WaterSpecialInstructions.xaml.cs
 * Purpose: Displays special instructions for water in the combo custimization screen
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
    /// Interaction logic for WaterSpecialInstructions.xaml
    /// </summary>
    public partial class WaterSpecialInstructions : UserControl
    {
        /// <summary>
        /// Constructor for the WaterSpecialInstructions partial class
        /// </summary>
        public WaterSpecialInstructions()
        {
            InitializeComponent();
            specialInstructions.DataContext = new WarriorWater();
        }

        /// <summary>
        /// Handles when a different size is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (specialInstructions.DataContext is WarriorWater drink)
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
