using System;

namespace InfoGain
{
    public class DataTypePractice
    {
        public void DataType()
        {
            // Integer (int)
            int age = 25;
            Console.WriteLine("Integer (int) - Age: " + age);

            // Floating Point (float)
            float temperature = 36.6f;  // Note: 'f' is required for float literals
            Console.WriteLine("Float (float) - Temperature: " + temperature);

            // Double Precision Floating Point (double)
            double distance = 12345.6789;
            Console.WriteLine("Double (double) - Distance: " + distance);

            // Decimal (for financial/calculation precision)
            decimal salary = 123456.78m;  // Note: 'm' is required for decimal literals
            Console.WriteLine("Decimal (decimal) - Salary: " + salary);

            // Boolean (bool)
            bool isWorking = true;
            Console.WriteLine("Boolean (bool) - Is Working: " + isWorking);

            // Character (char)
            char grade = 'A';
            Console.WriteLine("Character (char) - Grade: " + grade);

            // String (string)
            string name = "Arvind";
            Console.WriteLine("String (string) - Name: " + name);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
