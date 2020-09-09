/*
 * Author: Laura Legg
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the Double Draugr Burger entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price of the entree.
        /// </summary>
        public override double Price => 7.32;

        /// <summary>
        /// Gets the number of calories for the entree.
        /// </summary>
        public override uint Calories => 843;

        /// <summary>
        /// Property is true when the bun is to be added to the entree.
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Property is true when ketchup is to be added to the entree.
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Property is true when mustard is to be added to the entree.
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Property is true when pickles is to be added to the entree.
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Property is true when cheese is to be added to the entree.
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Property is true when tomato is to be added to the entree.
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Property is true when lettuce is to be added to the entree.
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Property is true when mayo is to be added to the entree.
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// If any of the ingredients are set to false, a hold 
        /// instruction is added to the special instructions list.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString() to return the name of the entree.
        /// </summary>
        /// <returns>Returns the name of the entree.</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
