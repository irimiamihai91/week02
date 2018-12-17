using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Workers
{
    class Workers:Human
    {
        public Workers(string firstName, string lastName,double weekSalary, double workHoursPerDay)

        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;

        }
        
        public double WeekSalary { get;}

        public double WorkHoursPerDay { get;}

        public double MoneyPerHour()
        {
            double moneyPerHour = 0;

            return moneyPerHour = this.WeekSalary / 7 / this.WorkHoursPerDay;
        }

        public void Print()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName}:", Environment.NewLine);
            Console.WriteLine($"WeeK Salary:{this.WeekSalary} RON, Work hours per day {this.WorkHoursPerDay} hours ,Money per hour : {this.MoneyPerHour()} RON");
        }
    }
}
