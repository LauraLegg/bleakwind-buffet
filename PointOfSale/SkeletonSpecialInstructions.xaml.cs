/*
 * Author: Laura Legg
 * Class name: SkeletonSpecialInstructions.xaml.cs
 * Purpose: Displays the special instruction for a smokehouse skeleton in the combo customization screen
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
    /// Interaction logic for SkeletonSpecialInstructions.xaml
    /// </summary>
    public partial class SkeletonSpecialInstructions : UserControl
    {
        /// <summary>
        /// Constructor for the SkeletonSpcialInstructions partial class
        /// </summary>
        public SkeletonSpecialInstructions()
        {
            InitializeComponent();
            specialInstructions.DataContext = new SmokehouseSkeleton();
        }
    }
}
