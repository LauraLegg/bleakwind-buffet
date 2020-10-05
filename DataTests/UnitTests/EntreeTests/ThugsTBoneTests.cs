/*
 * Author: Zachery Brunner
 * Modified by: Laura Legg
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone bone = new ThugsTBone();
            Assert.Equal(6.44, bone.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone bone = new ThugsTBone();
            Assert.Equal((uint) 982, bone.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone bone = new ThugsTBone();
            Assert.Empty(bone.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone bone = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", bone.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            ThugsTBone bone = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(bone);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractIOrderItemClass()
        {
            ThugsTBone bone = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(bone);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChangedInterface()
        {
            ThugsTBone bone = new ThugsTBone();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bone);
        }
    }
}