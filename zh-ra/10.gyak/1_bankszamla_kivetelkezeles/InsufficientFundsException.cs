using System;
using System.Collections.Generic;
using System.Text;

namespace _1_bankszamla_kivetelkezeles
{
    class InsufficientFundsException : Exception
    {
        private double amount;

        public InsufficientFundsException(double amount)
        {
            this.amount = amount;
        }

        public double GetAmount()
        {
            return amount;
        }

    }
}
