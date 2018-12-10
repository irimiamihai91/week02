using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Hotel
    {
       // private string Name;
       // private string City;
       // private int Stars;
       // private List<Room> ListOfRooms;
        public Hotel(string name,string city, int stars,List<Room> listOfRooms, Rate dailyRate)
        {
            this.Name = name;
            this.City = city;
            this.Stars = stars;
            this.ListOfRooms = listOfRooms;
            this.DailyRate = dailyRate;

        }
        public string Name { get; set; }

        public Rate DailyRate { get; set; }

        public string City { get; set; }

        public int Stars { get; set; }

        public List<Room> ListOfRooms { get; set; }

        public decimal GetPriceForNumberOfRooms(int numberOfRooms)
        {
            return numberOfRooms * DailyRate.Amount;
        }

        public string Print()
        {
            return $"Hotel {Name} from {City} has {Stars} stars";
        }
    }
}
