﻿/*
 * Author: Zachery Brunner
 * Modified by: Laura Legg
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.Equal(Size.Small, grits.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits grits = new MadOtarGrits();
            grits.Size = Size.Large;
            Assert.Equal(Size.Large, grits.Size);
            grits.Size = Size.Medium;
            Assert.Equal(Size.Medium, grits.Size);
            grits.Size = Size.Small;
            Assert.Equal(Size.Small, grits.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.Empty(grits.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits grits = new MadOtarGrits();
            grits.Size = size;
            Assert.Equal(price, grits.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits grits = new MadOtarGrits();
            grits.Size = size;
            Assert.Equal(calories, grits.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits grits = new MadOtarGrits();
            grits.Size = size;
            Assert.Equal(name, grits.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractSideClass()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(grits);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(grits);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedInterface()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(grits);
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnSize()
        {
            MadOtarGrits grits = new MadOtarGrits();

            Assert.PropertyChanged(grits, "Size", () =>
            {
                grits.Size = Size.Medium;
            });

            Assert.PropertyChanged(grits, "Size", () =>
            {
                grits.Size = Size.Large;
            });

            Assert.PropertyChanged(grits, "Size", () =>
            {
                grits.Size = Size.Small;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnPrice()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.PropertyChanged(grits, "Price", () =>
            {
                grits.Size = Size.Large;
            });

            Assert.PropertyChanged(grits, "Price", () =>
            {
                grits.Size = Size.Medium;
            });

            Assert.PropertyChanged(grits, "Price", () =>
            {
                grits.Size = Size.Small;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnCalories()
        {
            MadOtarGrits grits = new MadOtarGrits();
            Assert.PropertyChanged(grits, "Calories", () =>
            {
                grits.Size = Size.Large;
            });

            Assert.PropertyChanged(grits, "Calories", () =>
            {
                grits.Size = Size.Medium;
            });

            Assert.PropertyChanged(grits, "Calories", () =>
            {
                grits.Size = Size.Small;
            });
        }

        [Fact]
        public void ShouldHaveDescription()
        {
            MadOtarGrits side = new MadOtarGrits();
            Assert.True(side.Description.Length > 0);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            MadOtarGrits side = new MadOtarGrits();
            Assert.Equal("Cheesey Grits.", side.Description);
        }
    }
}