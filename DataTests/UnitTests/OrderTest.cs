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
        public void CanAddItemToOrder()
        {
            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            order.Add(burger);
            foreach (IOrderItem item in order)
            {
                Assert.Equal(burger.ToString(), item.ToString());
            }
        }

        [Fact]
        public void CanRemoveItemFromOrder()
        {
            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            order.Add(burger);
            order.Remove(burger);
            Assert.Empty(order);
        }

        [Fact]
        public void ReturnsCorrectCaloriesWhenIOrderItemIsAdded()
        {

            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            AretinoAppleJuice drink = new AretinoAppleJuice();
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            uint cal = 0;

            order.Add(burger);
            cal += burger.Calories;
            Assert.Equal(cal, order.Calories);

            order.Add(drink);
            cal += drink.Calories;
            Assert.Equal(cal, order.Calories);

            order.Add(fries);
            cal += fries.Calories;
            Assert.Equal(cal, order.Calories);
        }

        [Fact]
        public void ReturnsCorrectCaloriesWhenIOrderItemIsRemoved()
        {

            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            AretinoAppleJuice drink = new AretinoAppleJuice();
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            uint cal = burger.Calories + drink.Calories + fries.Calories;
            order.Add(burger);
            order.Add(drink);
            order.Add(fries);

            order.Remove(burger);
            cal -= burger.Calories;
            Assert.Equal(cal, order.Calories);

            order.Remove(drink);
            cal -= drink.Calories;
            Assert.Equal(cal, order.Calories);

            order.Remove(fries);
            cal -= fries.Calories;
            Assert.Equal(cal, order.Calories);
        }

        [Fact]
        public void PropertyChangedEventForCaloriesWhenIOrderItemIsAdded()
        {
            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            AretinoAppleJuice drink = new AretinoAppleJuice();
            DragonbornWaffleFries fries = new DragonbornWaffleFries();

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Add(burger);
            });

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Add(drink);
            });

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Add(fries);
            });
        }

        [Fact]
        public void PropertyChangedEventForCaloriesWhenIOrderItemIsRemoved()
        {
            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            AretinoAppleJuice drink = new AretinoAppleJuice();
            DragonbornWaffleFries fries = new DragonbornWaffleFries();

            order.Add(burger);
            order.Add(drink);
            order.Add(fries);

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Remove(burger);
            });

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Remove(drink);
            });

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Remove(fries);
            });
        }

        [Fact]
        public void PropertyChangedEventForCaloriesWhenIOrderItemIsChanged()
        {
            Order order = new Order();
            AretinoAppleJuice drink = new AretinoAppleJuice();
            DragonbornWaffleFries fries = new DragonbornWaffleFries();

            order.Add(drink);
            order.Add(fries);

            Assert.PropertyChanged(order, "Calories", () =>
            {
                drink.Size = Size.Medium;
            });

            Assert.PropertyChanged(order, "Calories", () =>
            {
                fries.Size = Size.Medium;
            });
        }

        /*
        [Fact]
        public void NumberReturnsTheCorrectNumber()
        {
            Order order = new Order();
            Assert.Equal(1, order.Number);
        }
        */

        [Fact]
        public void SalesTaxRateShouldReturnCorrectDefaultNumber()
        {
            Order order = new Order();
            Assert.Equal(0.12, order.SalesTaxRate);
        }

        [Fact]
        public void AbleToSetSalesTaxRate()
        {
            Order order = new Order();
            order.SalesTaxRate = 0.15;
            Assert.Equal(0.15, order.SalesTaxRate);
        }

        [Fact]
        public void ReturnsCorrectSubtotalWhenIOrderItemIsAdded()
        {

            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            AretinoAppleJuice drink = new AretinoAppleJuice();
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            double price = 0;

            order.Add(burger);
            price += burger.Price;
            Assert.Equal(price, order.Subtotal);

            order.Add(drink);
            price += drink.Price;
            Assert.Equal(price, order.Subtotal);

            order.Add(fries);
            price += fries.Price;
            Assert.Equal(price, order.Subtotal);
        }

        [Fact]
        public void ReturnsCorrectSubtotalWhenIOrderItemIsRemoved()
        {

            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            AretinoAppleJuice drink = new AretinoAppleJuice();
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            order.Add(burger);
            order.Add(drink);
            order.Add(fries);

            order.Remove(burger);
            Assert.Equal(1.04, order.Subtotal);

            order.Remove(drink);
            Assert.Equal(0.42, order.Subtotal);

            order.Remove(fries);
            Assert.Equal(0, order.Subtotal);
        }

        [Fact]
        public void PropertyChangedEventForSubtotalWhenIOrderItemIsAdded()
        {
            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            AretinoAppleJuice drink = new AretinoAppleJuice();
            DragonbornWaffleFries fries = new DragonbornWaffleFries();

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(burger);
            });

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(drink);
            });

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(fries);
            });
        }

        [Fact]
        public void PropertyChangedEventForSubtotalWhenIOrderItemIsRemoved()
        {
            Order order = new Order();
            BriarheartBurger burger = new BriarheartBurger();
            AretinoAppleJuice drink = new AretinoAppleJuice();
            DragonbornWaffleFries fries = new DragonbornWaffleFries();

            order.Add(burger);
            order.Add(drink);
            order.Add(fries);

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Remove(burger);
            });

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Remove(drink);
            });

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Remove(fries);
            });
        }

        [Fact]
        public void PropertyChangedEventForSubtotalWhenIOrderItemIsChanged()
        {
            Order order = new Order();
            AretinoAppleJuice drink = new AretinoAppleJuice();
            DragonbornWaffleFries fries = new DragonbornWaffleFries();

            order.Add(drink);
            order.Add(fries);

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                drink.Size = Size.Medium;
            });

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                fries.Size = Size.Medium;
            });
        }

        [Fact]
        public void ReturnsCorrectTax()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            Assert.Equal(0.76, order.Tax);

            order.Add(new MarkarthMilk());
            Assert.Equal(0.88, order.Tax);
        }

        [Fact]
        public void ReturnsCorrectTotal()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            Assert.Equal(7.08, order.Total);

            order.Add(new MarkarthMilk());
            Assert.Equal(8.25, order.Total);
        }

        [Fact]
        public void CountReturnsTheCorrectNumber()
        {
            Order order = new Order();
            order.Add(new BriarheartBurger());
            Assert.Single(order);

            order.Add(new MarkarthMilk());
            Assert.Equal(2, order.Count);
        }
    }
}
