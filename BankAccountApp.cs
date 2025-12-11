using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankAccount
{
    internal class BankAccountApp
    {
        public Guid AccountNumber { get; private set; }
        public string Owner { get; private set; }
        public decimal Balance { get; private set; }
        public BankAccountApp(string Owner = "Unknow", decimal Balance = 0)
        {
            this.Owner = Owner;
            AccountNumber = Guid.NewGuid();
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be greater than zero.");
            }
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdraw amount must be greater than zero.");
            }
            if (amount > Balance)
            {
                throw new ArgumentException("Insufficient funds for this withdrawal.");
            }
            Balance -= amount;
        }
    }
}
