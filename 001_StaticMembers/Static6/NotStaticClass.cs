using System;

namespace Static
{
    class NotStaticClass
    {
        // Якщо клас містить статичні поля, повинен бути наданий статичний конструктор,
        // який ініціалізує ці поля при завантаженні класу.

        private static int field;

        public static int Property
        {
            get { return field; }
            set { field = value; }
        }

        // Статичний конструктор.
        // Єдине призначення статичних конструкторів - присвоювати початкові значення статичним змінним.
        static NotStaticClass()
        {
            Console.WriteLine("Статичний конструктор - NotStaticClass ()");
            field = 1;
        }

        // Статичні методи можуть бути перевантажені.
        public static void Method()
        {
            Console.WriteLine("Статичний метод, неcтатичного NotStaticClass");
        }

        // Статичні методи можуть бути перевантажені.
        public static void Method(int s)
        {
            Console.WriteLine("Перевантажений статичний метод, неcтатичного NotStaticClass" + s);
        }

        // Неcтатичний метод.
        public void NotStaticMethod()
        {
            Console.WriteLine(field);
        }
    }
}
