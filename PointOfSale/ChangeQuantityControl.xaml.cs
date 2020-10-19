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
        int val = 0;

        public ChangeQuantityControl()
        {
            InitializeComponent();
            numberBox.Text = val.ToString();
        }

        void AddButton_Click(object sender, RoutedEventArgs e)
        {
            val++;
            numberBox.Text = val.ToString();
        }

        void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            val--;
            if (val < 0)
                val = 0;
            numberBox.Text = val.ToString();
        }
    }
}
