using BleakwindBuffet.Data.Drinks;
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
    /// Interaction logic for AretinoAppleJuiceControl.xaml
    /// </summary>
    public partial class AretinoAppleJuiceControl : UserControl
    {
        MenuButtons buttons;

        public AretinoAppleJuiceControl(MenuButtons buttons)
        {
            InitializeComponent();
            this.buttons = buttons;
            AretinoAppleJuice drink = new AretinoAppleJuice();
            buttons.DataContext = drink;
        }

        void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            buttons.SwitchScreen(4, "Aretino Apple Juice");
        }
    }
}
