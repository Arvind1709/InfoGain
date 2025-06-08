using System;

namespace InfoGain
{
    internal class Person
    {
        // Static field: shared across all objects
        public static string Species = "Human";

        // Instance field: unique per object
        public string Name;

        const int aPrice = 100;
        const int bPrice = 200;
        const int cPrice = 300;


        public int GetPrice(string item)
        {
            var test = GetPriceStatic(item);
            return test;
        }

        public static int GetPriceStatic(string item)
        {
            // Using switch expression to return price based on item
            //return item switch
            //{
            //    "a" => aPrice,
            //    "b" => bPrice,
            //    "c" => cPrice,
            //    _ => throw new ArgumentException("Invalid item")
            //};
            if (item == "a")
            {
                return aPrice;
            }
            else if (item == "b")
            {
                return bPrice;
            }
            else if (item == "c")
            {
                return cPrice;
            }
            else
            {
                throw new ArgumentException("Invalid item");
            }
        }

        // Instance method: requires object
        public void Greet()
        {
            Console.WriteLine("Hello, my name is " + Name);
        }

        // Static method: belongs to class
        public static void ShowSpecies()
        {

            Console.WriteLine("Species: " + Species);
            Species = "Human One";
            Console.WriteLine("Species afterChange: " + Species);
        }

        public static void ShowSpecies1()
        {

            Console.WriteLine("Species  ShowSpecies1(): " + Species);
            Species = "Human Two";
            Console.WriteLine("Species afterChange ShowSpecies1(): " + Species);
        }
    }
}
