/*
 * Author: Laura Legg
 * Class name: ComboControl
 * Purpose: Used to create a combo meal
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
    /// Interaction logic for ComboControl.xaml
    /// </summary>
    public partial class ComboControl : UserControl
    {
        /// <summary>
        /// Reference to the menu buttons control
        /// </summary>
        /// <remarks>
        /// Used to set the data context and return the the buttons screen.
        /// </remarks>
        MenuButtons buttons;

        /// <summary>
        /// the constructor for the combo control partial class
        /// </summary>
        /// <param name="buttons"></param>
        public ComboControl(MenuButtons buttons)
        {
            InitializeComponent();
            this.buttons = buttons;
        }

        /// <summary>
        /// Allows the buttons to switch between the appropriate screens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void comboButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button s)
            {
                if (s.Name == "onDragonBornWaffleFries")
                    SwitchScreen("Dragonborn Waffle Fries");
                else SwitchScreen((string)s.Content);
            }
        }

        /// <summary>
        /// Method for changing the screen to display the correct control.
        /// </summary>
        /// <param name="i"></param>
        public void SwitchScreen(string name)
        {
            switch (name)
            {
                case "Briarheart Burger":
                    comboControl.Child = new BriarheartBurgerControl(buttons);
                    break;
                case "Double Draugr":
                    comboControl.Child = new DoubleDraugrControl(buttons);
                    break;
                case "Thalmor Triple":
                    comboControl.Child = new ThalmorTripleControl(buttons);
                    break;
                case "Garden Orc Omelette":
                    comboControl.Child = new GardenOrcOmelettControl(buttons);
                    break;
                case "Philly Poacher":
                    comboControl.Child = new PhillyPoacherControl(buttons);
                    break;
                case "Smokehouse Skeleton":
                    comboControl.Child = new SmokehouseSkeletonControl(buttons);
                    break;
                case "Thugs T-Bone":
                    comboControl.Child = new ThugsTBoneControl(buttons);
                    break;

                case "Aretino Apple Juice":
                    comboControl.Child = new AretinoAppleJuiceControl(buttons);
                    break;
                case "Candlehearth Coffee":
                    comboControl.Child = new CandlehearthCoffeeControl(buttons);
                    break;
                case "Markarth Milk":
                    comboControl.Child = new MarkarthMilkControl(buttons);
                    break;
                case "Sailor Soda":
                    comboControl.Child = new SailorSodaControl(buttons);
                    break;
                case "Warrior Water":
                    comboControl.Child = new WarriorWaterControl(buttons);
                    break;

                case "Dragonborn Waffle Fries":
                    comboControl.Child = new DragonWaffleFriesControl(buttons);
                    break;
                case "Fried Miraak":
                    comboControl.Child = new FriedMiraakControl(buttons);
                    break;
                case "Mad Otar Grits":
                    comboControl.Child = new MadOtarGritsControl(buttons);
                    break;
                case "Vokun Salad":
                    comboControl.Child = new VokunSaladControl(buttons);
                    break;

                default:
                    comboControl.Child = new MenuButtons();
                    break;
            }

        }
    }
}
