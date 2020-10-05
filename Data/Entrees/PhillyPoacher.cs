/*
 * Author: Laura Legg
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event that keeps track of when properties are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the entree.
        /// </summary>
        public override double Price => 7.23;

        /// <summary>
        /// Gets the number of calories in the entree.
        /// </summary>
        public override uint Calories => 784;

        /// <summary>
        /// Private backing variable for Sirloin property
        /// </summary>
        private bool sirloin = true;

        /// <summary>
        /// Property is true when sirloin is to be added to the entree.
        /// </summary>
        public bool Sirloin
        {
            get => sirloin;
            set
            {
                if (sirloin != value)
                {
                    sirloin = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for Onion property
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// Property is true when onion is to be added to the entree.
        /// </summary>
        public bool Onion
        {
            get => onion;
            set
            {
                if (onion != value)
                {
                    onion = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for Roll property
        /// </summary>
        private bool roll = true;

        /// <summary>
        /// Property is true when the roll is to be added to the entree.
        /// </summary>
        public bool Roll
        {
            get => roll;
            set
            {
                if (roll != value)
                {
                    roll = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
                }
            }
        }

        /// <summary>
        /// If any of the ingredients are set to false, a hold 
        /// instruction is added to the special instructions list.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                if (instructions.Count > 0) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString() to return the name of the entree.
        /// </summary>
        /// <returns>Returns the name of the entree.</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
