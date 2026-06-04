static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0 ){
            return 3.213f;
        }
        else if (balance >= 0 && balance < 1000){
            return 0.5f;
        }
        else if (balance >= 1000 && balance < 5000){
            return 1.621f;
        }
        else if (balance >= 5000){
            return 2.475f;
        }
        throw new NotImplementedException("Please implement the (static) SavingsAccount.InterestRate() method");
    }

    public static decimal Interest(decimal balance)
    {
        if (balance < 0 ){
            decimal interest = 3.213M;
            return (interest / 100) * balance;
        }
        else if (balance >= 0 && balance < 1000){
            decimal interest  = 0.5M;
            return (interest / 100) * balance;
        }
        else if (balance >= 1000 && balance < 5000){
            decimal interest  = 1.621M;
            return (interest / 100) * balance;
        }
        else if (balance >= 5000){
            decimal interest  = 2.475M;
            return (interest / 100) * balance;
        }
        

        throw new NotImplementedException("Please implement the (static) SavingsAccount.Interest() method");
    }

    public static decimal AnnualBalanceUpdate(decimal balance){
        if (balance < 0 ){
            decimal interest = 3.213M;
            return balance + ((interest / 100) * balance);
        }
        else if (balance >= 0 && balance < 1000){
            decimal interest  = 0.5M;
            return balance + ((interest / 100) * balance);
        }
        else if (balance >= 1000 && balance < 5000){
            decimal interest  = 1.621M;
            return balance + ((interest / 100) * balance);
        }
        else if (balance >= 5000){
            decimal interest  = 2.475M;
            return balance + ((interest / 100) * balance);
        }
        
        throw new NotImplementedException("Please implement the (static) SavingsAccount.AnnualBalanceUpdate() method");
    }

public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance){
    int years = 0;
    decimal countBalance = balance;

    while (countBalance < targetBalance)
    {
        decimal interest;
        if (countBalance < 0){
            interest = 3.213M;
        }
        else if (countBalance < 1000){
            interest = 0.5M;
        }
        else if (countBalance < 5000){
            interest = 1.621M;
        }
        else {
            interest = 2.475M;
        }

        countBalance += (interest / 100) * countBalance;
        years++;
    }

    return years;
}
}