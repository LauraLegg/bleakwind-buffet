/*
 * Author: Laura Legg
 * Class name: ItemsOrderedList.cs
 * Purpose: Partial Class for ItemsOrderedList xaml class.
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for ItemsOrderedList.xaml
    /// </summary>
    public partial class ItemsOrderedList : UserControl
    {
        /// <summary>
        /// Constructor for ItemsOrdered Control
        /// </summary>
        public ItemsOrderedList()
        {
            InitializeComponent();
        }

        void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order && sender is Button button && button.DataContext is IOrderItem item)
            {
                order.Remove(item);
            }
        }
    }
}
