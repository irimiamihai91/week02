using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class DepositAccount : Account
    {
        public DepositAccount(ICustomer customer, double balance, double interestRate, DateTime openDate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InteresetRate = interestRate;
            this.Type = AccountType.DepositAccount;
            this.OpenDate = openDate;

        }

        public override double CalculateInterestRate()
        {

            int noOfMonths = FindDifferenceOfDate();

            return (this.Balance > 0 && this.Balance < 1000) ? 0 : InteresetRate * noOfMonths;

        }

        //DepositMoney is the same with the one implemented in the base class so we will use that one

        public override void WithdrawMoney(double value)
        {
            if (this.Balance < value)
            {

                Console.WriteLine("You don't have enought founds for this tranzaction");
            }
            else
            {
                this.Balance = this.Balance - value;
            }
        }


        //public override void Print()
        //{
        //    Customer.Print();
        //    Console.WriteLine($"\tAccount Type : {this.Type}, Balance: {this.Balance}, Monthly InterestRate: {this.InteresetRate}");
        //    //Console.WriteLine($"In this case Intereset Rate will be {CalculateInterestRate()}");
        //}
}
}
