/*
 * Author: Laura Legg
 * Class name: ComboControl
 * Purpose: Used to create a combo meal
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
        /// The combo that will be added to the order
        /// </summary>
        private MealCombos combo = new MealCombos();

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
        void comboButtonClick(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox s)
            {
                if (s.SelectedItem == BBurger)
                    SwitchScreen("BriarheartBurger");
                else if (s.SelectedItem == DDraugr)
                    SwitchScreen("DoubleDraugr");
                else if (s.SelectedItem == TTriple)
                    SwitchScreen("ThalmorTriple");
                else if (s.SelectedItem == OrcOmlette)
                    SwitchScreen("GardenOrcOmelette");
                else if (s.SelectedItem == PPoacher)
                    SwitchScreen("PhillyPoacher");
                else if (s.SelectedItem == SSkeleton)
                    SwitchScreen("SmokehouseSkeleton");
                else if (s.SelectedItem == TTBone)
                    SwitchScreen("ThugsTBone");

                else if (s.SelectedItem == AAJuice)
                    SwitchScreen("ArentinoAppleJuice");
                else if (s.SelectedItem == Coffee)
                    SwitchScreen("CandlehearthCoffee");
                else if (s.SelectedItem == Milk)
                    SwitchScreen("MarkarthMilk");
                else if (s.SelectedItem == Soda)
                    SwitchScreen("SailorSoda");
                else if (s.SelectedItem == Water)
                    SwitchScreen("WarriorWater");

                else if (s.SelectedItem == DBWaffleFries)
                    SwitchScreen("DragonbornWaffleFries");
                else if (s.SelectedItem == Miraak)
                    SwitchScreen("FriedMiraak");
                else if (s.SelectedItem == Grits)
                    SwitchScreen("MadOtarGrits");
                else if (s.SelectedItem == Salad)
                    SwitchScreen("VokunSalad");
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
                case "BriarheartBurger":
                    BriarheartSpecialInstructions b = new BriarheartSpecialInstructions();
                    controlBox.Child = b;
                    combo.Entree = b.specialInstructions.DataContext as BriarheartBurger;
                    break;
                case "DoubleDraugr":
                    DraugerSpecialInstructions draugr = new DraugerSpecialInstructions();
                    controlBox.Child = draugr;
                    combo.Entree = draugr.specialInstructions.DataContext as DoubleDraugr;
                    break;
                case "ThalmorTriple":
                    TripleSpecialInstructions thalmor = new TripleSpecialInstructions();
                    controlBox.Child = thalmor;
                    combo.Entree = thalmor.specialInstructions.DataContext as ThalmorTriple;
                    break;
                case "GardenOrcOmelette":
                    GOOmeletteSpecialInstructions omelette = new GOOmeletteSpecialInstructions();
                    controlBox.Child = omelette;
                    combo.Entree = omelette.specialInstructions.DataContext as GardenOrcOmelette;
                    break;
                case "PhillyPoacher":
                    PPoacherSpecialInstructions poacher = new PPoacherSpecialInstructions();
                    controlBox.Child = poacher;
                    combo.Entree = poacher.specialInstructions.DataContext as PhillyPoacher;
                    break;
                case "SmokehouseSkeleton":
                    SkeletonSpecialInstructions skeleton = new SkeletonSpecialInstructions();
                    controlBox.Child = skeleton;
                    combo.Entree = skeleton.specialInstructions.DataContext as SmokehouseSkeleton;
                    break;
                case "ThugsTBone":
                    TBoneSpecialInstructions tBone = new TBoneSpecialInstructions();
                    controlBox.Child = tBone;
                    combo.Entree = tBone.specialInstructions.DataContext as ThugsTBone;
                    break;


                case "ArentinoAppleJuice":
                    AretinoAppleJuiceSpecialInstructions drink = new AretinoAppleJuiceSpecialInstructions();
                    controlBox.Child = drink;
                    combo.Drink = drink.specialInstructions.DataContext as AretinoAppleJuice;
                    break;
                case "CandlehearthCoffee":
                    CoffeeSpecialInstructions coffee = new CoffeeSpecialInstructions();
                    controlBox.Child = coffee;
                    combo.Drink = coffee.specialInstructions.DataContext as CandlehearthCoffee;
                    break;
                case "MarkarthMilk":
                    MilkSpecialInstructions milk = new MilkSpecialInstructions();
                    controlBox.Child = milk;
                    combo.Drink = milk.specialInstructions.DataContext as MarkarthMilk;
                    break;
                case "SailorSoda":
                    SodaSpecialInstructions soda = new SodaSpecialInstructions();
                    controlBox.Child = soda;
                    combo.Drink = soda.specialInstructions.DataContext as SailorSoda;
                    break;
                case "WarriorWater":
                    WaterSpecialInstructions water = new WaterSpecialInstructions();
                    controlBox.Child = water;
                    combo.Drink = water.specialInstructions.DataContext as WarriorWater;
                    break;


                case "DragonbornWaffleFries":
                    DBWFriesSpecialInstructions fries = new DBWFriesSpecialInstructions();
                    controlBox.Child = fries;
                    combo.Side = fries.specialInstructions.DataContext as DragonbornWaffleFries;
                    break;
                case "FriedMiraak":
                    FriedMiraakSpecialInstructions miraak = new FriedMiraakSpecialInstructions();
                    controlBox.Child = miraak;
                    combo.Side = miraak.specialInstructions.DataContext as FriedMiraak;
                    break;
                case "MadOtarGrits":
                    MOGritsSpecialInstructions grits = new MOGritsSpecialInstructions();
                    controlBox.Child = grits;
                    combo.Side = grits.specialInstructions.DataContext as MadOtarGrits;
                    break;
                case "VokunSalad":
                    VokunSaladSpecialInstructions salad = new VokunSaladSpecialInstructions();
                    controlBox.Child = salad;
                    combo.Side = salad.specialInstructions.DataContext as VokunSalad;
                    break;

                default:
                    comboControl.Child = new MenuButtons();
                    break;
            }

        }

        /// <summary>
        /// Switches the screen back when done button is clicked and adds the combo to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(combo);
            }

            buttons.SwitchScreen("");
        }
    }
}
