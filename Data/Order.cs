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
        /// <summary>
        /// The collection
        /// </summary>
        private Collection<IOrderItem> collection = new Collection<IOrderItem>();

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
        public uint Calories
        {
            get
            {
                uint calories = 0;
                foreach (IOrderItem item in this)
                {
                    calories += item.Calories;
                }
                return calories;
            }
        }

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
        public double Subtotal
        {
            get
            {
                double subtotal = 0;
                foreach (IOrderItem item in this)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        /// <summary>
        /// Represents the Subtotal multiplied by the SalesTaxRate
        /// </summary>
        public double Tax
        {
            get
            {
                double tax = Subtotal* SalesTaxRate;
                return Convert.ToDouble(String.Format("{0:00.00}", tax));
            }
        }

        /// <summary>
        /// The total is the sum of the Subtotal and Tax.
        /// </summary>
        public double Total
        {
            get
            {
                double total = Subtotal + Tax; ;
                return Convert.ToDouble(String.Format("{0:000.00}", total));
            }
        }

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
            item.PropertyChanged += ItemChangedListener;
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// Method to removing items to the order.
        /// </summary>
        public void Remove(IOrderItem item)
        {
            int index = collection.IndexOf(item);
            collection.Remove(item);
            item.PropertyChanged -= ItemChangedListener;
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return collection.GetEnumerator();
        }

        void ItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }

            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
        }
    }
}
