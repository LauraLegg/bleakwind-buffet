/*
 * Author: Laura Legg
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent Fried Miraak.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak
    {
        /// <summary>
        /// Stores the price of the side based on the size.
        /// </summary>
        private double _price = 1.78;
        /// <summary>
        /// Gets and sets the price of the side based on the size.
        /// </summary>
        public double Price
        {
            get => _price;
            private set
            {
                if (Size == Size.Small) _price = 1.78;
                if (Size == Size.Medium) _price = 2.01;
                if (Size == Size.Large) _price = 2.88;
            }
        }

        /// <summary>
        /// Stores number of calories in the side based on the size.
        /// </summary>
        private uint _calories = 151;
        /// <summary>
        /// Gets and sets the calories based on the size.
        /// </summary>
        public uint Calories
        {
            get => _calories;
            private set
            {
                if (Size == Size.Small) _calories = 151;
                if (Size == Size.Medium) _calories = 236;
                if (Size == Size.Large) _calories = 306;
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
            return $"{Size} Fried Miraak";
        }
    }
}
