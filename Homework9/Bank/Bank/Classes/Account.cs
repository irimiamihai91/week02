using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
   public abstract class Account : IAccount
    {
        public ICustomer Customer { get; set; }

        public double Balance { get; set; }

        public AccountType Type { get; protected set; }

        public DateTime OpenDate { get; set; }

        public double InteresetRate { get; set; }

        public abstract double CalculateInterestRate();
      
        public virtual double DepositMoney (double value)
        {
            return Balance = Balance + value;
        }

        public abstract void WithdrawMoney(double value);

        public virtual void Print()
        {
            Customer.Print();
            Console.WriteLine($"\tAccount Type : {this.Type}, Balance: {this.Balance}, Monthly InterestRate: {this.InteresetRate}");
            Console.WriteLine($"\tAfter verification Interest rate will be : {CalculateInterestRate() }");
        }


    }

    public enum AccountType
    {
        DepositAccount,

        LoanAccount,
        MortgageAccount
    };
}
