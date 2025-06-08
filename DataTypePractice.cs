using System;

namespace InfoGain
{
    public class DataTypePractice
    {
        public void DataType()
        {
            // Integer (int): Stores whole numbers (positive or negative) without decimals
        // Size: 4 bytes, Range: -2,147,483,648 to 2,147,483,647
        int age = 25;
        Console.WriteLine("Integer (int) - Age: " + age);

        // Floating Point (float): Stores decimal numbers with single precision
        // Size: 4 bytes, Precision: ~6–7 digits, suffix 'f' required
        float temperature = 36.6f;  
        Console.WriteLine("Float (float) - Temperature: " + temperature);

        // Double Precision Floating Point (double): Stores decimal numbers with double precision
        // Size: 8 bytes, Precision: ~15–16 digits
        double distance = 12345.6789;
        Console.WriteLine("Double (double) - Distance: " + distance);

        // Decimal (decimal): Used for high-precision decimal values, ideal for financial calculations
        // Size: 16 bytes, Precision: ~28–29 digits, suffix 'm' required
        decimal salary = 123456.78m;  
        Console.WriteLine("Decimal (decimal) - Salary: " + salary);

        // Boolean (bool): Stores true or false values
        // Size: 1 bit
        bool isWorking = true;
        Console.WriteLine("Boolean (bool) - Is Working: " + isWorking);

        // Character (char): Stores a single Unicode character
        // Size: 2 bytes
        char grade = 'A';
        Console.WriteLine("Character (char) - Grade: " + grade);

        // String (string): Stores a sequence of characters (text)
        // Size: variable (depends on the length of the string)
        string name = "Arvind";
        Console.WriteLine("String (string) - Name: " + name);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
        }
    }
}
