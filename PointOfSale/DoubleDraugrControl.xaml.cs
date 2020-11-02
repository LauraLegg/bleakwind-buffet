/*
 * Author: Laura Legg
 * Class name: DoubleDraugrControl.xaml.cs
 * Purpose: Partial Class for DoubleDraugrControl xaml class.
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
    /// Interaction logic for DoubleDraugrControl.xaml
    /// </summary>
    public partial class DoubleDraugrControl : UserControl
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
        public DoubleDraugrControl(MenuButtons buttons)
        {
            InitializeComponent();
            this.buttons = buttons;
            DoubleDraugr burger = new DoubleDraugr();
            specialInstructions.DataContext = burger;
        }

        /// <summary>
        /// Switches the screen back when done button is 
        /// clicked and add the item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order && specialInstructions.DataContext is DoubleDraugr item)
            {
                order.Add(item);
            }

            buttons.SwitchScreen("");
        }
    }
}
