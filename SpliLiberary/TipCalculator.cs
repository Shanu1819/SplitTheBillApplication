using System;
using System.Collections.Generic;

public class TipCalculator
{
    public Dictionary<string, decimal> CalculateTip(Dictionary<string, decimal> mealCosts, float tipPercentage)
    {
        // Calculate total cost of all meals
        decimal totalCost = 0m;
        foreach (var cost in mealCosts.Values)
        {
            totalCost += cost;
        }

        // Calculate total tip
        decimal totalTip = totalCost * (decimal)(tipPercentage / 100);

        // Calculate weighted average tip for each person
        Dictionary<string, decimal> tipPerPerson = new Dictionary<string, decimal>();
        foreach (var meal in mealCosts)
        {
            decimal tipForPerson = meal.Value / totalCost * totalTip;
            tipPerPerson.Add(meal.Key, tipForPerson);
        }

        return tipPerPerson;
    }
    
}
