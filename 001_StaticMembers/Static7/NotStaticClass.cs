using System;

namespace Static
{
    class NotStaticClass
    {
        // Контруктор екземпляра, викликається тільки при створенні екземпляра класу.
        public NotStaticClass()
        {
            Console.WriteLine("Constructor.");
        }

        // Статичний конструктор викликається в будь-якому випадку,
        // як при зверненні до статичного члену, так і при створенні екземпляра класу.
        static NotStaticClass()
        {
            Console.WriteLine("Static Constructor.");
        }

        // Статичний метод.
        public static void StaticMethod()
        {
            Console.WriteLine("StaticMethod");
        }

        public void NotStaticMethod()
        {
            Console.WriteLine("NotStaticMethod");
        }
    }
}
