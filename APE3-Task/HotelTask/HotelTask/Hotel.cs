using System;
using System.Collections.Generic;
using System.Text;

namespace HotelTask
{
    class Hotel
    {
        public string Name { get; set; }

        private Room[] _rooms = new Room[0];


        public Hotel(string name)
        {
            Name = name;
        }


        public void AddRoom(Room room)
        {
            Array.Resize(ref _rooms, _rooms.Length + 1);
            _rooms[_rooms.Length - 1] = room;
        }


        public void MakeReservation(int id)
        {
            foreach (var room in _rooms)
            {
                if (room.Id==id)
                {
                    if (room.IsAvailable==true)
                    {
                        room.IsAvailable = false;
                        Console.WriteLine("Room is Reserved!");
                        return;
                        
                    }
                    
                    else 
                    {
                        Console.WriteLine("Room is Full");
                        return;
                    }
                    
                                        
                }
              
            }
            Console.WriteLine($"{id} not Found");

        }

        public Room[] GetRooms()
        {
            return _rooms;
        }
    }
}
