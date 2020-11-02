/*
 * Author: Laura Legg
 * Class name: MenuButtons.xaml.cs
 * Purpose: Partial Class for MenuButtons xaml class.
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
    /// Interaction logic for MenuButtons.xaml
    /// </summary>
    public partial class MenuButtons : UserControl
    {
        /// <summary>
        /// Constructor for menu buttons partial class
        /// </summary>
        public MenuButtons()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Allows the buttons to switch between the appropriate screens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void menuButtonClick (object sender, RoutedEventArgs e)
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
                    menuButtonsControl.Child = new BriarheartBurgerControl(this);
                    break;
                case "Double Draugr":
                    menuButtonsControl.Child = new DoubleDraugrControl(this);
                    break;
                case "Thalmor Triple":
                    menuButtonsControl.Child = new ThalmorTripleControl(this);
                    break;
                case "Garden Orc Omelette":
                    menuButtonsControl.Child = new GardenOrcOmelettControl(this);
                    break;
                case "Philly Poacher":
                    menuButtonsControl.Child = new PhillyPoacherControl(this);
                    break;
                case "Smokehouse Skeleton":
                    menuButtonsControl.Child = new SmokehouseSkeletonControl(this);
                    break;
                case "Thugs T-Bone":
                    menuButtonsControl.Child = new ThugsTBoneControl(this);
                    break;

                case "Aretino Apple Juice":
                    menuButtonsControl.Child = new AretinoAppleJuiceControl(this);
                    break;
                case "Candlehearth Coffee":
                    menuButtonsControl.Child = new CandlehearthCoffeeControl(this);
                    break;
                case "Markarth Milk":
                    menuButtonsControl.Child = new MarkarthMilkControl(this);
                    break;
                case "Sailor Soda":
                    menuButtonsControl.Child = new SailorSodaControl(this);
                    break;
                case "Warrior Water":
                    menuButtonsControl.Child = new WarriorWaterControl(this);
                    break;

                case "Dragonborn Waffle Fries":
                    menuButtonsControl.Child = new DragonWaffleFriesControl(this);
                    break;
                case "Fried Miraak":
                    menuButtonsControl.Child = new FriedMiraakControl(this);
                    break;
                case "Mad Otar Grits":
                    menuButtonsControl.Child = new MadOtarGritsControl(this);
                    break;
                case "Vokun Salad":
                    menuButtonsControl.Child = new VokunSaladControl(this);
                    break;

                case "Create Combo":
                    menuButtonsControl.Child = new ComboControl(this);
                    break;

                default:
                    menuButtonsControl.Child = new MenuButtons();
                    break;
            }

        }
    }
}
