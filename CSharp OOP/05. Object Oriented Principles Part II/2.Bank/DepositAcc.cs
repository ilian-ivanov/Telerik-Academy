using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public class DepositAcc : Account, IWithdrawable
    {
        // CONSTRUCTOR ------------------------------------------------------------------
        public DepositAcc(Customer customer, decimal balance, decimal intrestRate)
            : base(customer, balance, intrestRate)
        {
        }

        // METHODS -------------------------------------------------------------------
       

        public void WithdrawMonew(decimal withdraw)
        {
            if (withdraw > 0 && (base.balance - withdraw >= 0))
            {
                base.balance -= withdraw;
            }
            else
            {
                throw new ArgumentException("The sum you want to withdraw is bigger than your balance or is negative number!");
            }
        }

        public override decimal CalculateIntrest(uint months)
        {
            if (base.balance >= 1000)
            {
                return base.balance * (base.interestRate / 100) * months;
            }

            return 0;
        }

    }
}
