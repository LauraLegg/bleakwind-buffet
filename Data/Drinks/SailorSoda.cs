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
        /// Gets the price of the drink based on the size.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if price is not set for a certain size.
        /// </exception>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 1.42;
                if (Size == Size.Medium) return 1.74;
                if (Size == Size.Large) return 2.07;
                throw new NotImplementedException($"Price for {Size} does not exsist");
            }
        }

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
                if (Size == Size.Small) return 117;
                if (Size == Size.Medium) return 153;
                if (Size == Size.Large) return 205;
                throw new NotImplementedException($"Calories for {Size} does not exsist");
            }
        }

        /// <summary>
        /// The description of the Sailor Soda
        /// </summary>
        public override string Description => "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";

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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
