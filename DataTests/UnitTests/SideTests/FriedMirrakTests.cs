﻿/*
 * Author: Zachery Brunner
 * Modified by: Laura Legg
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak miraak = new FriedMiraak();
            Assert.Equal(Size.Small, miraak.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak miraak = new FriedMiraak();
            miraak.Size = Size.Large;
            Assert.Equal(Size.Large, miraak.Size);
            miraak.Size = Size.Medium;
            Assert.Equal(Size.Medium, miraak.Size);
            miraak.Size = Size.Small;
            Assert.Equal(Size.Small, miraak.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak miraak = new FriedMiraak();
            Assert.Empty(miraak.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak miraak = new FriedMiraak();
            miraak.Size = size;
            Assert.Equal(price, miraak.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak miraak = new FriedMiraak();
            miraak.Size = size;
            Assert.Equal(calories, miraak.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak miraak = new FriedMiraak();
            miraak.Size = size;
            Assert.Equal(name, miraak.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractSideClass()
        {
            FriedMiraak miraak = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(miraak);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            FriedMiraak miraak = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(miraak);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedInterface()
        {
            FriedMiraak miraak = new FriedMiraak();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(miraak);
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnSize()
        {
            FriedMiraak miraak = new FriedMiraak();

            Assert.PropertyChanged(miraak, "Size", () =>
            {
                miraak.Size = Size.Medium;
            });

            Assert.PropertyChanged(miraak, "Size", () =>
            {
                miraak.Size = Size.Large;
            });

            Assert.PropertyChanged(miraak, "Size", () =>
            {
                miraak.Size = Size.Small;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnPrice()
        {
            FriedMiraak miraak = new FriedMiraak();
            Assert.PropertyChanged(miraak, "Price", () =>
            {
                miraak.Size = Size.Large;
            });

            Assert.PropertyChanged(miraak, "Price", () =>
            {
                miraak.Size = Size.Medium;
            });

            Assert.PropertyChanged(miraak, "Price", () =>
            {
                miraak.Size = Size.Small;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnCalories()
        {
            FriedMiraak miraak = new FriedMiraak();
            Assert.PropertyChanged(miraak, "Calories", () =>
            {
                miraak.Size = Size.Large;
            });

            Assert.PropertyChanged(miraak, "Calories", () =>
            {
                miraak.Size = Size.Medium;
            });

            Assert.PropertyChanged(miraak, "Calories", () =>
            {
                miraak.Size = Size.Small;
            });
        }

        [Fact]
        public void ShouldHaveDescription()
        {
            FriedMiraak side = new FriedMiraak();
            Assert.True(side.Description.Length > 0);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            FriedMiraak side = new FriedMiraak();
            Assert.Equal("Perfectly prepared hash brown pancakes.", side.Description);
        }
    }
}