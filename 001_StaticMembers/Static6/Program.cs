﻿using System;

// Статичні члени в нестатичних класах.

namespace Static
{
    class Program
    {
        static void Main()
        {
            NotStaticClass instance = new NotStaticClass();
            instance.NotStaticMethod();

            NotStaticClass.Property = 2;
            Console.WriteLine(NotStaticClass.Property);

            NotStaticClass.Method();
            NotStaticClass.Method(3);

            // Delay.
            Console.ReadKey();
        }
    }
}
