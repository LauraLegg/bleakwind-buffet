using BleakwindBuffet.Data.Sides;
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
        /// Reference the the Menubuttons so the screen can be switched back
        /// </summary>
        MenuButtons buttons;

        /// <summary>
        /// Holds the name of the side
        /// </summary>
        private string name;

        public object SpecialInstructions { get; private set; }

        /// <summary>
        /// Constructor for the sides partial class
        /// </summary>
        public SideIngredients(MenuButtons buttons, string name)
        {
            InitializeComponent();
            this.name = name;
            sideNameLabel.Content = name;
            this.buttons = buttons;
            SideSizeSetter();
        }

        /// <summary>
        /// Method for setting the size of the side
        /// </summary>
        void SideSizeSetter()
        {

            RadioButton small = new RadioButton();
            small.Content = "Small";
            specialInstructions.Items.Add(small);

            RadioButton medium = new RadioButton();
            medium.Content = "Medium";
            specialInstructions.Items.Add(medium);

            RadioButton large = new RadioButton();
            large.Content = "Large";
            specialInstructions.Items.Add(large);

            foreach (RadioButton b in specialInstructions.Items)
            {
                b.FontSize = 15;
            }
        }

        /// <summary>
        /// Switches the screen back to the menu buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            buttons.SwitchScreen(4, name);
        }
    }
}
