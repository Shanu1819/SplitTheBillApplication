using System;
using SpliLiberary;

using System.Collections.Generic;

[TestClass]
public class DecimalPriceTipTests
{
    [TestMethod]
    public void CalculateTip_With_ZeroPrice_And_ZeroTipPerPerson()
    {
        decimal mealPrice = 0.0m;
        int numberOfPatrons = 5;
        float tipPercentage = 10.0f;

        decimal tipPerPerson = DecimalPriceTip.CalculateTipPerPerson(mealPrice, numberOfPatrons, tipPercentage);

        // Assert
        Assert.AreEqual(0.0m, tipPerPerson);
    }
    
    [TestMethod]
     public void CalculateTip_With_DifferentPrice_And_ZeroTipPerPerson()
    {
       decimal mealPrice = 175.0m;
        int numberOfPatrons = 2;
        float tipPercentage = 28.5f;

        decimal tipPerPerson = DecimalPriceTip.CalculateTipPerPerson(mealPrice, numberOfPatrons, tipPercentage);

        // Assert
        Assert.AreEqual(24.9375m, tipPerPerson);
    }

      [TestMethod]
    public void CalculateTip_With_SmallPrice_And_LargeNumber_Of_PatronsS()
    {
        // Arrange
        decimal mealPrice = 20.0m;
        int numberOfPatrons = 10;
        float tipPercentage = 28.0f;

        // Act
        decimal tipPerPerson = DecimalPriceTip.CalculateTipPerPerson(mealPrice, numberOfPatrons, tipPercentage);

        // Assert
        Assert.AreEqual(0.560m, tipPerPerson);
    }

}