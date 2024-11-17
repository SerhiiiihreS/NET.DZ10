using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ10
{
    internal class Magazine
    {
        public string Name { get; set; }
        public int YearFoundation { get; set; }
        public string Description { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public int Employees { get; set; }

        public Magazine() { }
        public Magazine(string name, int yearFoundation, string description, int phone, string email, int employees)
        {
            Name = name;
            YearFoundation = yearFoundation;
            Description = description;
            Phone = phone;
            Email = email;
            Employees = employees;
        }
        public void Input()
        {
            Console.WriteLine("Name ->");
            Name = Console.ReadLine();
            Console.WriteLine("YearFoundation ->");
            YearFoundation = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Description->");
            Description = Console.ReadLine();
            Console.WriteLine("Phone ->");
            Phone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Email ->");
            Email = Console.ReadLine();
            Console.WriteLine("Employees ->");
            Employees = Convert.ToInt32(Console.ReadLine());
        }

        public void Output()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Name ->");
            Console.WriteLine(Name);
            Console.Write("YearFoundation ->");
            Console.WriteLine(YearFoundation);
            Console.Write("Description->");
            Console.WriteLine(Description);
            Console.Write("Phone ->");
            Console.WriteLine(Phone);
            Console.Write("Email ->");
            Console.WriteLine(Email);
            Console.Write("Employees ->");
            Console.WriteLine(Employees);

        }
    }
}
