/*
 * Author: Zachery Brunner
 * Modified by: Laura Legg
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.True(burger.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Bun = false;
            Assert.False(burger.Bun);
            burger.Bun = true;
            Assert.True(burger.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);
            burger.Ketchup = true;
            Assert.True(burger.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Mustard = false;
            Assert.False(burger.Mustard);
            burger.Mustard = true;
            Assert.True(burger.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Pickle = false;
            Assert.False(burger.Pickle);
            burger.Pickle = true;
            Assert.True(burger.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Cheese = false;
            Assert.False(burger.Cheese);
            burger.Cheese = true;
            Assert.True(burger.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.Equal(6.32, burger.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.Equal((uint) 743, burger.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger burger = new BriarheartBurger();
            burger.Bun = includeBun;
            burger.Ketchup = includeKetchup;
            burger.Mustard = includeMustard;
            burger.Pickle = includePickle;
            burger.Cheese = includeCheese;
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
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", burger.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(burger);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(burger);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedInterface()
        {
            BriarheartBurger burger = new BriarheartBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnBun()
        {
            BriarheartBurger burger = new BriarheartBurger();

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
            BriarheartBurger burger = new BriarheartBurger();

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
            BriarheartBurger burger = new BriarheartBurger();

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
            BriarheartBurger burger = new BriarheartBurger();

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
            BriarheartBurger burger = new BriarheartBurger();

            Assert.PropertyChanged(burger, "Cheese", () =>
            {
                burger.Cheese = false;
            });

            Assert.PropertyChanged(burger, "Cheese", () =>
            {
                burger.Cheese = true;
            });
        }
    }
}