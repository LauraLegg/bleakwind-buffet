/*
 * Author: Zachery Brunner
 * Modified by: Laura Legg
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Bun = false;
            Assert.False(burger.Bun);
            burger.Bun = true;
            Assert.True(burger.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Ketchup = false;
            Assert.False(burger.Ketchup);
            burger.Ketchup = true;
            Assert.True(burger.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Mustard = false;
            Assert.False(burger.Mustard);
            burger.Mustard = true;
            Assert.True(burger.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Pickle = false;
            Assert.False(burger.Pickle);
            burger.Pickle = true;
            Assert.True(burger.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Cheese = false;
            Assert.False(burger.Cheese);
            burger.Cheese = true;
            Assert.True(burger.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Tomato = false;
            Assert.False(burger.Tomato);
            burger.Tomato = true;
            Assert.True(burger.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Lettuce = false;
            Assert.False(burger.Lettuce);
            burger.Lettuce = true;
            Assert.True(burger.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Mayo = false;
            Assert.False(burger.Mayo);
            burger.Mayo = true;
            Assert.True(burger.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Bacon = false;
            Assert.False(burger.Bacon);
            burger.Bacon = true;
            Assert.True(burger.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Egg = false;
            Assert.False(burger.Egg);
            burger.Egg = true;
            Assert.True(burger.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.Equal(8.32, burger.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.Equal((uint) 943, burger.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple burger = new ThalmorTriple();
            burger.Bun = includeBun;
            burger.Ketchup = includeKetchup;
            burger.Mustard = includeMustard;
            burger.Pickle = includePickle;
            burger.Cheese = includeCheese;
            burger.Tomato = includeTomato;
            burger.Lettuce = includeLettuce;
            burger.Mayo = includeMayo;
            burger.Bacon = includeBacon;
            burger.Egg = includeEgg;

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

            if (!includeBacon) Assert.Contains("Hold bacon", burger.SpecialInstructions);
            else Assert.DoesNotContain("Hold bacon", burger.SpecialInstructions);

            if (!includeEgg) Assert.Contains("Hold egg", burger.SpecialInstructions);
            else Assert.DoesNotContain("Hold egg", burger.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", burger.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(burger);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(burger);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedInterface()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnBun()
        {
            ThalmorTriple burger = new ThalmorTriple();

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
            ThalmorTriple burger = new ThalmorTriple();

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
            ThalmorTriple burger = new ThalmorTriple();

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
            ThalmorTriple burger = new ThalmorTriple();

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
            ThalmorTriple burger = new ThalmorTriple();

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
            ThalmorTriple burger = new ThalmorTriple();

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
            ThalmorTriple burger = new ThalmorTriple();

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
            ThalmorTriple burger = new ThalmorTriple();

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
        public void PropertyChangedShouldBeInvokedOnBacon()
        {
            ThalmorTriple burger = new ThalmorTriple();

            Assert.PropertyChanged(burger, "Bacon", () =>
            {
                burger.Bacon = false;
            });

            Assert.PropertyChanged(burger, "Bacon", () =>
            {
                burger.Bacon = true;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnEgg()
        {
            ThalmorTriple burger = new ThalmorTriple();

            Assert.PropertyChanged(burger, "Egg", () =>
            {
                burger.Egg = false;
            });

            Assert.PropertyChanged(burger, "Egg", () =>
            {
                burger.Egg = true;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnSpecialInstructions()
        {
            ThalmorTriple burger = new ThalmorTriple();

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
                burger.Tomato = false;
            });

            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Egg = false;
            });
        }

        [Fact]
        public void ShouldHaveDescription()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.True(burger.Description.Length > 0);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            ThalmorTriple burger = new ThalmorTriple();
            Assert.Equal("Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.", burger.Description);
        }
    }
}