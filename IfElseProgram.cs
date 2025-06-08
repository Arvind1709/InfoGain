using System;

namespace InfoGain
{
    public class IfElseProgram
    {
        public void AgeGroup()
        {
            Console.WriteLine("Enter your age:");
            string input = Console.ReadLine();

            // Try to convert input to integer
            bool isValid = int.TryParse(input, out int age);
            //bool isvalid = int.TryParse()

            if (!isValid)
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                return;  // Exit the program early if input is invalid
            }

            // Check age groups using if, else if, else
            if (age < 0)
            {
                Console.WriteLine("Age cannot be negative!");
            }
            else if (age <= 12)
            {
                Console.WriteLine("You are a child.");
            }
            else if (age <= 19)
            {
                Console.WriteLine("You are a teenager.");
            }
            else if (age <= 59)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior citizen.");
            }
        }
    }
}
