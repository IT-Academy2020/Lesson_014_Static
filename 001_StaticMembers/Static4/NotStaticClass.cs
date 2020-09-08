using System;

// Статичні поля і властивості.

namespace Static
{
    class NotStaticClass
    {
        // Статическое поле.
        static int field;

        // Статична властивість.
        public static int Property
        {
            get { return field; }
            set { field = value; }
        }
    }
}