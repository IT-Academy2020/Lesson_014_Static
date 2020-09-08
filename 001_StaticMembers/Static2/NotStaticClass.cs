﻿using System;

// У статичних методах не можна звертатися до нестатичних полів.

namespace Static
{
    class NotStaticClass
    {
        private int id;

        // Конструктор.
        public NotStaticClass(int id)
        {
            this.id = id;
        }

        public static void Method()
        {
            //Console.WriteLine("Instance.Id = {0}", Id);

            Console.WriteLine("У статичних методах не можна звертатися до нестатичних полів.");
        }
    }
}
