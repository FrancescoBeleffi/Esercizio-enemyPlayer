using BlaisePascal.EsercizioEnemy.Domain;
using System.Security.Cryptography.X509Certificates;
namespace BlaisePascal.EsercizioEnemy.Test
{
    public class EnemyTest
    {
        [Fact]
        public void Player_ShouldStartAtLevelOne()
        {
            Player player = new Player("Antonio Raimondo");
            Assert.Equal(1, player.Level);

        }

        public void Player_ShouldStartWithZeroGold()
        {
            Player player = new Player("Antonio Raimondo");
            Assert.Equal(0, player.Gold);
        }

        public void Player_ShouldStartWithFullHealth()
        {
            Player player = new Player("Antonio Raimondo");
            Assert.Equal(100, player.Health);
        }

            public void Player_ShouldStartWithZeroExperience()
            {
                Player player = new Player("Antonio Raimondo");
                Assert.Equal(0, player.Experience);

            }
    }
}
