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
        /// Gets the price of the side based on the size.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if price is not set for a certain size.
        /// </exception>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 1.78;
                if (Size == Size.Medium) return 2.01;
                if (Size == Size.Large) return 2.88;
                throw new NotImplementedException($"Price for {Size} Fried Miraak not found");
            }
        }

        /// <summary>
        /// Gets the number of calories based on the size.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if number of calories is not set for a certain size.
        /// </exception>
        public uint Calories
        {
            get 
            {
                if (Size == Size.Small) return 151;
                if (Size == Size.Medium) return 236;
                if (Size == Size.Large) return 306;
                throw new NotImplementedException($"Calories for {Size} Fried Miraak not found");
            }
        }

        /// <summary>
        /// The size of the side.
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// If any of the ingredients are set to false, a hold instruction is added to the special instructions list.
        /// </summary>
        /*
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }
        */

        /// <summary>
        /// Overrides ToString() to return the name of the side.
        /// </summary>
        /// <returns>Returns the size and name of the side.</returns>
        public override string ToString()
        {
            return $"{Size} Fried Miraak";
        }
    }
}
