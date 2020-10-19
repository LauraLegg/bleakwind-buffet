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
        /// 
        /// </summary>
        Border border;

        /// <summary>
        /// Contructor for CashPaymentControl partial class
        /// </summary>
        public CashPaymentControl(Border border)
        {
            InitializeComponent();
            this.border = border;
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
    }
}
