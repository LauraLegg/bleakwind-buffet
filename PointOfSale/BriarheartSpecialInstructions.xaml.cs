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
    /// Interaction logic for BriarheartSpecialInstructions.xaml
    /// </summary>
    public partial class BriarheartSpecialInstructions : UserControl
    {
        /// <summary>
        /// Constructor for the burger special instructions.
        /// It sets the data context of the specialInstruction 
        /// listview to a new instance of a Briarheart Burger.
        /// </summary>
        public BriarheartSpecialInstructions()
        {
            InitializeComponent();
            specialInstructions.DataContext = new BriarheartBurger();
        }
    }
}
