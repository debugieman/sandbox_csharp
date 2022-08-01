using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank;

public class BankAccount
{//fields
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance  { get; }
    //constructor
    public BankAccount(string name, decimal initialBalance)
    {
        this.Owner = name;
        this.Balance = initialBalance;
    
    }
    //props
    public void MakeDeposit(decimal amount, DateTime date, string note)
    { 
    
    }
    public void MakeWithdrawl(decimal amount, DateTime date, string note)
    { 
    
    }
}
