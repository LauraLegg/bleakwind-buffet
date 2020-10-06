/*
 * Author: Laura Legg
 * Class name: MarkarthMilkControl.xaml.cs
 * Purpose: Partial Class for MarkarthMilk xaml class.
 */
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
using BleakwindBuffet.Data.Drinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MarkarthMilkControl.xaml
    /// </summary>
    public partial class MarkarthMilkControl : UserControl
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
        public MarkarthMilkControl(MenuButtons buttons)
        {
            InitializeComponent();
            this.buttons = buttons;
            MarkarthMilk milk = new MarkarthMilk();
            buttons.DataContext = milk;
        }

        /// <summary>
        /// Switches the screen back when done button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            buttons.SwitchScreen("");
        }
    }
}
