using System;

namespace InfoGain
{
    internal class OperatorExamples
    {
        public void Operators()
        {
            Console.WriteLine("========== Arithmetic Operators ==========");
            // Arithmetic Operators: Used to perform mathematical calculations
            int a = 10, b = 3;
            Console.WriteLine("a + b = " + (a + b));   // Addition
            Console.WriteLine("a - b = " + (a - b));   // Subtraction
            Console.WriteLine("a * b = " + (a * b));   // Multiplication
            Console.WriteLine("a / b = " + (a / b));   // Integer Division
            Console.WriteLine("a % b = " + (a % b));   // Modulus

            Console.WriteLine("\n========== Comparison Operators ==========");
            // Comparison Operators: Used to compare values
            Console.WriteLine("a == b: " + (a == b));  // Equal
            Console.WriteLine("a != b: " + (a != b));  // Not Equal
            Console.WriteLine("a > b: " + (a > b));    // Greater than
            Console.WriteLine("a < b: " + (a < b));    // Less than
            Console.WriteLine("a >= b: " + (a >= b));  // Greater than or Equal
            Console.WriteLine("a <= b: " + (a <= b));  // Less than or Equal

            Console.WriteLine("\n========== Logical Operators ==========");
            // Logical Operators: Combine boolean expressions
            bool x = true, y = false;
            Console.WriteLine("x && y: " + (x && y));  // AND
            Console.WriteLine("x || y: " + (x || y));  // OR
            Console.WriteLine("!x: " + (!x));          // NOT

            Console.WriteLine("\n========== Bitwise Operators ==========");
            // Bitwise Operators: Work on binary representations of numbers
            int p = 5, q = 3;
            Console.WriteLine("p & q: " + (p & q));     // AND
            Console.WriteLine("p | q: " + (p | q));     // OR
            Console.WriteLine("p ^ q: " + (p ^ q));     // XOR
            Console.WriteLine("~p: " + (~p));           // NOT
            Console.WriteLine("p << 1: " + (p << 1));   // Left Shift (×2)
            Console.WriteLine("p >> 1: " + (p >> 1));   // Right Shift (÷2)

            Console.WriteLine("\n========== Assignment Operators ==========");
            // Assignment Operators: Assign values to variables
            int z = 10;
            Console.WriteLine("z = " + z);
            z += 5;  // z = z + 5
            Console.WriteLine("z += 5 => " + z);
            z -= 2;  // z = z - 2
            Console.WriteLine("z -= 2 => " + z);
            z *= 3;  // z = z * 3
            Console.WriteLine("z *= 3 => " + z);
            z /= 2;  // z = z / 2
            Console.WriteLine("z /= 2 => " + z);
            z %= 4;  // z = z % 4
            Console.WriteLine("z %= 4 => " + z);

            Console.WriteLine("\n========== Unary Operators ==========");
            // Unary Operators: Used with one operand
            int m = 5;
            Console.WriteLine("Original m = " + m);
            Console.WriteLine("++m = " + (++m));  // Pre-increment
            Console.WriteLine("m++ = " + (m++));  // Post-increment
            Console.WriteLine("After m++: " + m);
            Console.WriteLine("--m = " + (--m));  // Pre-decrement
            Console.WriteLine("m-- = " + (m--));  // Post-decrement
            Console.WriteLine("After m--: " + m);
            Console.WriteLine("+m = " + (+m));    // Unary plus
            Console.WriteLine("-m = " + (-m));    // Unary minus

            Console.WriteLine("\n========== Ternary Operator ==========");
            // Ternary Operator: Shorthand for if-else
            int age = 20;
            string result = (age >= 18) ? "Adult" : "Minor";
            Console.WriteLine("Age " + age + " is: " + result);
        }

    }
}
