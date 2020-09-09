/*
 * Author: Laura Legg
 * Class name: Drink.cs
 * Purpose: Base class for all of the drink classes
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public abstract class Drink
    {
        /// <summary>
        /// Gets and sets the size of the drink
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the number of calories in the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets a list of special instructions
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
