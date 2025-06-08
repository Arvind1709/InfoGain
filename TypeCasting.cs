using System;

namespace InfoGain
{
    internal class TypeCasting
    {
        // Parent class
        public class Animal
        {
            public void Speak()
            {
                Console.WriteLine("Animal speaks.");
            }
        }

        // Child class
        public class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("Dog barks.");
            }
        }
        public void Casting()
        {
            // ==========================================
            // 1. Implicit Casting (Safe, automatic)
            // ==========================================
            int myInt = 100;
            double myDouble = myInt;  // int -> double (Implicit)
            Console.WriteLine("Implicit Casting (int to double): " + myDouble);

            // ==========================================
            // 2. Explicit Casting (Manual, may lose data)
            // ==========================================
            double yourDouble = 9.78;
            int yourInt = (int)yourDouble;  // double -> int (Explicit)
            Console.WriteLine("Explicit Casting (double to int): " + yourInt);

            // ==========================================
            // 3. Explicit Casting with data loss
            // ==========================================
            int bigValue = 300;
            byte smallValue = (byte)bigValue;  // byte range is 0-255
            Console.WriteLine("Casting with data loss (int to byte): " + smallValue);

            // ==========================================
            // 4. Upcasting (Implicit Reference Type Conversion)
            // ==========================================
            Dog dog = new Dog();
            Animal animal = dog;  // Upcasting (Dog -> Animal)
            animal.Speak();       // Works fine

            // ==========================================
            // 5. Downcasting (Explicit Reference Type Conversion)
            // ==========================================
            Animal animal2 = new Dog();  // Actually a Dog object
            Dog downcastDog = (Dog)animal2;  // Downcasting
            downcastDog.Bark();  // Works fine

            // ==========================================
            // 6. Using 'is' operator
            // ==========================================
            if (animal2 is Dog)
            {
                Dog dogUsingIs = (Dog)animal2;
                Console.WriteLine("Animal is a Dog (checked using 'is')");
            }

            // ==========================================
            // 7. Using 'as' operator
            // ==========================================
            Animal animal3 = new Dog();
            Dog dogUsingAs = animal3 as Dog;
            if (dogUsingAs != null)
            {
                Console.WriteLine("Animal casted to Dog using 'as'");
            }

            // ==========================================
            // 8. Convert class for type conversion
            // ==========================================
            string str1 = "123";
            int converted = Convert.ToInt32(str1);  // String to int
            Console.WriteLine("Convert.ToInt32: " + converted);

            // ==========================================
            // 9. Parse method (throws exception if invalid)
            // ==========================================
            string str2 = "456";
            int parsed = int.Parse(str2);  // String to int
            Console.WriteLine("int.Parse: " + parsed);

            string str4 = "456a";
            bool isParseds = int.TryParse(str4, out int result);

            if (isParseds)
                Console.WriteLine("Parsed: " + result);
            else
                Console.WriteLine("Invalid number");  // ✅ This will be printed

            // ==========================================
            // 10. TryParse method (safe parsing)
            // ==========================================
            string str3 = "789a";
            bool isParsed = int.TryParse(str3, out int tryParsed);
            Console.WriteLine("TryParse Success? " + isParsed + ", Value: " + tryParsed);


        }
    }
}
