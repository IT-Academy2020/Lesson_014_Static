using System;

namespace Static
{
    abstract class AbstractClass
    {
        // Статичний фабричний метод.
        public static AbstractClass CreateObject()
        {
            return new ConcreteClass();
        }

        public abstract void Method();
    }
}
