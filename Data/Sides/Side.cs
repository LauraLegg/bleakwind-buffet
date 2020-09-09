/*
 * Author: Laura Legg
 * Class name: Side.cs
 * Purpose: Base class for all of the side classes
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side
    {
        /// <summary>
        /// Gets and sets the size of the side
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the number of calories in the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets a list of special instructions
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
