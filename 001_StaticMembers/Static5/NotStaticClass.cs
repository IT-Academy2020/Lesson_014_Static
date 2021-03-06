﻿using System;

// Статичний конструктор.

// Статичні конструктори мають наступні властивості:
// 1. Статичний конструктор не має модифікаторів доступу і не приймає параметрів.
// 2. Статичний конструктор викликається автоматично для ініціалізації класу перед створенням першого екземпляру
// або посиланням на будь-які статичні члени.
// 3. Статичний конструктор не можна викликати ВРУЧНУ.
// 4. Користувач не керує тим, коли статичний конструктор виконується в програмі.


namespace Static
{
    class NotStaticClass
    {
        // Статичні поля readonly повинні бути ініційовані в конструкторі.
        static readonly long readonlyField = 2;

        // Статична властивість тільки для читання.
        public static long ReadonlyField
        {
            get { return NotStaticClass.readonlyField; }
        }

        // Статичний конструктор.       
        static NotStaticClass()
        {
            readonlyField = 1;
        }
    }
}
