using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public class MortgageAcc : Account
    {
         public MortgageAcc(Customer customer, decimal balance, decimal intrestRate)
            : base(customer, balance, intrestRate)
        {
        }


        public override decimal CalculateIntrest(uint months)
        {
            if (base.customer.TypeCustomer == TypeCustomer.Individual && months > 6)
            {
                return base.interestRate * (months - 6);
            }
            else if (base.customer.TypeCustomer == TypeCustomer.Company)
            {
                if (months <= 12)
                {
                    return (base.balance * (base.interestRate / 100) * months) / 2;
                }
                else
                {
                    return (base.balance * (base.interestRate / 100) * months) / 2 + (base.interestRate * (months - 12));
                }
            }

            return 0;

        }
    }
}
