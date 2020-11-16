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
                if (entree != null) entree.PropertyChanged -= PropertyChangedListener;
                entree = value;
                NotifyItemChanged("Entree");
                entree.PropertyChanged += PropertyChangedListener;
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
                if (drink != null) drink.PropertyChanged -= PropertyChangedListener;
                drink = value;
                NotifyItemChanged("Drink");
                drink.PropertyChanged += PropertyChangedListener;
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
                if (side != null) PropertyChanged -= PropertyChangedListener;
                side = value;
                NotifyItemChanged("Side");
                side.PropertyChanged += PropertyChangedListener;
            }
        }

        /// <summary>
        /// The description of the combo item
        /// </summary>
        public string Description => throw new NotImplementedException();

        /// <summary>
        /// Overrides ToString() to return the combo.
        /// </summary>
        /// <returns>Returns the size and name of the drink.</returns>
        public override string ToString()
        {
            return "Combo Item \t";
        }

        /// <summary>
        /// Invokes property change on for price, calories, 
        /// and special instructions when IOrderItem is added
        /// </summary>
        /// <param name="name">The name of the property being changed</param>
        private void NotifyItemChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }


        /// <summary>
        /// Event listener for when Price and Calories of an IOrderItem change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PropertyChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
            if (e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
    }
}
