/*
 * Author: Laura Legg
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette entree.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event that keeps track of when properties are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price for the entree.
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// Gets the number calories in the entree.
        /// </summary>
        public override  uint Calories => 404;

        /// <summary>
        /// The description of the Garden Orc Omelette
        /// </summary>
        public override string Description => "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";

        /// <summary>
        /// Private backing variable for Broccoli property
        /// </summary>
        private bool broccoli = true;

        /// <summary>
        /// Property is true when broccoli is to be added to the entree.
        /// </summary>
        public bool Broccoli
        {
            get => broccoli;
            set
            {
                if(broccoli != value)
                {
                    broccoli = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for Mushrooms property
        /// </summary>
        private bool mushrooms = true;

        /// <summary>
        /// Property is true when mushrooms are to be added to the entree.
        /// </summary>
        public bool Mushrooms
        {
            get => mushrooms;
            set
            {
                if (mushrooms != value)
                {
                    mushrooms = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for Tomato property
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// Property is true when tomato is to be added to the entree.
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set
            {
                if (tomato != value)
                {
                    tomato = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for Cheddar property
        /// </summary>
        private bool cheddar = true;

        /// <summary>
        /// Property is true when cheddar is to be added to the entree.
        /// </summary>
        public bool Cheddar
        {
            get => cheddar;
            set
            {
                if (cheddar != value)
                {
                    cheddar = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// If any of the ingredients are set to false, a hold instruction is added to the special instructions list.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString() to return the name of the entree.
        /// </summary>
        /// <returns>Returns the name of the entree.</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
