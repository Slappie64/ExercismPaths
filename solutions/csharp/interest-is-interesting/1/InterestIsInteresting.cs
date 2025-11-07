static class SavingsAccount
{
    public static float InterestRate(decimal balance) => balance switch
    {
            _ when balance >= 5000 => 2.475f,
            _ when balance < 5000 && balance >= 1000 => 1.621f,
            _ when balance < 1000 && balance >= 0 => 0.5f,
            _ when balance < 0 => 3.213f
    };

    public static decimal Interest(decimal balance) => balance * ((decimal)InterestRate(balance)/100);

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int yearsElapsed = 0;
        while (balance < targetBalance) 
        { 
            balance = AnnualBalanceUpdate(balance); 
            yearsElapsed += 1; 
        }
        return yearsElapsed;
    }
}
