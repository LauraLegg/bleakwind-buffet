/*
 * Author: Laura Legg
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly cheesesteak sandwich entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class PhillyPoacher
    {
        /// <summary>
        /// Gets the price for the sandwich.
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// Gets the calories for the sandwich.
        /// </summary>
        public uint Calories => 784;

        /// <summary>
        /// Property is true when Sirloin is to be added to the sandwich.
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// Property is true when Onion is to be added to the sandwich.
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// Property is true when the roll is to be added to the sandwich.
        /// </summary>
        public bool Roll { get; set; } = true;

        /// <summary>
        /// If any of the ingredients are set to false, a hold instruction is added to the special instructions list.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }

        /// <summary>
        /// Returns the name of the sandwich as a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
