/*
 * Author: Laura Legg
 * Class name: OrderTests.cs
 * Purpose: Tests the Order Class
 */
using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTest
    {
        [Fact]
        public void CanAddIOrderItem()
        {
            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            order.Add(burger);
            Assert.Contains(burger, order.collection);

            AretinoAppleJuice drink = new AretinoAppleJuice();
            order.Add(drink);
            Assert.Contains(drink, order.collection);
        }

        [Fact]
        public void CanRemoveIOrderItem()
        {
            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            order.Add(burger);
            order.Remove(burger);
            Assert.Empty(order.collection);
        }



        [Fact]
        public void SaleTaxRateShouldReturnCorrectDefaultNumber()
        {
            Order order = new Order();
            Assert.Equal(0.12, order.SalesTaxRate);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        [Fact]
        public void ShouldBeAssignableToICollection()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<ICollection>(order);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyCollectionChanged()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(order);
        }

        [Fact]
        public void PropertyChangedEventForCaloriesWhenItemIsAdded()
        {
            Order order = new Order();
            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Add(new VokunSalad());
            });
        }

        [Fact]
        public void PropertyChangedEventForCaloriesWhenItemIsRemoved()
        {
            Order order = new Order();
            order.Add(new VokunSalad());
            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Remove(new VokunSalad());
            });
        }

        [Fact]
        public void PropertyChangedEventForSubtotalWhenItemIsAdded()
        {
            Order order = new Order();
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(new VokunSalad());
            });
        }

        [Fact]
        public void PropertyChangedEventForSubtotalWhenItemIsRemoved()
        {
            Order order = new Order();
            order.Add(new VokunSalad());
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Remove(new VokunSalad());
            });
        }

        [Fact]
        public void PropertyChangedEventForTaxWhenItemIsAdded()
        {
            Order order = new Order();
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Add(new VokunSalad());
            });
        }

        [Fact]
        public void PropertyChangedEventForTaxWhenItemIsRemoved()
        {
            Order order = new Order();
            order.Add(new VokunSalad());
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Remove(new VokunSalad());
            });
        }

        [Fact]
        public void PropertyChangedEventForTotalWhenItemIsAdded()
        {
            Order order = new Order();
            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Add(new VokunSalad());
            });
        }

        [Fact]
        public void PropertyChangedEventForTotalWhenItemIsRemoved()
        {
            Order order = new Order();
            order.Add(new VokunSalad());
            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Remove(new VokunSalad());
            });
        }

        [Fact]
        public void PropertyChangedEventForGetCollectionWhenItemIsAdded()
        {
            Order order = new Order();
            Assert.PropertyChanged(order, "GetCollection", () =>
            {
                order.Add(new VokunSalad());
            });
        }

        [Fact]
        public void PropertyChangedEventForGetCollectionWhenItemIsRemoved()
        {
            Order order = new Order();
            order.Add(new VokunSalad());
            Assert.PropertyChanged(order, "GetCollection", () =>
            {
                order.Remove(new VokunSalad());
            });
        }
    }
}
