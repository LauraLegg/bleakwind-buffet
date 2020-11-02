/*
 * Author: Laura Legg
 * Class name: TBoneSpecialInstructions.xaml.cs
 * Purpose: Displays the special instructions for Thugs T-Bone in the combo customization screen
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
    /// Interaction logic for TBoneSpecialInstructions.xaml
    /// </summary>
    public partial class TBoneSpecialInstructions : UserControl
    {
        /// <summary>
        /// Constructor for the TBoneSpecialInstructions partial class
        /// </summary>
        public TBoneSpecialInstructions()
        {
            InitializeComponent();
            specialInstructions.DataContext = new ThugsTBone();
        }
    }
}
