namespace SpliLiberary;
public class SplitAmountCal
{
    public decimal SplitAmount(decimal totalAmount, int numberOfPeople)
    {
        // Check if the number of people is valid (greater than 0)
        if (numberOfPeople <= 0)
        {
            throw new ArgumentException("Number of people must be greater than 0.", nameof(numberOfPeople));
        }

        // Check if the total amount is valid (non-negative)
        if (totalAmount < 0)
        {
            throw new ArgumentException("Total amount must be non-negative.", nameof(totalAmount));
        }

        // Calculate the split amount
        decimal splitAmount = totalAmount / numberOfPeople;

        return splitAmount;
    }
}

