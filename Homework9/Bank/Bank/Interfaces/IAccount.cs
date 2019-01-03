using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    interface IAccount
    {

         ICustomer Customer { get; }

         double Balance { get; set; }

         DateTime OpenDate { get; }

         double InteresetRate { get; set; }

         double CalculateInterestRate();

         double DepositMoney(double value);

        void WithdrawMoney(double value);

        void Print();
    }
}
