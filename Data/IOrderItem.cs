/*
 * Author: Laura Legg
 * Interface name: IOrderItem.cs
 * Purpose: Interface that defines the price, 
 * calories, and special instructions functions.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Interface defines price, calories, 
    /// and special instructions functions.
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the menu item
        /// </summary>
        /// <value>Price will return as a double</value>
        double Price { get; }

        /// <summary>
        /// Gets the number of calories in the menu item
        /// </summary>
        /// <value>Calories will return as a uint</value>
        uint Calories { get; }

        /// <summary>
        /// Gets the list of specail instructions for the menu item
        /// </summary>
        /// <remarks> Special instructions will say add or hold an ingredient</remarks>
        /// <value>SpecialInstructions outputs a list of strings.</value>
        List<string> SpecialInstructions { get; }

        string Description { get; }
    }
}
