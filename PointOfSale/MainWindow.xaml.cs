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
        }

        /// <summary>
        /// Method find out if it needs to call the control entrees, drinks, or sides
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void clickEventHandler(object sender, RoutedEventArgs e)
        {
            Button s = (Button)sender;
            string item = s.Name;

            if(item == "briarheartButton" || item == "draugrButton" || item == "thalmorButton"
                || item == "skeletonButton" || item == "omeletteButton" || item == "poacherButton" || item == "tBoneButton")
            {
                mainBorder.Child = new EntreeIngredients(item);
            }
            else if (item == "sodaButton" || item == "milkButton" || item == "appleJuiceButton" || item == "coffeeButton" || item == "waterButton")
            {
                mainBorder.Child = new DrinkIngredients(item);
            }
            else if (item == "saladButton" || item == "miraakButton" || item == "gritsButton" || item == "friesButton")
            {
                mainBorder.Child = new SideIngredients();
            }
        }
    }
}
