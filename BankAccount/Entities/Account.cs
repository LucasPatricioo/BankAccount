using BankAccount.Entities.Exceptions;

namespace BankAccount.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }
        public double WithDrawLimit { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }
        public void WithDraw(double amount) {
            if (amount > WithDrawLimit) {
                throw new DomainException("The amount exceeds withdraw limit.");
            }
            if (amount > Balance) {
                throw new DomainException("Not enough balance.");
            }
            Balance -= amount;
        }
    }
}
