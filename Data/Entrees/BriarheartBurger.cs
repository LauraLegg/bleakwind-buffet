﻿/*
 * Author: Laura Legg
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Briarheart Burger entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger
    {
        /// <summary>
        /// Gets the price for the burger.
        /// </summary>
        public double Price => 6.32;

        /// <summary>
        /// Gets the calories for the burger.
        /// </summary>
        public uint Calories => 743;

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
                return instructions;
            }
        }

        /// <summary>
        /// Returns the name of the burger as a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}