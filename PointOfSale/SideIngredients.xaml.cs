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
    /// Interaction logic for SideIngredients.xaml
    /// </summary>
    public partial class SideIngredients : UserControl
    {
        /// <summary>
        /// Constructor for the sides
        /// </summary>
        public SideIngredients()
        {
            InitializeComponent();
            SideSizeSetter();
        }

        /// <summary>
        /// Method for setting the size of the side
        /// </summary>
        void SideSizeSetter()
        {
            RadioButton small = new RadioButton();
            small.Content = "Small";
            ingredients.Items.Add(small);

            RadioButton medium = new RadioButton();
            medium.Content = "Medium";
            ingredients.Items.Add(medium);

            RadioButton large = new RadioButton();
            large.Content = "Large";
            ingredients.Items.Add(large);
        }
    }
}
