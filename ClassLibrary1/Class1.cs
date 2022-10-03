using System;

namespace _1_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address solution\n");
            Address someAddress = new Address();

            someAddress.Index = 02138;
            someAddress.Country = "Ukraine";
            someAddress.City = "Kyiv";
            someAddress.Street = "Unnamed";
            someAddress.House = 8;
            someAddress.Apartment = 310;

            Console.WriteLine(someAddress.GetAddress());

            Console.ReadKey();
        }
    }
}
