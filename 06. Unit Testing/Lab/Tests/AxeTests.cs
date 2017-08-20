﻿using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    [Test]
    public void AxeLoseDurabilityAfterAttack()
    {
        //Arrange
        Axe axe = new Axe(10, 10);
        Dummy dummy = new Dummy(10, 10);

        //Act
        axe.Attack(dummy);

        //Assert
        Assert.AreEqual(9, axe.DurabilityPoints, "Axe Durability doesn't change attack");
    }
}