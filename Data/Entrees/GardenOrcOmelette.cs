/*
 * Author: Laura Legg
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price for the entree.
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// Gets the number calories in the entree.
        /// </summary>
        public override  uint Calories => 404;

        /// <summary>
        /// Property is true when broccoli is to be added to the entree.
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// Property is true when mushrooms are to be added to the entree.
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// Property is true when tomato is to be added to the entree.
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Property is true when cheddar is to be added to the entree.
        /// </summary>
        public bool Cheddar { get; set; } = true;

        /// <summary>
        /// If any of the ingredients are set to false, a hold instruction is added to the special instructions list.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString() to return the name of the entree.
        /// </summary>
        /// <returns>Returns the name of the entree.</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
