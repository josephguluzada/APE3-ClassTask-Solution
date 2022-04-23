using System;
using HotelTask.CustomExtensions;
namespace HotelTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("Room1", 25, 4);
            Room room2 = new Room("Room2", 35, 3);
            
            Hotel hotel = new Hotel("APE103");


            hotel.AddRoom(room1);
            hotel.AddRoom(room2);

            //hotel.MakeReservation(2);
            //hotel.MakeReservation(2);
            //hotel.MakeReservation(3);


            foreach (var item in hotel.GetRooms())
            {
                Console.WriteLine(item.ToString());
            }

            string word = "salam";
            
            Console.WriteLine(word.Capitalize());
        }
    }
}
