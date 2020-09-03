/*
 * Author: Laura Legg
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the Thalmor Triple Burger entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple
    {
        /// <summary>
        /// Gets the price for the entree.
        /// </summary>
        public double Price => 8.32;

        /// <summary>
        /// Gets the number of calories in the entree.
        /// </summary>
        public uint Calories => 943;

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
        /// Property is true when pickles are to be added to the entree.
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
        /// Property is true when bacon is to be added to the entree.
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// Property is true when eggs are to be added to the entree.
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// If any of the ingredients are set to false, a hold 
        /// instruction is added to the special instructions list.
        /// </summary>
        public List<string> SpecialInstructions
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
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString() to return the name of the entree.
        /// </summary>
        /// <returns>Returns the name of the entree.</returns>>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}