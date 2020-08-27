/*
 * Author: Laura Legg
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor Soda.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    class SailorSoda
    {
        public double Price => ;

        public uint Calories => ;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        public bool Ice { get; set; } = true;
    }
}
