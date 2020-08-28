/*
 * Author: Laura Legg
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent Mad Otar Grits.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
    {
        /// <summary>
        /// Stores the price of the side based on the size.
        /// </summary>
        private double _price = 1.22;
        /// <summary>
        /// Gets and sets the price of the side based on the size.
        /// </summary>
        public double Price
        {
            get => _price;
            private set
            {
                if (Size == Size.Small) _price = 1.22;
                if (Size == Size.Medium) _price = 1.58;
                if (Size == Size.Large) _price = 1.93;
            }
        }

        /// <summary>
        /// Stores number of calories in the side based on the size.
        /// </summary>
        private uint _calories = 105;
        /// <summary>
        /// Gets and sets the calories based on the size.
        /// </summary>
        public uint Calories
        {
            get => _calories;
            private set
            {
                if (Size == Size.Small) _calories = 105;
                if (Size == Size.Medium) _calories = 142;
                if (Size == Size.Large) _calories = 179;
            }
        }

        /// <summary>
        /// The size of the side.
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// If any of the ingredients are set to false, a hold instruction is added to the special instructions list.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Returns the size and name of the side.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Mad Otar Grits";
        }
    }
}
