/*
 * Author: Zachery Brunner
 * Modified by: Laura Legg
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, fries.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            fries.Size = Size.Large;
            Assert.Equal(Size.Large, fries.Size);
            fries.Size = Size.Medium;
            Assert.Equal(Size.Medium, fries.Size);
            fries.Size = Size.Small;
            Assert.Equal(Size.Small, fries.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            Assert.Empty(fries.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            fries.Size = size;
            Assert.Equal(price, fries.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            fries.Size = size;
            Assert.Equal(calories, fries.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            fries.Size = size;
            Assert.Equal(name, fries.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractSideClass()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(fries);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(fries);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedInterface()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(fries);
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnSize()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();

            Assert.PropertyChanged(fries, "Size", () =>
            {
                fries.Size = Size.Medium;
            });

            Assert.PropertyChanged(fries, "Size", () =>
            {
                fries.Size = Size.Large;
            });

            Assert.PropertyChanged(fries, "Size", () =>
            {
                fries.Size = Size.Small;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnPrice()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            Assert.PropertyChanged(fries, "Price", () =>
            {
                fries.Size = Size.Large;
            });

            Assert.PropertyChanged(fries, "Price", () =>
            {
                fries.Size = Size.Medium;
            });

            Assert.PropertyChanged(fries, "Price", () =>
            {
                fries.Size = Size.Small;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnCalories()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            Assert.PropertyChanged(fries, "Calories", () =>
            {
                fries.Size = Size.Large;
            });

            Assert.PropertyChanged(fries, "Calories", () =>
            {
                fries.Size = Size.Medium;
            });

            Assert.PropertyChanged(fries, "Calories", () =>
            {
                fries.Size = Size.Small;
            });
        }

        [Fact]
        public void ShouldHaveDescription()
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            Assert.True(side.Description.Length > 0);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            Assert.Equal("Crispy fried potato waffle fries.", side.Description);
        }
    }
}