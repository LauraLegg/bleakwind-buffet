/*
 * Author: Laura Legg
 * Class name: Menu.cs
 * Purpose: Static class used to contain instances of all available menu items.
 */
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public static class Menu
    {
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

        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            sides.Add(new DragonbornWaffleFries());
            sides.Add(new FriedMiraak());
            sides.Add(new MadOtarGrits());
            sides.Add(new VokunSalad());
            return sides;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            drinks.Add(new AretinoAppleJuice());
            drinks.Add(new CandlehearthCoffee());
            drinks.Add(new MarkarthMilk());
            drinks.Add(new SailorSoda());
            drinks.Add(new WarriorWater());
            return drinks;
        }

        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            menu.Add(new BriarheartBurger());
            menu.Add(new DoubleDraugr());
            menu.Add(new GardenOrcOmelette());
            menu.Add(new PhillyPoacher());
            menu.Add(new SmokehouseSkeleton());
            menu.Add(new ThalmorTriple());
            menu.Add(new ThugsTBone());
            menu.Add(new DragonbornWaffleFries());
            menu.Add(new FriedMiraak());
            menu.Add(new MadOtarGrits());
            menu.Add(new VokunSalad());
            menu.Add(new AretinoAppleJuice());
            menu.Add(new CandlehearthCoffee());
            menu.Add(new MarkarthMilk());
            menu.Add(new SailorSoda());
            menu.Add(new WarriorWater());
            return menu;
        }
    }
}
