using System;
using System.Collections.Generic;
public class DecimalPriceTip
{

    public static decimal CalculateTipPerPerson(decimal mealPrice, int numberOfPatrons, float tipPercentage)
    {
        // Calculate total tip
        decimal totalTip = mealPrice * (decimal)(tipPercentage / 100);

        // Calculate tip per person
        decimal tipPerPerson = totalTip / numberOfPatrons;

        return tipPerPerson;
    }
}

