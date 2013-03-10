using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public abstract class Account
    {
        protected Customer customer;
        protected decimal balance;
        protected decimal interestRate;

        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.customer = customer;
            if (balance > 0 && interestRate > 0)
            {
                this.balance = balance;
                this.interestRate = interestRate;
            }
            else
            {
                throw new ArgumentException("Balance and iterested rate must be bigger than 0!");
            }
        }


        public decimal GetBalance()
        {
            return this.balance;
        }

        public decimal GetIntrestRate()
        {
            return this.interestRate;
        }

        public Customer GetCustomerInfo()
        {
            return this.customer;
        }

        public void DepositMoney(decimal deposit)
        {
            if (deposit > 0)
            {
                this.balance += deposit;
            }
            else
            {
                throw new ArgumentException("The deposit must be positive number!");
            }
        }

        public abstract decimal CalculateIntrest(uint months);
    }
}
