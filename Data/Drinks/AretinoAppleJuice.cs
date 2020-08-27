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
        /// Stores the price of the drink based on the size.
        /// </summary>
        private double _price = 0.62;
        /// <summary>
        /// Gets and sets the price of the drink based on the size.
        /// </summary>
        public double Price
        {
            get => _price;
            private set
            {
                if (Size == Size.Small) _price = 0.62;
                if (Size == Size.Medium) _price = 0.87;
                if (Size == Size.Large) _price = 1.01;
            }
        }

        /// <summary>
        /// Stores number of calories in the drink based on the size.
        /// </summary>
        private uint _calories = 44;
        /// <summary>
        /// Gets and sets the calories based on the size.
        /// </summary>
        public uint Calories
        {
            get => _calories;
            private set
            {
                if (Size == Size.Small) _calories = 44;
                if (Size == Size.Medium) _calories = 88;
                if (Size == Size.Large) _calories = 132;
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
