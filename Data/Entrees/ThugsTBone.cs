/*
 * Author: Laura Legg
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the T-Bone sandwich entree.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event that keeps track of when properties are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price for the entree.
        /// </summary>
        public override double Price => 6.44;

        /// <summary>
        /// Gets the number of calories in the entree.
        /// </summary>
        public override uint Calories => 982;

        /// <summary>
        ///  It has no boolean properties. The SpecialInstructions 
        ///  property should always return an emplty list.
        /// </summary>
        public override List<string> SpecialInstructions => new List<string>();

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
