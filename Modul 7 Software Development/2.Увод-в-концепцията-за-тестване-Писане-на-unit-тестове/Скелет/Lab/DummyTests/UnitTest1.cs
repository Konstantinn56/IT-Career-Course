using System;
using NUnit.Framework;

namespace DummyTests
{
    public class Tests
    {
        [Test]
        public void DummyLoseHealthAfterAttack()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(0, dummy.Health, "Dummy does NOT lose health after attack");
        }

        [Test]
        public void DeadDummyTrowsExceptionDuringAttack()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(1, 1);

            //Killing the dummy
            axe.Attack(dummy);

            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));//landa expresion 
            Assert.AreEqual(ex.Message, "Dummy is dead.");
        }

        [Test]
        public void DeadDummyCanReturnXp()
        {
            //Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            //Act
            axe.Attack(dummy);

            //Assert
            Assert.AreEqual(10, dummy.GiveExperience(), "Dead Dummy Does Not Gives Experiense.");
        }

        [Test]
        public void TheLivingDummyCanTReturnXp()
        {
            //Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(20, 10);

            //Act
            axe.Attack(dummy);

            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
            Assert.AreEqual(ex.Message, "Target is not dead.", "Dummy returns XP, while is alive");
        }
    }
}