using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter price");
            int price = Convert.ToInt32(Console.ReadLine());
            int price1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("enter personcapacity");
            int personcapacity = Convert.ToInt32(Console.ReadLine());
            int personcapacity1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter isvailable");
            bool isvailable = Convert.ToBoolean(Console.ReadLine());
            bool isvailable1 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            string name1 = Console.ReadLine();
            Room room = new Room(price, personcapacity, isvailable, name);
            Room room1 = new Room(price1, personcapacity1, isvailable1, name1);
            Hotel hotel = new Hotel("b");

            hotel.AddRoom(room);
            hotel.AddRoom(room1);
            foreach (Room item in hotel.Getroom())
            {
                Console.WriteLine(item.Showinfo());
            }
                    
        }
    }
}
