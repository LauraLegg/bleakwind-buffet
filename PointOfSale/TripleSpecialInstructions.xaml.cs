/*
 * Author: Laura Legg
 * Class name: TripleSpecialInstructions.xaml.cs
 * Purpose: Displays the special instructions for a thalmor triple in the combo customization screen
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
    /// Interaction logic for TripleSpecialInstructions.xaml
    /// </summary>
    public partial class TripleSpecialInstructions : UserControl
    {
        /// <summary>
        /// Constructor for TripleSpecialInstructions partial class
        /// </summary>
        public TripleSpecialInstructions()
        {
            InitializeComponent();
            specialInstructions.DataContext = new ThalmorTriple();
        }
    }
}
