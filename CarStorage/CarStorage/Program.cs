using System;

namespace CarStorage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car[] cars = new Car[3];
            for (var i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Input Name");
                cars[i].Name = Console.ReadLine();

                Console.WriteLine("Input Price");
                cars[i].Price = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Input Color");
                cars[i].Color = Console.ReadLine();

            }


            Console.WriteLine($"Sourse prise {cars[0].Price} ; Price after sale: {cars[0].GetSale()}");
        }
    }
}