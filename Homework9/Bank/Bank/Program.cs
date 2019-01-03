using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IAccount> accounts = new List<IAccount>();

            ICustomer person = new Individual("Mihai Irimia", 1911122284548);
            ICustomer company = new Company("Polaris-Palmax", "1234RO436534");

            DateTime noOfDays = new DateTime(2018, 12, 3, 0, 0, 0);

            IAccount depositAccount = new DepositAccount(person, 10000, 10,noOfDays); // noOfMonths = 4
            IAccount loanAccount = new LoanAccount(company, 100, 5, noOfDays);
            IAccount mortgageAccount = new MortgageAccount(company, 1000, 10, noOfDays);

            accounts.Add(depositAccount);
            accounts.Add(loanAccount);
            accounts.Add(mortgageAccount);

            foreach(var elem in accounts)
            {
                elem.Print();
            }
            
            
            Console.ReadKey();
        }
    }
}
