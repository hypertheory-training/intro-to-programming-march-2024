



namespace Bank;

public class BankAccount
{
    private decimal _currentBalance = 5000M;
    public void Deposit(decimal amountToDeposit)
    {
        _currentBalance += amountToDeposit;
    }

    public decimal GetBalance()
    {
        return _currentBalance;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if (amountToWithdraw < 0)
        {

            throw new InvalidTransactionAmountException();
        }
        _currentBalance -= amountToWithdraw;
    }
    // Overloaded the Withdraw
    public void Withdraw(Money money)
    {

        _currentBalance -= money.Amount;
    }
}

public class Money
{
    public decimal Amount { get; private set; }
    public Currency Currency { get; private set; }
    private Money() { }
    public static Money FromUsd(decimal amount)
    {
        if (amount < 0)
        {
            throw new Exception();
        }
        return new Money { Amount = amount, Currency = Currency.USD };
    }
}
public enum Currency { USD, EUR, YEN };