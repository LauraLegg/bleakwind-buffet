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
    /// Interaction logic for MenuButtons.xaml
    /// </summary>
    public partial class MenuButtons : UserControl
    {
        /// <summary>
        /// Constructor for menu buttons partial class
        /// </summary>
        public MenuButtons()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Switches to entree ingredients control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Entree_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button s)
                SwitchScreen(1, (string)s.Content);   
        }

        /// <summary>
        /// Switches to drink ingredients control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Drinks_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button s)
                SwitchScreen(2, (string)s.Content);
        }

        /// <summary>
        /// Switches to side ingredients control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Sides_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button s)
            {
                if (s.Name == "onDragonBornWaffleFries") SwitchScreen(3, "Dragonborn Waffle Fries");
                else SwitchScreen(3, (string)s.Content);
            }
        }

        /// <summary>
        /// Method for changing the screen to display the correct control.
        /// </summary>
        /// <param name="i"></param>
        public void SwitchScreen(int i, string name)
        {
            if (i == 1)
                menuButtonsControl.Child = new EntreeIngredients(this, name);
            else if (i == 2)
                if (name == "Aretino Apple Juice") menuButtonsControl.Child = new AretinoAppleJuiceControl(this);
                else menuButtonsControl.Child = new DrinkIngredients(this, name);
            else if (i == 3)
                menuButtonsControl.Child = new SideIngredients(this, name);
            else
                menuButtonsControl.Child = new MenuButtons();
        }
    }
}
