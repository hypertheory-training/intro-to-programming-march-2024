
using Bank;

namespace Banking.UnitTests.Accounts;


// Just an object that takes the place of something real, but has no logic, doesn't pass or
// fail the test, any of that kind of thing.
public class DummyBonusCalculator : ICalculateBonusesForDeposits
{
    public decimal CalculateDepositBonusFor(decimal currentBalance, decimal amountToDeposit)
    {
        return 0;
    }
}