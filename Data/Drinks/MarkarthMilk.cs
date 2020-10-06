/* 
 * Author: Laura Legg
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent Markarth Milk.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk : Drink, IOrderItem, INotifyPropertyChanged
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
                if (Size == Size.Small) return 1.05;
                if (Size == Size.Medium) return 1.11;
                if (Size == Size.Large) return 1.22;
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
                if (Size == Size.Small) return 56;
                if (Size == Size.Medium) return 72;
                if (Size == Size.Large) return 93;
                throw new NotImplementedException($"Calories for {Size} does not exsist");
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for Ice property
        /// </summary>
        private bool ice = false;

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
        /// If any of the ingredients are set to true, an add instruction is added to the special instructions list.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString() to return the name of the drink.
        /// </summary>
        /// <returns>Returns the size and name of the drink.</returns>
        public override string ToString()
        {
            return $"{Size} Markarth Milk";
        }
    }
}
