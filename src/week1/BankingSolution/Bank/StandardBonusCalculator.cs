﻿
namespace Bank;
public class StandardBonusCalculator
{
    // A class is a thing that takes responsibility for a specific "thing" in the application.
    // It owns that knowledge - the state, the state process (how things happen)

    public decimal CalculateBonus(decimal balance, decimal amountOfDeposit)
    {
        return balance >= 5000M ? amountOfDeposit * .10M : 0;
    }
}
