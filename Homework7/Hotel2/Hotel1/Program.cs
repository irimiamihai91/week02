using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel1
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelManager manager = new HotelManager();

            var hotel1 = manager.CreateHotel();

            



            //manager.Print();

            Console.Write("Number of Rooms = ");
            var noRooms = Convert.ToInt32(Console.ReadLine());

            

            decimal price = hotel1.GetPriceForNumberOfRooms(noRooms);

            var room = hotel1.FindRoomWithLowerPriceThan(10);

            Console.WriteLine($"Price for {noRooms} is {price}");

            manager.RemoveHotel("Hotel 1");

            Console.ReadLine();



        }
    }
}
