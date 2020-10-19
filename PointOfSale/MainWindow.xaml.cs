/*
 * Author: Laura Legg
 * Class name: MainWindow.cs
 * Purpose: Partial Class for the main window.
 */
using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// Constructor for the main window partial class
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Order();
        }

        /// <summary>
        /// Button for completeing the order.When pressed 
        /// it will redirect the user to a payment screen.
        /// </summary>
        /// <param name = "sender" ></ param >
        /// < param name="e"></param>
        void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            mainBorder.Child = new PaymentOptionsControl(mainBorder);
        }

        /// <summary>
        /// When pressed, this button will clear 
        /// the last order and start a new order.
        /// </summary>
        /// <param name = "sender" ></ param >
        /// < param name="e"></param>
        void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            mainBorder.Child = null;
            DataContext = new Order();
        }
    }
}
