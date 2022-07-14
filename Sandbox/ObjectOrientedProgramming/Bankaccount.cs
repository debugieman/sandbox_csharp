using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Bankaccount
    {// below properties
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }
        public Bankaccount(string name, decimal initialBalance, string number)
        {
            this.Owner = name;
            this.Balance = initialBalance;

        }

        //below methods
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            //xx
        }
        public void MakeWithdrawl(decimal amount, DateTime date, string note)
        { }

    }




}

