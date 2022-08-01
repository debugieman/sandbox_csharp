namespace TestBank
{
    public class Tests
    {
        [SetUp]
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }


        private static int accountNumberSeed = 480000;
        public void BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        [Test]
        public void Test1()
        {
            
        }
    }
}