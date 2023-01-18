using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceVirtualOverrideBasics
{
    internal class Dog : Animal
    {
        public bool IsHappy { get; set; }
        public Dog(string Name, int Age): base(Name, Age)
        {
            // bool property to check if dog is Happy
            IsHappy = true;
        }

        public override void MakeSound()
        {
            // since everty animal will make a totally different sound
            // each animal will implement their own version of MakeSound()
            Console.WriteLine($"{Name} is making Bow Wow! Wooooooo sound.");
        }

        public override void Eat()
        {
            base.Eat();

        }

        public override void Play()
        {
            // Dog will only play when it is Happy.

            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}
