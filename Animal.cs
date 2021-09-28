using System;
using System.Collections.Generic;
using System.Text;

namespace Task6._1
{
    abstract public class Animal
    {
        abstract public void Greeting();
    }

    public class Cat : Animal
    {
        override public void Greeting()
        {
            Console.WriteLine("Cat: Meow!");
        }
    }

    public class Dog : Animal
    {
        override public void Greeting()
        {
            Console.WriteLine("Dog: Woof!");
        }
        public void Greeting(Dog another)
        {
            Console.WriteLine("Dog: Woooooooooof!");
        }
    }

    public class BigDog : Dog
    {
        override public void Greeting()
        {
            Console.WriteLine("BigDog: Woow!");
        }
        new public void Greeting(Dog another)
        {
            Console.WriteLine("Woooooowwwww!");
        }
    }
}
