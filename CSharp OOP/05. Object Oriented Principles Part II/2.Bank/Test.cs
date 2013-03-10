using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    class Test
    {
        static void Main()
        {

            DepositAcc deposit = new DepositAcc(new Customer("Ivan"), 999, 2.3m);
            LoanAcc loan = new LoanAcc(new Customer("Pesho"), 1200, 2.3m);
            MortgageAcc mortgage = new MortgageAcc(new Customer("Telerik", TypeCustomer.Company), 1200000, 2.3m);

            Console.WriteLine("Deposit intrest for 12 months = " + deposit.CalculateIntrest(12));
            Console.WriteLine("Loan intrest for 12 months = " + loan.CalculateIntrest(12));
            Console.WriteLine("Mortgage intrest for 12 months = " + mortgage.CalculateIntrest(12));

            Console.WriteLine(deposit.GetBalance());
            deposit.DepositMoney(101);
            deposit.WithdrawMonew(10);
            Console.WriteLine(deposit.GetBalance());

            Console.WriteLine(deposit.GetCustomerInfo());
            Console.WriteLine(loan.CalculateIntrest(4));

        }
    }
}
