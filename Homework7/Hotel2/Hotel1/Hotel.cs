using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel1
{
    public class Hotel

    {
        public Hotel(string name, string city,int stars, List<Room > rooms)
        {
            this.Name = name;
            this.City = city;
            this.Stars = stars;
            this.Rooms = rooms;
            
        }
        public Rate Rate { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public int Stars { get; set; }

        public List<Room> Rooms { get; set; }

        public void Print()
        {
            Console.WriteLine($"\t\t Hotel name: {Name}");
            Console.WriteLine($"City: {City} Stars: {Stars}");
            foreach(var room in Rooms)
            {
                room.Print();
            }
        }

        public decimal GetPriceForAllRooms()
        {
            decimal suma = 0;

            foreach(var room in Rooms)
            {
                return suma = suma + room.Rate.Amount;
            }

            return suma;
        }

        public Room AddRoom ()
        {
            decimal amountValue = 100;
            var currencyValue = "USD";
            var rate1 = new Rate(amountValue, currencyValue);

            return new Room("Rome",rate1,2,0);
        }

        public void RemoveRoom(string name)
        {
            foreach (var room in Rooms)
            {
                if (room.Name == name)
                {
                    Rooms.Remove(room);
                }
            }
        }

        public decimal GetPriceForNumberOfRooms(int numberOfRooms)
        {
            decimal sum = 0;

            if (Rooms.Count >= numberOfRooms)
            {
                for (int i = 0; i < numberOfRooms; i++)
                {
                    sum = sum + Rooms[i].GetPrice();
                }
            }
            else
            {
                Console.WriteLine("Not enough rooms!");
            }

            return sum;
        }

        public Room FindRoomWithLowerPriceThan(decimal price)
        {
            foreach (var room in Rooms)
            {
                if (room.GetPrice() < price)
                {
                    return room;
                }
            }

            return null;
        }
    }
}
