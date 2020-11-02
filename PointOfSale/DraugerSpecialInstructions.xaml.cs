/*
 * Author: Laura Legg
 * Class name: DraugrSpecialInstructions.xaml.cs
 * Purpose: Displays the Double Draugr's special instruction for a combo item
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
    /// Interaction logic for DraugerSpecialInstructions.xaml
    /// </summary>
    public partial class DraugerSpecialInstructions : UserControl
    {
        /// <summary>
        /// The constructor for the DraugerSpecialInstructions partial class.
        /// It sets the DataContext of the specialInstructions list view to a new Double Draugr.
        /// </summary>
        public DraugerSpecialInstructions()
        {
            InitializeComponent();
            specialInstructions.DataContext = new DoubleDraugr();
        }
    }
}
