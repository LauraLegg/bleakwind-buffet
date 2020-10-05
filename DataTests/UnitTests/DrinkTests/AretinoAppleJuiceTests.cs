/*
 * Author: Zachery Brunner
 * Modified by: Laura Legg
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            Assert.Equal(Size.Small, drink.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            drink.Ice = true;
            Assert.True(drink.Ice);
            drink.Ice = false;
            Assert.False(drink.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            drink.Size = Size.Large;
            Assert.Equal(Size.Large, drink.Size);
            drink.Size = Size.Medium;
            Assert.Equal(Size.Medium, drink.Size);
            drink.Size = Size.Small;
            Assert.Equal(Size.Small, drink.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            drink.Size = size;
            Assert.Equal(price, drink.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            drink.Size = size;
            Assert.Equal(drink.Calories, cal);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            drink.Ice = includeIce;
            if (drink.Ice) Assert.Contains("Add ice", drink.SpecialInstructions);
            else Assert.Empty(drink.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            drink.Size = size;
            Assert.Equal(name, drink.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(drink);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(drink);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedInterface()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(drink);
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnSize()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();

            Assert.PropertyChanged(drink, "Size", () =>
            {
                drink.Size = Size.Medium;
            });

            Assert.PropertyChanged(drink, "Size", () =>
            {
                drink.Size = Size.Large;
            });

            Assert.PropertyChanged(drink, "Size", () =>
            {
                drink.Size = Size.Small;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnIce()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();

            Assert.PropertyChanged(drink, "Ice", () =>
            {
                drink.Ice = true;
            });

            Assert.PropertyChanged(drink, "Ice", () =>
            {
                drink.Ice = false;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnPrice()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            drink.Size = Size.Medium;
            Assert.PropertyChanged(drink, "Price", () => drink.Price.Equals(0.87));
            drink.Size = Size.Large;
            Assert.PropertyChanged(drink, "Price", () => drink.Price.Equals(1.01));
            drink.Size = Size.Small;
            Assert.PropertyChanged(drink, "Price", () => drink.Price.Equals(0.62));
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnSpecialInstructions()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            drink.Ice = true;
            Assert.PropertyChanged(drink, "SpecialInstructions", () => drink.SpecialInstructions.Contains("Add ice"));
        }
    }
}