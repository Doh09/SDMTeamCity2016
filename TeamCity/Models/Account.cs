using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamCity.Models
{
    public class Account
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public void TransferFunds(Account destination, decimal amount)
        {
            Withdraw(amount);
            destination.Deposit(amount);
        }

        public decimal Balance
        {
            get { return balance; }
        }
    }
}