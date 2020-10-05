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
    /// Interaction logic for BriarheartBurger.xaml
    /// </summary>
    public partial class BriarheartBurger : UserControl
    {
        /// <summary>
        /// Reference the the Menubuttons so the screen can be switched back
        /// </summary>
        MenuButtons buttons;

        string name = "Briarheart Burger";

        public BriarheartBurger()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Switches screen back to menu buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            buttons.SwitchScreen(4, name);
        }
    }
}
