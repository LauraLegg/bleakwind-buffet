/*
 * Author: Laura Legg
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent an Aretino Apple Juice.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
    {
        /// <summary>
        /// Gets and sets the price of the drink based on the size.
        /// </summary>
        public double Price
        {
            get 
            {
                if (Size == Size.Small) return 0.62;
                if (Size == Size.Medium) return 0.87;
                if (Size == Size.Large) return 1.01;
                throw new NotImplementedException($"Price for {Size} Aretino Apple Juice not found");
            }
        }

        /// <summary>
        /// Gets and sets the calories based on the size.
        /// </summary>
        public uint Calories
        {
            get 
            {
                if (Size == Size.Small) return 44;
                if (Size == Size.Medium) return 88;
                if (Size == Size.Large) return 132;
                throw new NotImplementedException($"Calories for {Size} Aretino Apple Juice not found");
            }
        }

        /// <summary>
        /// The size of the drink.
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Property is true when ice is included in the drink.
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// If any of the ingredients are set to false, a hold instruction is added to the special instructions list.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Returns the size and name of the drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice";
        }
    }
}
