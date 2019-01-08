using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class MortgageAccount : Account
    {
        public MortgageAccount(ICustomer customer, double balance, double interestRate, DateTime openDate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InteresetRate = interestRate;
            this.Type = AccountType.MortgageAccount;
            this.OpenDate = openDate;

        }

        public override double CalculateInterestRate()
        {
            int noOfMonths = FindDifferenceOfDate();

            if (Customer is Company && noOfMonths <= 12)
            {
                return (InteresetRate *noOfMonths) / 2;
            }
            else if (Customer is Individual && noOfMonths < 7)
            {
                return 0;
            }
            else
                return InteresetRate * noOfMonths;
        }

       

        //DepositMoney is the same with the one implemented in the base class so we will use that one

        public override void WithdrawMoney(double value)
        {
            Console.WriteLine("You cannot withdraw money from this type of account");
        }

        //public override void Print()-virtual method
        //{
        //    Customer.Print();
        //    Console.WriteLine($"\tAccount Type : {this.Type}, Balance: {this.Balance}, Monthly InterestRate: {this.InteresetRate}");
        //}
    }
}
