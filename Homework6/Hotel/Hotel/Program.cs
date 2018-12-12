using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {

            Rate rate1 = new Rate (100, "USD") ;
            Rate rate2 = new Rate(70, "USD");
            //rate1.Print();

            var rooms = new List<Room>();
            Room room1 = new Room("Pathfinder", rate1, 2, 1);
            Room room2 = new Room("Greta", rate2, 2, 0);
            rooms.Add(room1);
            rooms.Add(room2);
            //Console.WriteLine($"\tPrice for 2 days is {room1.GetPrice(2)}");

            Hotel hotel1 = new Hotel("Traian", "Iasi", 3,rooms);
            hotel1.Print();
            Console.ReadKey();
        }
    }
}
