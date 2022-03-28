using System;
using System.Collections.Generic;
using System.Text;

namespace _1_bankszamla_kivetelkezeles
{
    class CheckingAccount
    {
        private double balance;
        private int number;

        public CheckingAccount(int number)
        {
            this.number = number;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                double needs = amount - balance;
                throw new InsufficientFundsException(needs);
            }
        }

        public double GetBalance()
        {
            return balance;
        }

        public int GetNumber()
        {
            return number;
        }

    }
}
