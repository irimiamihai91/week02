using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Room
    {
        //private string Name;
        //private Rate DailyRate;
        //private int Adults;
        //private int Children;

        public Room (string name,Rate dailyRate,int adults, int children)
        {
            this.Name = name;
            this.DailyRate = dailyRate;
            this.Adults = adults;
            this.Children = children;
        }

        public string Name { get; set; }
        public Rate DailyRate { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }

        public decimal RatePerDays (int numberOfDays)
        {
            return numberOfDays * DailyRate.Amount;

        }

        public string Print()
        {
            return $"Room {Name} has a daily rate of {DailyRate.Amount}{DailyRate.Curency}. In the room are alowed {Adults} adults and {Children} childrens/childrens";
        }
    }
}
