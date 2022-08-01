using MyBank;

var account = new BankAccount("Bartek", 1000000);

Console.WriteLine($"I hope this fuckin prints." + " " +
    $"Account {account.Number} was created for user {account.Owner} with first deposit of {account.Balance} PLN");