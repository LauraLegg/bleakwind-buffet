/*
 * Author: Laura Legg
 * Class name: GOOmeletteSpecialInstructions.xaml.cs
 * Purpose: Displays the special instructions a Garden Orc Omelette in the combo custumization screen.
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
    /// Interaction logic for GOOmeletteSpecialInstructions.xaml
    /// </summary>
    public partial class GOOmeletteSpecialInstructions : UserControl
    {
        /// <summary>
        /// Constructor for the GOOmeletteSpecialInstructions partial class
        /// </summary>
        public GOOmeletteSpecialInstructions()
        {
            InitializeComponent();
            specialInstructions.DataContext = new GardenOrcOmelette();
        }
    }
}
