/*
 * Author: Laura Legg
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton breakfast entree.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event that keeps track of when properties are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the entree.
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// Gets the number of calories in the entree.
        /// </summary>
        public override uint Calories => 602;

        /// <summary>
        /// Private backing variable for SausageLink property
        /// </summary>
        private bool sausageLink = true;

        /// <summary>
        /// Property is true when sausage links are to be added to the entree.
        /// </summary>
        public bool SausageLink
        {
            get => sausageLink;
            set
            {
                if (sausageLink != value)
                {
                    sausageLink = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Private backing variable for HashBrowns property
        /// </summary>
        private bool hashBrowns = true;

        /// <summary>
        /// Property is true when hash browns are to be added to the entree.
        /// </summary>
        public bool HashBrowns
        {
            get => hashBrowns;
            set
            {
                if (hashBrowns != value)
                {
                    hashBrowns = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }    
            }
        }

        /// <summary>
        /// Private backing variable for Pancake property
        /// </summary>
        private bool pancake = true;

        /// <summary>
        /// Property is true when pancakes are to be added to the entree.
        /// </summary>
        public bool Pancake
        {
            get => pancake;
            set
            {
                if (pancake != value)
                {
                    pancake = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString() to return the name of the entree.
        /// </summary>
        /// <returns>Returns the name of the entree.</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}