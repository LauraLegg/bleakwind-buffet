/*
 * Author: Laura Legg
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the T-Bone sandwich entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone
    {
        public double Price => 6.44;

        public uint Calories => 982;

        /// <summary>
        ///  It has no boolean properties. The SpecialInstructions 
        ///  property should always return an emplty list.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString() to return the name of the entree.
        /// </summary>
        /// <returns>Returns the name of the entree.</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
