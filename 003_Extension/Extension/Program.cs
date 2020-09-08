using System;

// Методи розширення. (Extension methods)

// Методи розширення можуть бути тільки статичними і створюватися тільки в статичних класах.

namespace Extension
{
    static class ExtensionClass
    {
        // this - повідомляє компілятору, що даний метод є методом розширення (Extension)!
        public static void ExtensionMethod(this string value)
        {
            Console.WriteLine(value);
        }
    }

    class Program
    {
        static void Main()
        {
            string text = "Тестовий рядок";

            // Виклик методу, як статичного.
            ExtensionClass.ExtensionMethod(text);

            // Виклик методу, як розширення.
            text.ExtensionMethod();


            // Delay.
            Console.ReadKey();
        }
    }
}