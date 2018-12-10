using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)

        {  // var ListOfRates = new List<Rate>();
            Rate rate1 = new Rate(60, "$");
            Rate rate2 = new Rate(100, "$");
            Rate rate3 = new Rate(70, "$");
            
            // ListOfrates.Add(rate1);
            // ListOfrates.Add(rate2);
            // ListOfrates.Add(rate3);

            //foreach (var elem in ListOfrates)
            //{
            //    Console.WriteLine(elem.Print());
            //}

            //var listOfRooms = new List<Room>();
            Room room1 = new Room("Double", rate1, 2, 1);
            Room room2 = new Room("King", rate2, 2, 0);
            Room room3 = new Room("Holywood", rate3, 1, 1);
            //ListOfRooms.Add(new Room("Double", rate1, 2, 1))-another example of adding 
            //listOfRooms.Add(room1);
            //listOfRooms.Add(room2);
            //listOfRooms.Add(room3);

            //foreach(var elem in listOfRooms)
            //{
            //    Console.WriteLine(elem.Print());
            //}



            Console.ReadKey();
        }
    }
}
