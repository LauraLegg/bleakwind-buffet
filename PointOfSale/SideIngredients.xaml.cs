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
            small.FontFamily = new FontFamily("arial");
            small.FontSize = 20;
            small.Content = "Small";
            ingredients.Items.Add(small);

            TextBlock space = new TextBlock();
            space.Text = "";
            space.FontSize = 1;
            ingredients.Items.Add(space);

            RadioButton medium = new RadioButton();
            medium.FontFamily = new FontFamily("arial");
            medium.FontSize = 20;
            medium.Content = "Medium";
            ingredients.Items.Add(medium);

            TextBlock space2 = new TextBlock();
            space2.Text = "";
            space2.FontSize = 1;
            ingredients.Items.Add(space2);

            RadioButton large = new RadioButton();
            large.FontFamily = new FontFamily("arial");
            large.FontSize = 20;
            large.Content = "Large";
            ingredients.Items.Add(large);
        }
    }
}
