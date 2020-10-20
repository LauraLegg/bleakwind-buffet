/*
 * Author: Laura Legg
 * Class name: ChangeQuantityControl.xaml.cs
 * Purpose: Control couting how many of one type of bill or coin is recieved
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
    /// Interaction logic for ChangeQuantityControl.xaml
    /// </summary>
    public partial class ChangeQuantityControl : UserControl
    {
        /// <summary>
        /// The number of bills or coins this control is representing
        /// </summary>
        private int val = 0;

        /// <summary>
        /// The constructor
        /// </summary>
        public ChangeQuantityControl()
        {
            InitializeComponent();
            numberBox.Text = val.ToString();
        }

        /// <summary>
        /// Button to increment the displayed number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddButton_Click(object sender, RoutedEventArgs e)
        {
            val++;
            numberBox.Text = val.ToString();
        }

        /// <summary>
        /// Button to decrement the displayed number, will not go past zero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            val--;
            if (val < 0)
                val = 0;
            numberBox.Text = val.ToString();
        }
    }
}
