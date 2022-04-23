using System;
using System.Collections.Generic;
using System.Text;

namespace HotelTask
{
    class Room
    {
        private static int _id;
        public  int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Room(string name,double price,int capacity)
        {
           
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            PersonCapacity = capacity;
        }

        //public string ShowInfo()
        //{
        //    return $"Id: {Id} - Name: {Name} - Price: {Price} - IsAvailable: {IsAvailable} - PersonCapacity: {PersonCapacity}";
        //}

        public override string ToString()
        {
            return $"Id: {Id} - Name: {Name} - Price: {Price} - IsAvailable: {IsAvailable} - PersonCapacity: {PersonCapacity}";
        }

    }
}
