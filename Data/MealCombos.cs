/*
 * Author: Laura Legg
 * Class name: MealCombos.cs
 * Purpose: Class used to represent different 
 * meal combinations of entrees, drinks and sides.
 */
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class representing a meal combo of an entree, drink, and side
    /// </summary>
    public class MealCombos : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event that keeps track of when properties are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Returns the total price of the combo minus a $1 discount.
        /// </summary>
        public double Price
        {
            get
            {
                double price = 0;
                if (Entree != null) price += Entree.Price;
                if (Drink != null) price += Drink.Price;
                if (Side != null) price += Side.Price;
                return price - 1;
            }
        }

        /// <summary>
        /// Returns the total number of calories in the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                if (Entree != null) calories += Entree.Calories;
                if (Drink != null) calories += Drink.Calories;
                if (Side != null) calories += Side.Calories;
                return calories;
            }
        }

        /// <summary>
        /// Returns the name of the menu item along with it's special instructions.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> list = new List<string>();
                if (Entree != null)
                {
                    list.Add(Entree.ToString());
                    foreach (string item in Entree.SpecialInstructions)
                        list.Add(" - " + item);
                }
                if (Drink != null)
                {
                    list.Add(Drink.ToString());
                    foreach (string item in Drink.SpecialInstructions)
                        list.Add(" - " + item);
                }
                if (Side != null)
                {
                    list.Add(Side.ToString());
                }
                return list;
            }
        }

        /// <summary>
        /// Adds an entree to the combo
        /// </summary>
        private Entree entree;
        public Entree Entree
        {
            get => entree;
            set
            {
                //entree.PropertyChanged -= PropertyChangedListener;
                entree = value;
                //entree.PropertyChanged += PropertyChangedListener;
                NotifyItemChanged("Entree");
            }
        }

        /// <summary>
        /// Adds a drink to the combo
        /// </summary>
        private Drink drink;
        public Drink Drink
        {
            get => drink;
            set
            {
                //drink.PropertyChanged -= PropertyChangedListener;
                drink = value;
                //drink.PropertyChanged += PropertyChangedListener;
                NotifyItemChanged("Drink");
            }
        }

        /// <summary>
        /// Adds a side to the combo
        /// </summary>
        private Side side;
        public Side Side
        {
            get => side;
            set
            {
                //side.PropertyChanged -= PropertyChangedListener;
                side = value;
                //side.PropertyChanged += PropertyChangedListener;
                NotifyItemChanged("Side");
            }
        }

        private void NotifyItemChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

        void PropertyChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Size")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
    }
}
