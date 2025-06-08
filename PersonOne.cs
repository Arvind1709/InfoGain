using System;

namespace InfoGain
{
    internal class PersonOne
    {
        // Static field: shared among all instances of the class
        public static int age = 30;

        // Instance field for name (just to identify different objects)
        public string Name;

        public void ShowAge()
        {
            Console.WriteLine($"{Name}'s view of age: {age}");
        }

        public void UpdateAge(int newAge)
        {
            age = newAge;
            Console.WriteLine($"{Name} updated age to: {age}");
        }
    }

    //PersonOne p1 = new PersonOne { Name = "Arvind" };
    //PersonOne p2 = new PersonOne { Name = "Yadav" };

    //    // Initially, both see the same age (30)
    //    p1.ShowAge();  // Output: Arvind's view of age: 30
    //    p2.ShowAge();  // Output: Yadav's view of age: 30

    //    // p1 updates the static age
    //    p1.UpdateAge(45);

    //    // Both objects now see updated age (45) because it's static
    //    p1.ShowAge();  // Output: Arvind's view of age: 45
    //    p2.ShowAge();  // Output: Yadav's view of age: 45
}
