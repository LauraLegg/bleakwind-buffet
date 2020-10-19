﻿/*
 * Author: Laura Legg
 * Class name: AretinoAppleJuiceControl.xaml.cs
 * Purpose: Partial Class for AretinoAppleJuiceControl xaml class.
 */
using BleakwindBuffet.Data;
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
    /// Interaction logic for AretinoAppleJuiceControl.xaml
    /// </summary>
    public partial class AretinoAppleJuiceControl : UserControl
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
        /// <param name="buttons"></param>
        public AretinoAppleJuiceControl(MenuButtons buttons)
        {
            InitializeComponent();
            this.buttons = buttons;
            AretinoAppleJuice drink = new AretinoAppleJuice();
            specialInstructions.DataContext = drink;
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
                AretinoAppleJuice drink = new AretinoAppleJuice();
                order.Add(drink);
            }

            buttons.SwitchScreen("");
        }
    }
}
