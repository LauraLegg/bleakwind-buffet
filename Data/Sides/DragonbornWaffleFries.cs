/*
 * Author: Laura Legg
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent Dragonborn Waffle Fries.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries : Side, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event that keeps track of when properties are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private backing variable for Price property
        /// </summary>
        private double price = 0.42;

        /// <summary>
        /// Gets the price of the side based on the size.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if price is not set for a certain size.
        /// </exception>
        public override double Price
        {
            get
            {
                double p = 0;
                if (Size == Size.Small) p = 0.42;
                if (Size == Size.Medium) p = 0.76;
                if (Size == Size.Large) p = 0.96;
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
        private uint cal = 77;

        /// <summary>
        /// Gets the calories based on the size.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if number of calories is not set for a certain size.
        /// </exception>
        public override uint Calories
        {
            get
            {
                uint c = 0;
                if (Size == Size.Small) c = 77;
                if (Size == Size.Medium) c = 89;
                if (Size == Size.Large) c = 100;
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
        /// If any of the ingredients are set to false, a hold instruction is added to the special instructions list.
        /// </summary>
        public override List<string> SpecialInstructions => new List<string>();

        /// <summary>
        /// Overrides ToString() to return the name of the side.
        /// </summary>
        /// <returns>Returns the size and name of the side.</returns>
        public override string ToString()
        {
            return $"{Size} Dragonborn Waffle Fries";
        }
    }
}
