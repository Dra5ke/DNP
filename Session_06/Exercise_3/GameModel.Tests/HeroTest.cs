using Xunit;
using GameModel;
using System;

namespace GameModel.Tests
{
    public class HeroTest
    {
        [Fact]
        public void IsAlive_HitPointsAreAboveZero_ShouldReturnTrue()
        {
            // Arrange
            var hero = CreateDeafultHero();
            hero.HitPoints = 1;

            // Act
            var actual = hero.IsAlive();

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsAlive_HitPointsAreZero_ShouldReturnFalse()
        {
            var hero = CreateDeafultHero();
            hero.HitPoints = 0;

            var actual = hero.IsAlive();

            Assert.False(actual);
        }
        
        [Fact]
        public void IsAlive_HitPointsAreBelowZero_ShouldReturnFalse()
        {
            var hero = CreateDeafultHero();
            hero.HitPoints = -1;

            var actual = hero.IsAlive();

            Assert.False(actual);
        }

        [Fact]
        public void Attack_NotAlive_ShouldReturnZero()
        {
            var hero = CreateDeafultHero();
            hero.HitPoints = 0;

            var actual = hero.Attack();

            Assert.Equal(0, actual);
        }

        [Theory]
        [InlineData(12)]
        [InlineData(5)]
        public void Attack_WithoutWeapon_ShouldReturnAttackValueFromStrengthOnly(int input)
        {
            var hero = CreateDeafultHero();
            hero.Strength = input;
            hero.MainHandWeapon = null;

            var actual = hero.Attack();

            Assert.Equal(input / 2, actual);
        }

        [Theory]
        [InlineData(12, 6)]
        [InlineData(6, 3)]
        public void Attack_WithWeaponWithAttackOne_ShouldReturnAttackValue(int input, int expected)
        {
            var hero = CreateDeafultHero();
            var weapon = CreateTestWeaponAttackOne();
            hero.MainHandWeapon = weapon;
            hero.Strength = input;

            var actual = hero.Attack();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 5, 5)]
        [InlineData(15, 8, 60)]
        public void Attack_WithWeapon_ShouldReturnAttackValue(int inputAttack, int inputStrength, int expected)
        {
            var hero = CreateDeafultHero();
            var weapon = CreateTestWeaponAttackOne();
            weapon.Attack = inputAttack;
            hero.MainHandWeapon = weapon;
            hero.Strength = inputStrength;

            var actual = hero.Attack();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Defend_WithDefenceZero_ShouldSubtractFromHitPoints()
        {
            var hero = CreateDeafultHero();
            var opponent = CreateTestOpponent();
            hero.HitPoints = 6;

            hero.Defend(opponent);
            var actual = hero.HitPoints;

            Assert.Equal(0, actual);
        }

        [Fact]
        public void Defend_WithDefenceAboveZero_ShouldSubtractFromHitpoints()
        {
            var hero = CreateDeafultHero();
            var opponent = CreateTestOpponent();
            hero.HitPoints = 6;
            hero.Defence = 6;

            hero.Defend(opponent);
            var actual = hero.HitPoints;

            Assert.Equal(6, actual);
        }

        [Fact]
        public void Defend_IsKilledFromAttack_HitPointsShouldNotGoBelowZero()
        {
            var hero = CreateDeafultHero();
            var opponent = CreateTestOpponent();
            hero.HitPoints = 3;

            hero.Defend(opponent);
            var actual = hero.HitPoints;

            Assert.Equal(0, actual);
        }

        [Fact]
        public void Defend_OpponentIsNull_ShouldThrowArgumentNullException()
        {
            var hero = CreateDeafultHero();
            
            Action actual = () => hero.Defend(null);

            Assert.Throws<ArgumentNullException>(actual);
        }

        private Hero CreateDeafultHero()
        {
            return new Hero();
        }

        private Weapon CreateTestWeaponAttackOne()
        {
            return new Weapon(){ Attack = 1 };
        }

        private Hero CreateTestOpponent()
        {
            return new Hero(){ Strength = 12, MainHandWeapon = CreateTestWeaponAttackOne(), Defence = 6 };
        }
    }
}