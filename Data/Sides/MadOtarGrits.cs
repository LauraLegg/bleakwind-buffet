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
    public class MadOtarGrits : Side, IOrderItem
    {
        /// <summary>
        /// Gets the price of the side based on the size.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if price is not set for a certain size.
        /// </exception>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 1.22;
                if (Size == Size.Medium) return 1.58;
                if (Size == Size.Large) return 1.93;
                throw new NotImplementedException($"Price for {Size} Mad Otar Grits not found");
            }
        }

        /// <summary>
        /// Gets the number of calories based on the size.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the number of calories is not set for a certain size.
        /// </exception>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 105;
                if (Size == Size.Medium) return 142;
                if (Size == Size.Large) return 179;
                throw new NotImplementedException($"Calories for {Size} Mad Otar Grits not found");
            }
        }

        /// <summary>
        /// The size of the side.
        /// </summary>
        public override Size Size { get; set; } = Size.Small;

        /// <summary>
        /// If any of the ingredients are set to false, a hold 
        /// instruction is added to the special instructions list.
        /// </summary>
        public override List<string> SpecialInstructions => new List<string>();

        /// <summary>
        /// Overrides ToString() to return the name of the side.
        /// </summary>
        /// <returns>Returns the size and name of the side.</returns>
        public override string ToString()
        {
            return $"{Size} Mad Otar Grits";
        }
    }
}
