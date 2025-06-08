using System;
namespace InfoGain
{
    public class VariablesAndConstantsExample
    {
        // Declare and initialize a variable
        static int age = 25;
        // Declare and initialize a constant
        const double pi = 3.14159;
        public void VariablesAndConstants()
        {
            // ===============================
            // What is a Variable?
            // A variable is a named memory location used to store data that can change during program execution.
            // Variables are important because they allow programs to store and manipulate data dynamically.
            // ===============================

            // the value of the variable before changing
            Console.WriteLine("Value of Variable - Age: " + age);
            // Change the value of the variable
            age = 30;
            Console.WriteLine("Updated Variable - Age: " + age);

            // ===============================
            // What is a Constant?
            // A constant is a named memory location with a value that cannot be changed once assigned.
            // Constants are used for fixed values that should never change (e.g., pi).
            // They improve code safety and readability.
            // ===============================


            Console.WriteLine("Constant - Pi: " + pi);

            // Uncommenting the following line will cause a compile-time error,
            // because you cannot change the value of a constant.
            // pi = 3.14;

            // Using both variable and constant in a calculation
            int radius = 5;
            double area = pi * radius * radius;
            Console.WriteLine("Area of circle with radius " + radius + " is: " + area);

            Console.WriteLine("Age from method getAge(): " + getAge());

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

            //Here, pi is declared inside the class, but outside any method.
            //Such variables/constants are called fields of the class.
            //By default, a class-level field without any access modifier is private in C#.
            //Private fields are accessible inside the entire class, including all its methods.
            //So, even though you didn’t write public, the method VariablesAndConstants() can still use pi because it belongs to the same class.
        }
        public static int getAge()
        {
            return age; // This is just a placeholder for demonstration purposes.
        }
    }
}

