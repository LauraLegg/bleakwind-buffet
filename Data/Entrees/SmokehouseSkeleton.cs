/*
 * Author: Laura Legg
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton breakfast entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Gets the price of the entree.
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// Gets the number of calories for the entree.
        /// </summary>
        public uint Calories => 602;

        /// <summary>
        /// Property is true when sausage links are to be added to the entree.
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        /// Property is true when eggs are to be added to the entree.
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Property is true when hash browns are to be added to the entree.
        /// </summary>
        public bool HashBrowns { get; set; } = true;

        /// <summary>
        /// Property is true when pancakes are to be added to the entree.
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        /// If any of the ingredients are set to false, a hold 
        /// instruction is added to the special instructions list.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString() to return the name of the entree.
        /// </summary>
        /// <returns>Returns the name of the entree.</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}