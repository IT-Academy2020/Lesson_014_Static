using System;

// Статичний конструктор.

namespace Static
{
    class Program
    {
        static void Main()
        {
            // 1 варіант. (Викликається тільки Статичний конструктор.)
            NotStaticClass.StaticMethod();

            // 2 Варіант. (Викликаються обидва Конструктора.)
            // new NotStaticClass (). NotStaticMethod ();

            // Delay.
            Console.ReadKey();
        }
    }
}
