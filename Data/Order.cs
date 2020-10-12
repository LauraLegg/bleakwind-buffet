/*
 * Author: Laura Legg
 * Class name: Order.cs
 * Purpose: Class that represents a meal order.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Schema;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Collection representing a meal order
    /// </summary>
    public class Order : ICollection, INotifyCollectionChanged, INotifyPropertyChanged
    {
        public Collection<IOrderItem> collection = new Collection<IOrderItem>();

        /// <summary>
        /// Event that keeps track of when properties are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Event that keeps track of when collection are changed
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        /// Sum of all the calories of the items in the order
        /// </summary>
        private uint calories = 0;
        public uint Calories => calories;

        /// <summary>
        /// The order number
        /// </summary>
        private static int nextOrderNumber = 1;
        public int Number { get; }
        
        /// <summary>
        /// Property that handles the order's sales tax
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.12;
        /// <summary>
        /// Represents the total price for all items in the order.
        /// </summary>
        private double subtotal = 0;
        public double Subtotal => subtotal;

        /// <summary>
        /// Represents the Subtotal multiplied by the SalesTaxRate
        /// </summary>
        public double Tax => Subtotal * SalesTaxRate;

        /// <summary>
        /// The total is the sum of the Subtotal and Tax.
        /// </summary>
        public double Total => Subtotal + Tax;

        /// <summary>
        /// The number of elements in the collection
        /// </summary>
        public int Count => collection.Count;

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        /// <summary>
        /// Order class contructor
        /// </summary>
        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
        }

        /// <summary>
        /// Method to add items to the order.
        /// </summary>
        public void Add(IOrderItem item)
        {
            collection.Add(item);
            calories += item.Calories;
            subtotal += item.Price;
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GetCollection"));
        }

        /// <summary>
        /// Method to removing items to the order.
        /// </summary>
        public void Remove(IOrderItem item)
        {
            collection.Remove(item);
            calories -= item.Calories;
            subtotal -= item.Price;
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GetCollection"));
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotFiniteNumberException();
        }

        public IEnumerator GetEnumerator()
        {
            return collection.GetEnumerator();
        }
    }
}
