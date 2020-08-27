﻿/*
 * Author: Laura Legg
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class GardenOrcOmelette
    {
        /// <summary>
        /// Gets the price for the omelette.
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// Gets the calories for the omelette.
        /// </summary>
        public uint Calories => 404;

        /// <summary>
        /// Property is true when broccoli is to be added to the omelette.
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// Property is true when mushrooms are to be added to the omelette.
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// Property is true when tomato is to be added to the omelette.
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Property is true when cheddar is to be added to the omelette.
        /// </summary>
        public bool Cheddar { get; set; } = true;

        /// <summary>
        /// If any of the ingredients are set to false, a hold instruction is added to the special instructions list.
        /// </summary>
        public List<string> SpecialInstructions
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
        /// Returns the name of the omelette as a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}