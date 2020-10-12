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
            ItemsOrdered.DataContext = new Order();
        }

    }
}
