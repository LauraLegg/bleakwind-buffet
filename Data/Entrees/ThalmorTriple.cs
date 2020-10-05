/*
 * Author: Laura Legg
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the Thalmor Triple Burger entree.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event that keeps track of when properties are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price for the entree.
        /// </summary>
        public override double Price => 8.32;

        /// <summary>
        /// Gets the number of calories in the entree.
        /// </summary>
        public override uint Calories => 943;

        /// <summary>
        /// Private backing variable for Bun property
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Property is true when the bun is to be added to the entree.
        /// </summary>
        public bool Bun
        {
            get => bun;
            set
            {
                if (bun != value)
                {
                    bun = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for Ketchup property
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// Property is true when ketchup is to be added to the entree.
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;
            set
            {
                if (ketchup != value)
                {
                    ketchup = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for Mustard property
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// Property is true when mustard is to be added to the entree.
        /// </summary>
        public bool Mustard
        {
            get => mustard;
            set
            {
                if (mustard != value)
                {
                    mustard = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for Pickle property
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// Property is true when pickles are to be added to the entree.
        /// </summary>
        public bool Pickle
        {
            get => pickle;
            set
            {
                if (pickle != value)
                {
                    pickle = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for Cheese property
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// Property is true when cheese is to be added to the entree.
        /// </summary>
        public bool Cheese
        {
            get => cheese;
            set
            {
                if (cheese != value)
                {
                    cheese = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
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
                }
            }
        }

        /// <summary>
        /// Private backing variable for Lettuce property
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Property is true when lettuce is to be added to the entree.
        /// </summary>
        public bool Lettuce
        {
            get => lettuce;
            set
            {
                if (lettuce != value)
                {
                    lettuce = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for Mayo property
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// Property is true when mayo is to be added to the entree.
        /// </summary>
        public bool Mayo
        {
            get => mayo;
            set
            {
                if (mayo != value)
                {
                    mayo = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for bacon property
        /// </summary>
        private bool bacon = true;

        /// <summary>
        /// Property is true when bacon is to be added to the entree.
        /// </summary>
        public bool Bacon
        {
            get => bacon;
            set
            {
                if (bacon != value)
                {
                    bacon = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for Egg property
        /// </summary>
        private bool egg = true;

        /// <summary>
        /// Property is true when eggs are to be added to the entree.
        /// </summary>
        public bool Egg
        {
            get => egg;
            set
            {
                if (egg != value)
                {
                    egg = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
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
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                if (instructions.Count > 0) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString() to return the name of the entree.
        /// </summary>
        /// <returns>Returns the name of the entree.</returns>>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}