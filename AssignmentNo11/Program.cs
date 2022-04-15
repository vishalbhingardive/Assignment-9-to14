//11.Create Account class as Abstract and override some methods in saving_acoount and current_account class.
//A.Display account information Properties- Account- AccountId , Branch Location ,
//Balance, AccountType Saving_ account - TypeName
//, Interest Rate current_ account - TypeName , Interest Rate


Account account=new SavingAccount(1,"Ahmednagar",200000,"Saving",2);

account.Display();

Account account1 = new CurrentAccount(12, "Pune", 2000000, "Current", 0);
account1.Display();

public abstract class Account
{
    public abstract void Display();
}

public class SavingAccount:Account
{
    int id;
    string Location;
    long Balance;
    string AccountType;
    int Interestrate;

    public SavingAccount(int id, string location, long balance, string accountType, int interestrate)
    {
        this.id = id;
        this.Location = location;
        this.Balance = balance;
        this.AccountType = accountType;
        this.Interestrate = interestrate;
    }

    public override void Display()
    {
        Console.WriteLine($"{id} {Location} {Balance} {AccountType} {Interestrate}");
    }

}


public class CurrentAccount : Account
{
    int id;
    string Location;
    long Balance;
    string AccountType;
    int Interestrate;

    public CurrentAccount(int id, string location, long balance, string accountType, int interestrate)
    {
        this.id = id;
        this.Location = location;
        this.Balance = balance;
        this.AccountType = accountType;
        this.Interestrate = interestrate;
    }

    public override void Display()
    {
        Console.WriteLine($"{id} {Location} {Balance} {AccountType} {Interestrate}");
    }

}





