using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Hotel
    {
        public string Name { get; set; }

        private Room[] rooms;

        public Room[] Getroom()
        {
            return rooms;
        }

        public Hotel(string name)
        {
            Name = name;
            rooms = new Room[0];
        }

        public void AddRoom(Room room)
        {
            Array.Resize(ref rooms, rooms.Length + 1);
            rooms[rooms.Length - 1] = room;
        }

        public void Makereservation(int roomId)
        {
            foreach (Room item in rooms)
            {
                if (item.id == roomId)
                {
                    if (item.Isvailable(true))
                    {
                        Console.WriteLine(roomId);
                    }
                }
                else
                {
                    Console.WriteLine("Room is Full");
                }

            }
        }
    }
}
