/*
 * Author: Laura Legg
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent Warrior Water.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater
    {
        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        public double Price => 0.00;

        /// <summary>
        /// Gets the calories for the drink.
        /// </summary>
        public uint Calories => 0;

        /// <summary>
        /// The size of the drink.
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Property is true when ice is included in the drink.
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Property is true when lemon is included in the drink.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// If any of the ingredients are set to false, a hold instruction is added to the special instructions list.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// Returns the size and name of the drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }
    }
}
