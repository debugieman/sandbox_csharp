using MyBank;

var account = new BankAccount("Bartek", 1000000);
var account_2 = new BankAccount("Wiktor", 10);
var account_3 = new BankAccount("Patryk", 100000);
Console.WriteLine($"I hope this fuckin prints." + " " +
    $"Account {account.Number} was created for " +
    $"user {account.Owner} with first" +
    $" deposit of {account.Balance} PLN");


Console.WriteLine($"Account {account_2.Number} was created for " +
    $"user {account_2.Owner} with first" +
    $" deposit of {account_2.Balance} PLN");

Console.WriteLine($"Account {account_3.Number} was created for " +
    $"user {account_3.Owner} with first" +
    $" deposit of {account_3.Balance} PLN");


