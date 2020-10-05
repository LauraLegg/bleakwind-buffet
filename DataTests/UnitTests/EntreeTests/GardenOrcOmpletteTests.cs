/*
 * Author: Zachery Brunner
 * Modified by: Laura Legg
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.True(omelette.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.True(omelette.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.True(omelette.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.True(omelette.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Broccoli = false;
            Assert.False(omelette.Broccoli);
            omelette.Broccoli = true;
            Assert.True(omelette.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Mushrooms = false;
            Assert.False(omelette.Mushrooms);
            omelette.Mushrooms = true;
            Assert.True(omelette.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Tomato = false;
            Assert.False(omelette.Tomato);
            omelette.Tomato = true;
            Assert.True(omelette.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Cheddar = false;
            Assert.False(omelette.Cheddar);
            omelette.Cheddar = true;
            Assert.True(omelette.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.Equal(4.57, omelette.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.Equal((uint) 404, omelette.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Broccoli = includeBroccoli;
            omelette.Mushrooms = includeMushrooms;
            omelette.Tomato = includeTomato;
            omelette.Cheddar = includeCheddar;

            if (!includeBroccoli) Assert.Contains("Hold broccoli", omelette.SpecialInstructions);
            else Assert.DoesNotContain("Hold broccoli", omelette.SpecialInstructions);

            if (!includeMushrooms) Assert.Contains("Hold mushrooms", omelette.SpecialInstructions);
            else Assert.DoesNotContain("Hold mushrooms", omelette.SpecialInstructions);

            if (!includeTomato) Assert.Contains("Hold tomato", omelette.SpecialInstructions);
            else Assert.DoesNotContain("Hold tomato", omelette.SpecialInstructions);

            if (!includeCheddar) Assert.Contains("Hold cheddar", omelette.SpecialInstructions);
            else Assert.DoesNotContain("Hold cheddar", omelette.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", omelette.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(omelette);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(omelette);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedInterface()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(omelette);
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnBroccoli()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();

            Assert.PropertyChanged(omelette, "Broccoli", () =>
            {
                omelette.Broccoli = false;
            });

            Assert.PropertyChanged(omelette, "Broccoli", () =>
            {
                omelette.Broccoli = true;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnMushrooms()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();

            Assert.PropertyChanged(omelette, "Mushrooms", () =>
            {
                omelette.Mushrooms = false;
            });

            Assert.PropertyChanged(omelette, "Mushrooms", () =>
            {
                omelette.Mushrooms = true;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnTomato()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();

            Assert.PropertyChanged(omelette, "Tomato", () =>
            {
                omelette.Tomato = false;
            });

            Assert.PropertyChanged(omelette, "Tomato", () =>
            {
                omelette.Tomato = true;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnCheddar()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();

            Assert.PropertyChanged(omelette, "Cheddar", () =>
            {
                omelette.Cheddar = false;
            });

            Assert.PropertyChanged(omelette, "Cheddar", () =>
            {
                omelette.Cheddar = true;
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnSpecialInstructions()
        {
            GardenOrcOmelette omelette = new GardenOrcOmelette();
            omelette.Broccoli = false;
            Assert.PropertyChanged(omelette, "SpecialInstructions", () => omelette.SpecialInstructions.Contains("Hold broccoli"));
            omelette.Mushrooms = false;
            Assert.PropertyChanged(omelette, "SpecialInstructions", () => omelette.SpecialInstructions.Contains("Hold mushrooms"));
            omelette.Tomato = false;
            Assert.PropertyChanged(omelette, "SpecialInstructions", () => omelette.SpecialInstructions.Contains("Hold tomato"));
            omelette.Cheddar = false;
            Assert.PropertyChanged(omelette, "SpecialInstructions", () => omelette.SpecialInstructions.Contains("Hold cheddar"));
        }
    }
}