﻿using System;

// Статичні члени не можуть бути віртуальними, перевизначеними і абстрактними.

// Статичні члени підтримують заміщення.

namespace Static
{
    abstract class BaseClass
    {
        //public static virtual void StaticMethod()
        //{
        //    Console.WriteLine("BaseClass.StaticMethod");
        //}

        public static void StaticMethod()
        {
            Console.WriteLine("BaseClass.StaticMethod");
        }
    }

    class DerivedClass : BaseClass
    {
        //public static override void StaticMethod()
        //{
        //    Console.WriteLine("DerivedClass.StaticMethod");
        //}

        public static void StaticMethod()
        {
            Console.WriteLine("DerivedClass.StaticMethod");
        }
    }

    class Program
    {
        static void Main()
        {
            BaseClass.StaticMethod();
            DerivedClass.StaticMethod();

            // Delay.
            Console.ReadKey();
        }
    }
}
