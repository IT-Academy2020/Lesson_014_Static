﻿using System;

// Методи розширення. (Extension methods)

// Рекурсія (проста).

namespace Extension
{
    static class ExtensionClass
    {
        public static void ExtensionMethod(this string value, int counter)
        {
            counter--;
            Console.WriteLine(value + counter);

            if (counter != 0)
                value.ExtensionMethod(counter);

            Console.WriteLine(value + counter);
        }
    }

    class Program
    {
        static void Main()
        {
            string text = "Hello";

            text.ExtensionMethod(3);

            // Delay.
            Console.ReadKey();
        }
    }
}