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
        public MenuButtons()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Event handler for switching to entree ingredients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Entree_Click(object sender, RoutedEventArgs e)
        {
            Button s = (Button)sender;
            SwitchScreen(1, s.Name);   
        }

        /// <summary>
        /// Event handler for switching to drink ingredients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Drinks_Click(object sender, RoutedEventArgs e)
        {
            Button s = (Button)sender;
            SwitchScreen(2, s.Name);
        }

        /// <summary>
        /// Event handler for switching to side ingredients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Sides_Click(object sender, RoutedEventArgs e)
        {
            Button s = (Button)sender;
            SwitchScreen(3, s.Name);
        }

        /// <summary>
        /// Method for changing the screen to display the correct child.
        /// </summary>
        /// <param name="i"></param>
        public void SwitchScreen(int i, string name)
        {
            if (i == 1)
                menuButtonsControl.Child = new EntreeIngredients(this, name);
            else if (i == 2)
                menuButtonsControl.Child = new DrinkIngredients(this, name);
            else if (i == 3)
                menuButtonsControl.Child = new SideIngredients(this, name);
            else
                menuButtonsControl.Child = new MenuButtons();
        }


    }
}
