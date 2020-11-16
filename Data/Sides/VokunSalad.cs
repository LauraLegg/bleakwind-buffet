/*
 * Author: Laura Legg
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the Vokun Salad.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad : Side, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event that keeps track of when properties are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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
                if (Size == Size.Small) return 0.93;
                if (Size == Size.Medium) return 1.28;
                if (Size == Size.Large) return 1.82;
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
                if (Size == Size.Small) return 41;
                if (Size == Size.Medium) return 52;
                if (Size == Size.Large) return 73;
                throw new NotImplementedException($"Calories for {Size} does not exsist");
            }
        }

        /// <summary>
        /// The description of the Vokun Salad
        /// </summary>
        public override string Description => "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.";

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
        /// If any of the ingredients are set to false, a hold 
        /// instruction is added to the special instructions list.
        /// </summary>
        public override List<string> SpecialInstructions => new List<string>();

        /// <summary>
        /// Overrides ToString() to return the name of the side.
        /// </summary>
        /// <returns>Returns the size and name of the side.</returns>
        public override string ToString()
        {
            return $"{Size} Vokun Salad";
        }
    }
}
