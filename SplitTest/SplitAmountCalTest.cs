using System;
using SpliLiberary;


namespace SplitTest;

[TestClass]
public class SplitAmountCaltest
{

  [TestMethod]
    public void TotalAmount_is_Valid()
    {
        decimal totalAmount = 100m;
        int numberOfPeople = 4;
        decimal expectedSplitAmount = 25m;
        SplitAmountCal calculator = new SplitAmountCal();

        decimal actualSplitAmount = calculator.SplitAmount(totalAmount, numberOfPeople);
        // Assert
        Assert.AreEqual(expectedSplitAmount, actualSplitAmount);
    
    }

    [TestMethod]
    public void SplitAmount_is_Zero()
    {
        decimal totalAmount = 0m;
        int numberOfPeople = 5;
        decimal expectedSplitAmount = 0m;
        SplitAmountCal calculator = new SplitAmountCal();

        decimal actualSplitAmount = calculator.SplitAmount(totalAmount, numberOfPeople);
        // Assert
        Assert.AreEqual(expectedSplitAmount, actualSplitAmount);
    
    }

    [TestMethod]
    //This method will fail always bcz if number of people is less than zero tmethod will throw exception.
    public void SplitAmount_If_Number_Of_People_Is_Negative()
    {
        
        decimal totalAmount = 100.00m;
        int numberOfPeople = -5;
        SplitAmountCal calculator = new SplitAmountCal();
        decimal actualSplitAmount = calculator.SplitAmount(totalAmount, numberOfPeople);

        // Assert
       // Assert.AreEqual(0m, actualSplitAmount); 
       Assert.ThrowsException<ArgumentException>(() => calculator.SplitAmount(totalAmount, numberOfPeople));
    }
    
}