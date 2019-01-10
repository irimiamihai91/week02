using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Worker:Human
    {
        public double WeeksSalary { get; }

        public int WorkHoursPerDay { get; }

        public Worker (string firstName, string lastName, double weekSalary, int workHoursPerDay): base(firstName,lastName)
        {
            this.WeeksSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double GetMoneyPerHour()
        {
            var moneyPerDay = (double)this.WeeksSalary / 7;
            return moneyPerDay / this.WorkHoursPerDay;
        }

        public void Print()
        {
            Console.WriteLine($"First Name : {this.FirstName}, Last Name : {this.LastName}, Week Salary: {this.WeeksSalary}, Work Hours Per Day : {this.WorkHoursPerDay}");
            Console.WriteLine($"Money Per Hour {this.GetMoneyPerHour()}");
        }

        public static bool operator <(Worker w1, Worker w2)
        {
            if (w1.WeeksSalary < w2.WeeksSalary)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static bool operator >(Worker w1, Worker w2)
        {
            if (w1.WeeksSalary > w2.WeeksSalary)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
