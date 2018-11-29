using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ndays, year, week, days, month,daysinmonth = 30,DAYSINWEEK = 7;
            Console.WriteLine("Enter the number of days");
            ndays = int.Parse(Console.ReadLine());
            year = ndays / 365;
            month = ((ndays%365)/daysinmonth)/7;
            week = (ndays% 365)/ DAYSINWEEK;
            Console.WriteLine("{0} is equivalent to {1}years, {2}month and {3}weeks", ndays, year, month, week);
            Console.ReadLine();
        }
    }
}