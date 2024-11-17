using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ10
{
    internal class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string TypeActivity { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public int ShopArea{ get; set; }

        public Shop() { }
        public Shop(string name, string address, string typeActivity, int phone, string email, int shoparea)
        {
            Name = name;
            Address = address;
            TypeActivity = typeActivity;
            Phone = phone;
            Email = email;
            ShopArea = shoparea;
        }
        public void Input()
        {
            Console.WriteLine("Name ->");
            Name = Console.ReadLine();
            Console.WriteLine("Address ->");
            Address = Console.ReadLine();
            Console.WriteLine("TypeActivity->");
            TypeActivity = Console.ReadLine();
            Console.WriteLine("Phone ->");
            Phone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Email ->");
            Email = Console.ReadLine();
            Console.WriteLine("ShopArea ->");
            ShopArea = Convert.ToInt32(Console.ReadLine());
        }

        public void Output()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Name ->");
            Console.WriteLine(Name);
            Console.Write("Address ->");
            Console.WriteLine(Address);
            Console.Write("TypeActivity->");
            Console.WriteLine(TypeActivity);
            Console.Write("Phone ->");
            Console.WriteLine(Phone);
            Console.Write("Email ->");
            Console.WriteLine(Email);
            Console.Write("ShopArea ->");
            Console.WriteLine(ShopArea);
        }
    }
}
