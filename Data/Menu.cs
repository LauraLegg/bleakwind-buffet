/*
 * Author: Laura Legg
 * Class name: Menu.cs
 * Purpose: Static class used to contain instances of all available menu items.
 */
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    public class Menu : INotifyPropertyChanged
    {
        /// <summary>
        /// Event that keeps track of when properties are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// A method that returns a list of instances of each entree item 
        /// </summary>
        /// <returns>Returns list of each entree item</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());
            return entrees;
        }

        /// <summary>
        /// A method that returns a list of instances of each side item 
        /// </summary>
        /// <returns>Returns list of each side item</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                sides.Add(new DragonbornWaffleFries()
                {
                    Size = size
                });
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                sides.Add(new FriedMiraak()
                {
                    Size = size
                });
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                sides.Add(new MadOtarGrits()
                {
                    Size = size
                });
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                sides.Add(new VokunSalad()
                {
                    Size = size
                });
            }
            return sides;
        }

        /// <summary>
        /// A method that returns a list of instances of each drink item 
        /// </summary>
        /// <returns>Returns a list of each drink item</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                drinks.Add(new AretinoAppleJuice()
                {
                    Size = size
                });
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                drinks.Add(new CandlehearthCoffee()
                {
                    Decaf = false,
                    Size = size
                });
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                drinks.Add(new CandlehearthCoffee()
                {
                    Decaf = true,
                    Size = size
                });
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                drinks.Add(new MarkarthMilk()
                {
                    Size = size
                });
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                foreach (SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    drinks.Add(new SailorSoda()
                    {
                        Size = size,
                        Flavor = flavor
                    });
                }
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                drinks.Add(new WarriorWater()
                {
                    Size = size
                });
            }
            return drinks;
        }

        /// <summary>
        /// A method that returns a list of instances of each food or drink item 
        /// </summary>
        /// <returns>Returns a list of each food or drink item</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            List<IOrderItem> entrees = (List<IOrderItem>) Entrees();
            List<IOrderItem> sides = (List<IOrderItem>)Sides();
            List<IOrderItem> drinks = (List<IOrderItem>) Drinks();

            menu.AddRange(entrees);
            menu.AddRange(sides);
            menu.AddRange(drinks);

            return menu;
        }
    }
}