namespace EnemyTest
{
    using BlaisePascal.EserczioEnemy.Domain;
    using Xunit;

    public class EnemyTest
    {
        [Fact]
        public void Enemy_ShouldInitializeWithGivenValues()
        {
            
            Enemy enemy = new Enemy("Goblin", 80, 15);

            
            Assert.Equal("Goblin", enemy.Name);
            Assert.Equal(80, enemy.Health);
            Assert.Equal(15, enemy.Damage);
            Assert.True(enemy.IsAlive());
        }

        [Fact]
        public void Enemy_ShouldClampHealthToZero_WhenInitializedWithNegativeHealth()
        {
            
            Enemy enemy = new Enemy("Orc", -50, 20);

            
            Assert.Equal(0, enemy.Health);
            Assert.False(enemy.IsAlive());
        }

        [Fact]
        public void Enemy_ShouldClampHealthToOneHundred_WhenInitializedWithHealthExceedingMax()
        {
            
            Enemy enemy = new Enemy("Dragon", 150, 50);

            
            Assert.Equal(100, enemy.Health);
        }

        [Fact]
        public void TakeDamage_ShouldReduceHealth_WhenPositiveDamageIsApplied()
        {
            
            Enemy enemy = new Enemy("Skeleton", 100, 10);

            
            enemy.TakeDamage(30);

            
            Assert.Equal(70, enemy.Health);
            Assert.True(enemy.IsAlive());
        }

        [Fact]
        public void TakeDamage_ShouldSetHealthToZero_WhenDamageExceedsCurrentHealth()
        {
            
            Enemy enemy = new Enemy("Troll", 50, 15);

            
            enemy.TakeDamage(80);

            
            Assert.Equal(0, enemy.Health);
            Assert.False(enemy.IsAlive());
        }

        [Fact]
        public void TakeDamage_ShouldNotChangeHealth_WhenDamageIsZeroOrNegative()
        {
            
            Enemy enemy = new Enemy("Zombie", 60, 12);

            
            enemy.TakeDamage(0);
            enemy.TakeDamage(-15);

            
            Assert.Equal(60, enemy.Health);
        }

        [Fact]
        public void IsAlive_ShouldReturnFalse_WhenHealthIsZero()
        {
            
            Enemy enemy = new Enemy("Ghost", 0, 5);

            
            Assert.False(enemy.IsAlive());
        }
    }
}
