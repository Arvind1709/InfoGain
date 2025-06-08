using System;

namespace InfoGain
{
    public class SwitchCaseExample
    {
        public void SwitchWithBreak()
        {
            Console.WriteLine("Enter a number (1-7):");
            int day = int.Parse(Console.ReadLine());
            string dayName;
            switch (day)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid day";
                    break;
            }
            Console.WriteLine("The day is: " + dayName);

            Console.WriteLine("Enter a fruit name:");
            string fruit = Console.ReadLine();

            switch (fruit.ToLower())
            {
                case "apple":
                    Console.WriteLine("Apples are red or green.");
                    break;
                case "banana":
                    Console.WriteLine("Bananas are yellow.");
                    break;
                case "orange":
                    Console.WriteLine("Oranges are orange!");
                    break;
                default:
                    Console.WriteLine("Unknown fruit.");
                    break;
            }
        }

        public static double GetPrice(string item)
        {
            switch (item.ToLower())
            {
                case "apple":
                    return 1.2;
                case "banana":
                    return 0.5;
                case "orange":
                    return 0.8;
                default:
                    return 0.0; // Item not found
            }
        }

        public static string GetDayName(int day)
        {
            switch (day)
            {
                case 1: return "Monday";
                case 2: return "Tuesday";
                case 3: return "Wednesday";
                case 4: return "Thursday";
                case 5: return "Friday";
                case 6: return "Saturday";
                case 7: return "Sunday";
                default: return "Invalid day";
            }
        }

        public double BasicCalculatorUsingSwitch()
        {
            // Input first number
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Input operator
            Console.Write("Enter operator (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            // Input second number
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result;

            // Switch to perform calculation
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    return result;
                //break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    return result;
                //break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    return result;
                //break;

                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                        return result;
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        return 0.0;
                        // break;
                    }


                default:
                    Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
                    return 0.0;
                    // break;

            }
            //Console.WriteLine("Thank you for using the calculator!");
        }
    }

}
