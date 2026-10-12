using BlaisePascal.EsercizioEnemy.Domain;
using System.Security.Cryptography.X509Certificates;
namespace BlaisePascal.EsercizioEnemy.Test
{
    using System;
    using Xunit;

    public class PlayerTest
    {
        [Fact]
        public void Player_ShouldStartAtLevelOne()
        {
            Player player = new Player("Antonio Raimondo");
            Assert.Equal(1, player.Level);
        }

        [Fact]
        public void Player_ShouldStartWithZeroGold()
        {
            Player player = new Player("Antonio Raimondo");
            Assert.Equal(0, player.Gold);
        }

        [Fact]
        public void Player_ShouldStartWithFullHealth()
        {
            Player player = new Player("Antonio Raimondo");
            Assert.Equal(100, player.Health);
        }

        [Fact]
        public void Player_ShouldStartWithZeroExperience()
        {
            Player player = new Player("Antonio Raimondo");
            Assert.Equal(0, player.Experience);
        }

        [Fact]
        public void TakeDamage_ShouldReduceHealth_WhenDamageIsTaken()
        {
            Player player = new Player("Antonio Raimondo");

            player.TakeDamage(30);

            Assert.Equal(70, player.Health);
            Assert.True(player.IsAlive);
        }

        [Fact]
        public void TakeDamage_ShouldSetHealthToZeroAndKillPlayer_WhenDamageIsLethal()
        {
            Player player = new Player("Antonio Raimondo");

            player.TakeDamage(120);

            Assert.Equal(0, player.Health);
            Assert.False(player.IsAlive);
        }

        [Fact]
        public void Heal_ShouldIncreaseHealth_WhenDamaged()
        {
            Player player = new Player("Antonio Raimondo");
            player.TakeDamage(40);

            player.Heal(20);

            Assert.Equal(80, player.Health);
        }

        [Fact]
        public void Heal_ShouldNotExceedMaxHealth()
        {
            Player player = new Player("Antonio Raimondo");
            player.TakeDamage(10);

            player.Heal(50);

            Assert.Equal(100, player.Health);
        }

        [Fact]
        public void AddGold_ShouldIncreaseGoldAmount()
        {
            Player player = new Player("Antonio Raimondo");

            player.AddGold(50);

            Assert.Equal(50, player.Gold);
        }

        [Fact]
        public void AddExperience_ShouldIncreaseLevel_WhenThresholdReached()
        {
            Player player = new Player("Antonio Raimondo");

            player.AddExperience(250);

            Assert.Equal(3, player.Level);
        }

        [Fact]
        public void ResetExperience_ShouldSetExperienceToZero()
        {
            Player player = new Player("Antonio Raimondo");

            player.ResetExperience();

            Assert.Equal(0, player.Experience);
        }

        [Fact]
        public void ResetHealth_ShouldRestoreHealthAndIsAlive()
        {
            Player player = new Player("Antonio Raimondo");
            player.TakeDamage(100); 

            player.ResetHealth();

            Assert.True(player.IsAlive);
            Assert.Equal(player.MaxHealth, player.Health);
        }
    }
}
