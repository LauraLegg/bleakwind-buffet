/*
 * Author: Laura Legg
 * Class name: ThalmorTripleControl.xaml.cs
 * Purpose: Partial Class for ThalmorTripleControl xaml class.
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for ThalmorTripleControl.xaml
    /// </summary>
    public partial class ThalmorTripleControl : UserControl
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
        public ThalmorTripleControl(MenuButtons buttons)
        {
            InitializeComponent();
            this.buttons = buttons;
            ThalmorTriple burger = new ThalmorTriple();
            specialInstructions.DataContext = burger;
        }

        /// <summary>
        /// Switches the screen back when done button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var item = new ThalmorTriple();
                order.Add(item);
            }

            buttons.SwitchScreen("");
        }
    }
}
