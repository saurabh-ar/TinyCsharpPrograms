using System;

namespace InheritanceVirtualOverrideBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Tony", 5);
            dog.IsHappy=true;

            dog.Play();
            dog.MakeSound();
            dog.Eat();
        }
    }
}
