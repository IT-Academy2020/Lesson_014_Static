﻿using System;

// Статичні члени в нестатичних класах.

namespace Static
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(NotStaticClass.Property);
            
            // Delay.
            Console.ReadKey();
        }
    }
}
