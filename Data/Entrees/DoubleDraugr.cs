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
    public class DoubleDraugr
    {
        /// <summary>
        /// Gets the price for the burger.
        /// </summary>
        public double Price => 7.32;

        /// <summary>
        /// Gets the calories for the burger.
        /// </summary>
        public uint Calories => 843;

        /// <summary>
        /// Property is true when the bun is to be added to the burger.
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Property is true when ketchup is to be added to the burger.
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Property is true when mustard is to be added to the burger.
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Property is true when pickles is to be added to the burger.
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Property is true when cheese is to be added to the burger.
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Property is true when tomato is to be added to the burger.
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Property is true when lettuce is to be added to the burger.
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Property is true when mayo is to be added to the burger.
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// If any of the ingredients are set to false, a hold instruction is added to the special instructions list.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickles");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                return instructions;
            }
        }

        /// <summary>
        /// Returns the name of the burger as a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
