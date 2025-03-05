namespace BroCode;

public class BankAccount
{   // properties of the class
    private static int _sAccountNumberSeed = 1234567890;
    public string Owner { get; set; }
    public string Number { get; }

    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in _allTransactions)
            {
                balance += item.Amount;
            }
            return balance;
            
        } set{} 
    }

    public BankAccount(string owner, decimal initialBalance)
    {
        Owner = owner;
        Balance = initialBalance;
        Number = _sAccountNumberSeed.ToString();
        _sAccountNumberSeed++;
    }
    private List<Transaction> _allTransactions = new List<Transaction>();
    
    // methods of the class
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
    }
}