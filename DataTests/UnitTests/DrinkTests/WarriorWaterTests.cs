/*
 * Author: Laura Legg
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using System;

using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;
using Microsoft.VisualStudio.TestPlatform.Common.Utilities;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater water = new WarriorWater();
            Assert.True(water.Ice);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater water = new WarriorWater();
            Assert.False(water.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefalt()
        {
            WarriorWater water = new WarriorWater();
            Assert.Equal(Size.Small, water.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater water = new WarriorWater();
            water.Size = Size.Large;
            Assert.Equal(Size.Large, water.Size);
            water.Size = Size.Medium;
            Assert.Equal(Size.Medium, water.Size);
            water.Size = Size.Small;
            Assert.Equal(Size.Small, water.Size);
        }

        [Fact]
        public void ShouldHavePriceOfZero()
        {
            WarriorWater water = new WarriorWater();
            Assert.Equal(0.00, water.Price);
        }

        [Fact]
        public void ShouldHaveZeroCalories()
        {
            WarriorWater water = new WarriorWater();
            Assert.Equal((uint)0, water.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(false, true)]
        [InlineData(true, false)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater water = new WarriorWater();
            water.Ice = includeIce;
            water.Lemon = includeLemon;
            if (!includeIce) Assert.Contains("Hold ice", water.SpecialInstructions);
            else Assert.DoesNotContain("Hold ice", water.SpecialInstructions);
            if (includeLemon) Assert.Contains("Add lemon", water.SpecialInstructions);
            else Assert.DoesNotContain("Add lemon", water.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldHaveCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater water = new WarriorWater();
            water.Size = size;
            Assert.Equal(name, water.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            WarriorWater water = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(water);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemClass()
        {
            WarriorWater water = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(water);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedInterface()
        {
            WarriorWater water = new WarriorWater();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnSize()
        {
            WarriorWater water = new WarriorWater();

            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = Size.Medium;
            });

            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = Size.Large;
            });

            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = Size.Small;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnIce()
        {
            WarriorWater water = new WarriorWater();

            Assert.PropertyChanged(water, "Ice", () =>
            {
                water.Ice = false;
            });

            Assert.PropertyChanged(water, "Ice", () =>
            {
                water.Ice = true;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnLemon()
        {
            WarriorWater water = new WarriorWater();

            Assert.PropertyChanged(water, "Lemon", () =>
            {
                water.Lemon = true;
            });

            Assert.PropertyChanged(water, "Lemon", () =>
            {
                water.Lemon = false;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnSpecialInstructions()
        {
            WarriorWater water = new WarriorWater();

            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Ice = false;
            });

            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Lemon = true;
            });
        }

        [Fact]
        public void ShouldHaveDescription()
        {
            WarriorWater drink = new WarriorWater();
            Assert.True(drink.Description.Length > 0);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            WarriorWater drink = new WarriorWater();
            Assert.Equal("It’s water. Just water.", drink.Description);
        }
    }
}
