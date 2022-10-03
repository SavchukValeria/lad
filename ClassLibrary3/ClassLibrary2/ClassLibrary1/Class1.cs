using System;

namespace _2_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converter solution\n");

            Converter ezConverter = new Converter(36, 35, 0.67);

            ezConverter.Choice();

            Console.ReadKey();
        }
    }
}