using shoot_me_up;
using System;

namespace TestShootMeUp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIfMissileIfDeletedWhenOutOfForm()
        {
            //arrange
            Game game = new Game(0,0,2);
            var missile = new Missile(new System.Drawing.Point(-40, -40));
            game.missiles.Add(missile);
            game.Controls.Add(missile);

            //act
            game.Timer_Tick(null, null);

            //assert
            Assert.IsFalse(game.missiles.Contains(missile), "Missile should be removed if it goes out of the form.");
        }
        [TestMethod]
        public void TestIfShipLoseLifeWhenEnnemyIsOutOfForm()
        {
            //arrange
            Game game = new Game(0, 0, 2);
            var ennemy = new Ennemy(new System.Drawing.Point(10000, 10000));//en dehors du form
            game.ennemiesPublic.Add(ennemy);

            // Act
            game.Timer_Tick(null, null);

            // Assert
            Assert.AreEqual(2, game.shipLifePublic, "Ship life should decrease when an enemy goes out of the form.");
        }
        [TestMethod]
        public void TestIfEnnemyIsDeletedWhenCollidingWithAnEnnemy()
        {
            //arrange
            Game game = new Game(0, 0, 2);
            var ennemy = new Ennemy(new System.Drawing.Point(100, 100));
            var missile = new Missile(new System.Drawing.Point(100, 100));//same coords as ennemy
            game.ennemiesPublic.Add(ennemy);
            game.missiles.Add(missile);

            //act
            game.Timer_Tick(null, null);

            //assert
            Assert.IsFalse(game.ennemiesPublic.Contains(ennemy), "Ennemy should be removed when colliding with a missile");
        }
        [TestMethod]
        public void TestIfMissileAreDeletedWhenCollingWithAnObstacle()
        {
            //arrange
            Game game = new Game(0, 0, 2);
            var obstacle = new Obstacle(new System.Drawing.Point(100, 100));
            var missile = new Missile(new System.Drawing.Point(100, 100));//same coords as ennemy
            game.missiles.Add(missile);
            game.obstaclesPublic.Add(obstacle);

            //act
            game.Timer_Tick(null, null);

            //assert
            Assert.IsFalse(game.missiles.Contains(missile), "Missile should be removed when colliding with an obstacle");
        }
    }
}