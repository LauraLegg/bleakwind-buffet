/*
 * Author: Laura Legg
 * Class name: CashPaymentControl.xaml.cs
 * Purpose: Partial Class for CashPaymentControl xaml class.
 */
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
    /// Interaction logic for CashPaymentControl.xaml
    /// </summary>
    public partial class CashPaymentControl : UserControl
    {
        /// <summary>
        /// The border containing the payment screens
        /// </summary>
        private Border border;

        /// <summary>
        /// Contructor for CashPaymentControl partial class
        /// </summary>
        public CashPaymentControl(Border border)
        {
            InitializeComponent();
            this.border = border;
            LabelControls();
        }

        /// <summary>
        /// When clicked, it will finalizing the sale, 
        /// print the recipt, and create a new order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CompleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// When clicked, it will return to the menu buttons screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            border.Child = null;
        }

        /// <summary>
        /// Adds content to each control's cashAmount label
        /// </summary>
        private void LabelControls()
        {
            hundreds.cashAmount.Content = "$100";
            fifties.cashAmount.Content = "$50";
            twenties.cashAmount.Content = "$20";
            tens.cashAmount.Content = "$10";
            fives.cashAmount.Content = "$5";
            twos.cashAmount.Content = "$2";
            ones.cashAmount.Content = "$1";

            onesCoin.cashAmount.Content = "$1";
            fiftyCent.cashAmount.Content = "50c";
            twentyfiveCent.cashAmount.Content = "25c";
            tenCent.cashAmount.Content = "10c";
            fiveCent.cashAmount.Content = "5c";
            oneCent.cashAmount.Content = "1c";
        }
    }
}
