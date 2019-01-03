using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class LoanAccount : Account
    {
        public LoanAccount(ICustomer customer, double balance, double interestRate, DateTime openDate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InteresetRate = interestRate;
            this.Type = AccountType.LoanAccount;
            this.OpenDate = openDate;
            

        }

        public CustomerType CustomerType { get; set; }

        public override double CalculateInterestRate()
        {
            TimeSpan noOfDays = DateTime.Now.Subtract(OpenDate);

            int noOfMonths =Convert.ToInt32(noOfDays.TotalDays) / 7;

            if (Customer is Individual && noOfMonths < 4)
            {
                return 0;
            }
            else if (Customer is Company && noOfMonths < 3)
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

        //public override void Print()
        //{
        //    Customer.Print();
        //    Console.WriteLine($"\tAccount Type : {this.Type}, Balance: {this.Balance}, Monthly InterestRate: {this.InteresetRate}");
            
        //}
    }
}
