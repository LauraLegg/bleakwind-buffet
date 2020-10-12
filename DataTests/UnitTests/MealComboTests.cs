/*
 * Author: Laura Legg
 * Class name: MealComboTests.cs
 * Purpose: Tests the MealCombo Class
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

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MealComboTests
    {
        [Fact]
        public void FactTest()
        {
            MealCombos meal = new MealCombos();
            meal.Entree = new BriarheartBurger();
            AretinoAppleJuice drink = new AretinoAppleJuice();
            meal.Drink = drink;
            Assert.Equal(5.94, meal.Price);
            drink.Size = Size.Large;
            Assert.Equal(6.33, meal.Price);
            drink.Size = Size.Medium;
            Assert.Equal(6.19, meal.Price);
        }

        [Fact]
        public void ShouldBeAbleToSetEntree()
        {
            MealCombos meal = new MealCombos();
            meal.Entree = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", meal.Entree.ToString());

            meal.Entree = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", meal.Entree.ToString());

            meal.Entree = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", meal.Entree.ToString());
        }

        [Fact]
        public void ShouldBeAbleToSetDrink()
        {
            MealCombos meal = new MealCombos();
            meal.Drink = new AretinoAppleJuice();
            Assert.Equal("Small Aretino Apple Juice", meal.Drink.ToString());

            meal.Drink = new CandlehearthCoffee();
            Assert.Equal("Small Candlehearth Coffee", meal.Drink.ToString());

            meal.Drink = new WarriorWater();
            Assert.Equal("Small Warrior Water", meal.Drink.ToString());
        }

        [Fact]
        public void ShouldBeAbleToSetSide()
        {
            MealCombos meal = new MealCombos();
            meal.Side = new FriedMiraak();
            Assert.Equal("Small Fried Miraak", meal.Side.ToString());

            meal.Side = new VokunSalad();
            Assert.Equal("Small Vokun Salad", meal.Side.ToString());
        }

        [Fact]
        public void PriceShouldReturnCorrectComboPrice()
        {
            MealCombos meal = new MealCombos();
            meal.Entree = new BriarheartBurger();
            Assert.Equal(5.32, meal.Price);

            meal.Drink = new SailorSoda();
            Assert.Equal(6.74, meal.Price);

            meal.Side = new DragonbornWaffleFries();
            Assert.Equal(7.16, meal.Price);
        }

        [Fact]
        public void ShouldReturnCorrectPriceIfSizeIsChanged()
        {
            MealCombos meal = new MealCombos();

            meal.Entree = new BriarheartBurger();
            meal.Drink = new AretinoAppleJuice();
            meal.Drink.Size = Size.Medium;
            Assert.Equal(6.19, meal.Price);

            meal.Side = new VokunSalad();
            meal.Side.Size = Size.Large;
            Assert.Equal(8.01, meal.Price);
        }

        [Fact]
        public void CaloriesShouldReturnCorrectNumberOfCaloriesForCombo()
        {
            MealCombos meal = new MealCombos();
            meal.Entree = new BriarheartBurger();
            Assert.Equal((uint)743, meal.Calories);

            meal.Drink = new AretinoAppleJuice();
            Assert.Equal((uint)787, meal.Calories);

            meal.Side = new MadOtarGrits();
            Assert.Equal((uint) 892, meal.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectCaloriesIfSizeIsChanged()
        {
            MealCombos meal = new MealCombos();

            meal.Entree = new BriarheartBurger();
            meal.Drink = new AretinoAppleJuice();
            meal.Drink.Size = Size.Medium;
            Assert.Equal((uint)831, meal.Calories);

            meal.Side = new VokunSalad();
            meal.Side.Size = Size.Large;
            Assert.Equal((uint)904, meal.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            MealCombos meal = new MealCombos();
            BriarheartBurger burger = new BriarheartBurger();
            burger.Bun = false;
            meal.Entree = burger;
            Assert.Contains("Briarheart Burger", meal.SpecialInstructions);
            Assert.Contains(" - Hold bun", meal.SpecialInstructions);

            AretinoAppleJuice drink = new AretinoAppleJuice();
            drink.Ice = true;
            meal.Drink = drink;
            Assert.Contains("Small Aretino Apple Juice", meal.SpecialInstructions);
            Assert.Contains(" - Add ice", meal.SpecialInstructions);

            MadOtarGrits grits = new MadOtarGrits();
            grits.Size = Size.Medium;
            meal.Side = grits;
            Assert.Contains("Medium Mad Otar Grits", meal.SpecialInstructions);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            MealCombos meal = new MealCombos();
            Assert.IsAssignableFrom<IOrderItem>(meal);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedInterface()
        {
            MealCombos meal = new MealCombos();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(meal);
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnPrice()
        {
            MealCombos meal = new MealCombos();
            Assert.PropertyChanged(meal, "Price", ()=> 
            {
                meal.Entree = new BriarheartBurger();
            });

            Assert.PropertyChanged(meal, "Price", () =>
            {
                meal.Drink = new AretinoAppleJuice();
            });

            Assert.PropertyChanged(meal, "Price", () =>
            {
                meal.Side = new DragonbornWaffleFries();
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnCalories()
        {
            MealCombos meal = new MealCombos();
            Assert.PropertyChanged(meal, "Calories", () =>
            {
                meal.Entree = new BriarheartBurger();
            });

            Assert.PropertyChanged(meal, "Calories", () =>
            {
                meal.Drink = new AretinoAppleJuice();
            });

            Assert.PropertyChanged(meal, "Calories", () =>
            {
                meal.Side = new DragonbornWaffleFries();
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnSpecialInstructions()
        {
            MealCombos meal = new MealCombos();
            Assert.PropertyChanged(meal, "SpecialInstructions", () =>
            {
                meal.Entree = new BriarheartBurger();
            });

            Assert.PropertyChanged(meal, "SpecialInstructions", () =>
            {
                meal.Drink = new AretinoAppleJuice();
            });

            Assert.PropertyChanged(meal, "SpecialInstructions", () =>
            {
                meal.Side = new DragonbornWaffleFries();
            });
        }
    }
}
