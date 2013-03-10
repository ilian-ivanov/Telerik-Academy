using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public class LoanAcc : Account
    {
        public LoanAcc(Customer customer, decimal balance, decimal intrestRate)
            : base(customer, balance, intrestRate)
        {
        }

        public override decimal CalculateIntrest(uint months)
        {
            if (base.customer.TypeCustomer == TypeCustomer.Individual && months > 3)
            {
                return base.balance * (base.interestRate / 100) * (months - 3);
            }
            else if (base.customer.TypeCustomer == TypeCustomer.Company && months > 2)
            {
                return base.balance * (base.interestRate / 100) * (months - 2);
            }

            return 0;
        }
    }
}
