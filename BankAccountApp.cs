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
        public decimal Balance { get; set; }
        public BankAccountApp(string Owner = "Unknow", decimal Balance = 0)
        {
            this.Owner = Owner;
            AccountNumber = Guid.NewGuid();
        }
    }
}
