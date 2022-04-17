using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Room
    {
        private double _price;

        private int _personcapacity;

        public int id { get; }

        public static int Id;

        public string Name { get; set; }

        public string Showinfo()
        {
            return $"Price:{Price}\nPersoncapacity:{Personcapacity}\nName:{Name}\nId:{id}";
        }

        public Room(double price, int personcapacity, bool isvailable, string name)
        {
            Id++;
            id = Id;
            Price = price;
            Personcapacity = personcapacity;
            Name = name;
        }

        public double Price
        {
            get => _price;
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        public int Personcapacity
        {
            get => _personcapacity;
            set
            {
                if (value > 0 && value <= 5)
                {
                    _personcapacity = value;
                }
            }
        }
        public bool Isvailable(bool reserve)
        {
            reserve = false;
            if (!reserve)
            {
                Console.WriteLine("Full");
            }
            else
            {
                Console.WriteLine("there is empty space");
            }
            return false;
        }

    }
}
