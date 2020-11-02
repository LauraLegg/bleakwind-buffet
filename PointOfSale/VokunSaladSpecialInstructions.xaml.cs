/*
 * Author: Laura Legg
 * Class name: VokunSaladSpecialInstructions.xaml.cs
 * Purpose: Displays the special instructions for a vokun salad in the combo customization screen
 */
using BleakwindBuffet.Data.Sides;
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
    /// Interaction logic for VokunSaladSpecialInstructions.xaml
    /// </summary>
    public partial class VokunSaladSpecialInstructions : UserControl
    {
        /// <summary>
        /// Constructor for the VokunSaladSpecialInstructions partial class
        /// </summary>
        public VokunSaladSpecialInstructions()
        {
            InitializeComponent();
            specialInstructions.DataContext = new VokunSalad();
        }

        /// <summary>
        /// Handles when a different size is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (specialInstructions.DataContext is VokunSalad side)
            {
                if (comboBox.SelectedItem == Small)
                {
                    side.Size = BleakwindBuffet.Data.Enums.Size.Small;
                }
                else if (comboBox.SelectedItem == Medium)
                {
                    side.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                }
                else if (comboBox.SelectedItem == Large)
                {
                    side.Size = BleakwindBuffet.Data.Enums.Size.Large;
                }
            }
        }
    }
}
