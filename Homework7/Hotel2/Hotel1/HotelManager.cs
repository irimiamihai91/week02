using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel1
{
    public class HotelManager
    {
        public List<Hotel> Hotels { get; set; }

        public Hotel CreateHotel()
        {
            var rooms = new List<Room>();

            Rate rate = CreateRate();

            Room room1 = CreateRoom(rate);

            var room2 = CreateRoom(rate);

            Console.WriteLine("Hotel name : ");
            var hotelName = Convert.ToString(Console.ReadLine());

            rooms.Add(room1);
            rooms.Add(room2);

            var hotel1 = new Hotel(hotelName, "Iasi", 3, rooms);

            Hotels.Add(hotel1);

            return hotel1;

        }

        public Room CreateRoom(Rate rate)
        {
            Console.Write("Room name :");
            var roomName = Convert.ToString(Console.ReadLine());

           return new Room(roomName, rate, 2, 0);
      
        }

        private static Rate CreateRate()
        {
            Console.Write("Rata:");
            var rataValue = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Curency:");
            var curencyValue = Convert.ToString(Console.ReadLine());

            var rate = new Rate(rataValue, curencyValue);
            return rate;
        }

       

        public void Print()
        {
            foreach (var hotel in Hotels)
            {
                hotel.Print();
            }



         }
        public void RemoveHotel(string name)
        {
            foreach (var hotel in Hotels)
            {
                if (hotel.Name == name)
                {
                    Hotels.Remove(hotel);
                }
            }
        }
    }
}

