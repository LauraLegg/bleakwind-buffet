/*
 * Author: Laura Legg
 * Class name: PPoacherSpecialInstructions.xaml.cs
 * Purpose: Displays the philly poacher's special instructions in the combo customization screen
 */
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
    /// Interaction logic for PPoacherSpecialInstructions.xaml
    /// </summary>
    public partial class PPoacherSpecialInstructions : UserControl
    {
        /// <summary>
        /// Constructor for the PPoacherSpecialInstructions partial class
        /// </summary>
        public PPoacherSpecialInstructions()
        {
            InitializeComponent();
            specialInstructions.DataContext = new PhillyPoacher();
        }
    }
}
