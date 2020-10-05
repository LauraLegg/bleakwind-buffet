/*
 * Author: Laura Legg
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor Soda.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event that keeps track of when properties are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private backing variable for Price property
        /// </summary>
        private double price = 1.42;

        /// <summary>
        /// Gets the price of the drink based on the size.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if price is not set for a certain size.
        /// </exception>
        public override double Price
        {
            get
            {
                double p = 0;
                if (Size == Size.Small) p = 1.42;
                if (Size == Size.Medium) p = 1.74;
                if (Size == Size.Large) p = 2.07;
                if (price != p)
                {
                    price = p;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                }
                return price;
            }
        }

        /// <summary>
        /// Private backing variable for Calories property
        /// </summary>
        private uint cal = 117;

        /// <summary>
        /// Gets the number of calories based on the size.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the number of calories is not set for a certain size.
        /// </exception>
        public override uint Calories
        {
            get
            {
                uint c = 0;
                if (Size == Size.Small) c = 117;
                if (Size == Size.Medium) c = 153;
                if (Size == Size.Large) c = 205;
                if (cal != c)
                {
                    cal = c;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                return cal;
            }
        }

        /// <summary>
        /// Private backing variable for Size property
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// The size of the side.
        /// </summary>
        public override Size Size
        {
            get => size;
            set
            {
                if (size != value)
                {
                    size = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for Ice property
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// Property is true when ice is included in the drink.
        /// </summary>
        public bool Ice
        {
            get => ice;
            set
            {
                if (ice != value)
                {
                    ice = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for Flavor property
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;

        /// <summary>
        /// Property for selecting the flavor of the soda
        /// </summary>
        public SodaFlavor Flavor
        {
            get => flavor;
            set
            {
                if (flavor != value)
                {
                    flavor = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                }
            }
        }

        /// <summary>
        /// If any of the ingredients are set to false, a 
        /// hold instruction is added to the special instructions list.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (instructions.Count > 0) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString() to return the name of the drink.
        /// </summary>
        /// <returns>Returns the size and name of the drink.</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
        }
    }
}
