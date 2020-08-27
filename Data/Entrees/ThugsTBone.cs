/*
 * Author: Laura Legg
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Philly cheesesteak sandwich entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    class ThugsTBone
    {
        public double Price => 6.44;

        public uint Calories => 982;

        /// <summary>
        ///  It has no boolean properties. The SpecialInstructions should return an emplty list always.
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
        /// Returns the name of the sandwich as a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
