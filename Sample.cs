using System;

namespace InfoGain
{
    internal class Sample
    {
        int value = 10;
        public static void ShowValue()
        {
            // ❌ Error: Cannot access instance member 'value' from static method
            // Console.WriteLine(value); 

            // ✅ Correct: Access via object
            Sample s = new Sample();
            Console.WriteLine("Value: " + s.value);
        }
    }
}
