using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        //default constructor
        public Customer()
        {

        }


        //multiple constructors
        public Customer(string name, string address, string city)
        {
            Name = name;
            Address = address;
            City = city;

            Console.WriteLine(Name + " " + Address + " " + City);
            
        }

        public Customer(string name)
        {
            Name = name;
            Console.WriteLine(Name);
        }

        //method

        public void SetDetails(string name, string address, string city)
        {
            Name = name;
            Address = address;
            City = city;
            Console.WriteLine($"My name is {Name}, I live in {Address} and city is {City}");



        }

        //static method

        public static void CustomerInfo()
        {
            Console.WriteLine("Some extra info");
        }

    }
}
