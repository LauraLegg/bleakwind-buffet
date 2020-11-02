/*
 * Author: Laura Legg
 * Class name: VokunSaladControl.xaml.cs
 * Purpose: Partial Class for VokunSaladControl xaml class.
 */
using BleakwindBuffet.Data;
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
    /// Interaction logic for VokunSaladControl.xaml
    /// </summary>
    public partial class VokunSaladControl : UserControl
    {
        /// <summary>
        /// Reference to the menu buttons control
        /// </summary>
        /// <remarks>
        /// Used to set the data context and return the the buttons screen.
        /// </remarks>
        MenuButtons buttons;

        /// <summary>
        /// Constructor for the control
        /// </summary>
        /// <param name="buttons">the MenuButtons control that call this control</param>
        public VokunSaladControl(MenuButtons buttons)
        {
            InitializeComponent();
            this.buttons = buttons;
            VokunSalad salad = new VokunSalad();
            specialInstructions.DataContext = salad;
        }

        /// <summary>
        /// Switches the screen back when done button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order && specialInstructions.DataContext is VokunSalad item)
            {
                order.Add(item);
            }

            buttons.SwitchScreen("");
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
