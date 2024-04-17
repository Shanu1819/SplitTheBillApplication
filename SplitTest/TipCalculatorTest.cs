using System;
using SpliLiberary;

using System.Collections.Generic;

[TestClass]
public class TipCalculatorTests
{
    [TestMethod]
    public void CalculateTip_EqualSplit()
    {
        // Arrange
        var mealCosts = new Dictionary<string, decimal>
        {
            { "Shanu", 10.00m },
            { "Raman", 10.00m },
            { "Cherry", 10.00m }
        };
        float tipPercentage = 10.0f; // 10% tip

        var calculator = new TipCalculator();

        // Act
        var tipPerPerson = calculator.CalculateTip(mealCosts, tipPercentage);

        // Assert
        Assert.AreEqual(3, tipPerPerson.Count); // Each person should have a tip
        foreach (var tip in tipPerPerson.Values)
        {
            Assert.AreEqual(1.00m, tip); // Each person's tip should be $1.00
        }
    }

    [TestMethod]
    public void CalculateTip_ZeroTip()
    {
        // Arrange
        var mealCosts = new Dictionary<string, decimal>
        {
            { "Shanu", 20.00m },
            { "Raman", 30.00m },
            { "Cherry", 40.00m }
        };
        float tipPercentage = 0.0f; // 0% tip

        var calculator = new TipCalculator();

        // Act
        var tipPerPerson = calculator.CalculateTip(mealCosts, tipPercentage);

        // Assert
        Assert.AreEqual(3, tipPerPerson.Count); // Each person should have a tip
        foreach (var tip in tipPerPerson.Values)
        {
            Assert.AreEqual(0.00m, tip); // Each person's tip should be $0.00
        }
    }
}
