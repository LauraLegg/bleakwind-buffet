﻿/*
 * Author: Zachery Brunner
 * Modified by: Laura Legg
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {   
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.True(burger.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.True(burger.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.True(burger.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.True(burger.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.True(burger.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.True(burger.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.True(burger.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.True(burger.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr burger = new DoubleDraugr();
            burger.Bun = false;
            Assert.False(burger.Bun);
            burger.Bun = true;
            Assert.True(burger.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr burger = new DoubleDraugr();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);
            burger.Ketchup = true;
            Assert.True(burger.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr burger = new DoubleDraugr();
            burger.Mustard = false;
            Assert.False(burger.Mustard);
            burger.Mustard = true;
            Assert.True(burger.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr burger = new DoubleDraugr();
            burger.Pickle = false;
            Assert.False(burger.Pickle);
            burger.Pickle = true;
            Assert.True(burger.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr burger = new DoubleDraugr();
            burger.Cheese = false;
            Assert.False(burger.Cheese);
            burger.Cheese = true;
            Assert.True(burger.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr burger = new DoubleDraugr();
            burger.Tomato = false;
            Assert.False(burger.Tomato);
            burger.Tomato = true;
            Assert.True(burger.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr burger = new DoubleDraugr();
            burger.Lettuce = false;
            Assert.False(burger.Lettuce);
            burger.Lettuce = true;
            Assert.True(burger.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr burger = new DoubleDraugr();
            burger.Mayo = false;
            Assert.False(burger.Mayo);
            burger.Mayo = true;
            Assert.True(burger.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.Equal(7.32, burger.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.Equal((uint) 843, burger.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr burger = new DoubleDraugr();
            burger.Bun = includeBun;
            burger.Ketchup = includeKetchup;
            burger.Mustard = includeMustard;
            burger.Pickle = includePickle;
            burger.Cheese = includeCheese;
            burger.Tomato = includeTomato;
            burger.Lettuce = includeLettuce;
            burger.Mayo = includeMayo;

            if (!includeBun) Assert.Contains("Hold bun", burger.SpecialInstructions);
            else Assert.DoesNotContain("Hold bun", burger.SpecialInstructions);

            if (!includeKetchup) Assert.Contains("Hold ketchup", burger.SpecialInstructions);
            else Assert.DoesNotContain("Hold ketchup", burger.SpecialInstructions);

            if (!includeMustard) Assert.Contains("Hold mustard", burger.SpecialInstructions);
            else Assert.DoesNotContain("Hold mustard", burger.SpecialInstructions);

            if (!includePickle) Assert.Contains("Hold pickle", burger.SpecialInstructions);
            else Assert.DoesNotContain("Hold pickle", burger.SpecialInstructions);

            if (!includeCheese) Assert.Contains("Hold cheese", burger.SpecialInstructions);
            else Assert.DoesNotContain("Hold cheese", burger.SpecialInstructions);

            if (!includeTomato) Assert.Contains("Hold tomato", burger.SpecialInstructions);
            else Assert.DoesNotContain("Hold tomato", burger.SpecialInstructions);

            if (!includeLettuce) Assert.Contains("Hold lettuce", burger.SpecialInstructions);
            else Assert.DoesNotContain("Hold lettuce", burger.SpecialInstructions);

            if (!includeMayo) Assert.Contains("Hold mayo", burger.SpecialInstructions);
            else Assert.DoesNotContain("Hold mayo", burger.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.Equal("Double Draugr", burger.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(burger);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(burger);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedInterface()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnBun()
        {
            DoubleDraugr burger = new DoubleDraugr();

            Assert.PropertyChanged(burger, "Bun", () =>
            {
                burger.Bun = false;
            });

            Assert.PropertyChanged(burger, "Bun", () =>
            {
                burger.Bun = true;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnKetchup()
        {
            DoubleDraugr burger = new DoubleDraugr();

            Assert.PropertyChanged(burger, "Ketchup", () =>
            {
                burger.Ketchup = false;
            });

            Assert.PropertyChanged(burger, "Ketchup", () =>
            {
                burger.Ketchup = true;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnMustard()
        {
            DoubleDraugr burger = new DoubleDraugr();

            Assert.PropertyChanged(burger, "Mustard", () =>
            {
                burger.Mustard = false;
            });

            Assert.PropertyChanged(burger, "Mustard", () =>
            {
                burger.Mustard = true;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnPickle()
        {
            DoubleDraugr burger = new DoubleDraugr();

            Assert.PropertyChanged(burger, "Pickle", () =>
            {
                burger.Pickle = false;
            });

            Assert.PropertyChanged(burger, "Pickle", () =>
            {
                burger.Pickle = true;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnCheese()
        {
            DoubleDraugr burger = new DoubleDraugr();

            Assert.PropertyChanged(burger, "Cheese", () =>
            {
                burger.Cheese = false;
            });

            Assert.PropertyChanged(burger, "Cheese", () =>
            {
                burger.Cheese = true;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnTomato()
        {
            DoubleDraugr burger = new DoubleDraugr();

            Assert.PropertyChanged(burger, "Tomato", () =>
            {
                burger.Tomato = false;
            });

            Assert.PropertyChanged(burger, "Tomato", () =>
            {
                burger.Tomato = true;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnLettuce()
        {
            DoubleDraugr burger = new DoubleDraugr();

            Assert.PropertyChanged(burger, "Lettuce", () =>
            {
                burger.Lettuce = false;
            });

            Assert.PropertyChanged(burger, "Lettuce", () =>
            {
                burger.Lettuce = true;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnMayo()
        {
            DoubleDraugr burger = new DoubleDraugr();

            Assert.PropertyChanged(burger, "Mayo", () =>
            {
                burger.Mayo = false;
            });

            Assert.PropertyChanged(burger, "Mayo", () =>
            {
                burger.Mayo = true;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnSpecialInstructions()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Bun = false;
            });

            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Ketchup = false;
            });

            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Mustard = false;
            });

            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Lettuce = false;
            });
        }

        [Fact]
        public void ShouldHaveDescription()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.True(burger.Description.Length > 0);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            DoubleDraugr burger = new DoubleDraugr();
            Assert.Equal("Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.", burger.Description);
        }
    }
}