using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceVirtualOverrideBasics
{
    internal class Animal
    {
        //Name of the animal
        public string Name { get; set; }
       
        // Age of the Animal
        public int Age { get; set; }

        // Hungry or Not?
        public bool Hungry { get; set; }
        public void isHungry()
        {
            this.Hungry = true;
        }
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
          
            // Default value. All animals are Hungry by Default.
            this.Hungry = true;
        }

        
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} is making Sound.");
        }

        public virtual void Eat()
        {
            if (Hungry)
            {
                Console.WriteLine($"{Name} is Eating.");
            }
            else
            {
                Console.WriteLine($"{Name} is not Hungry.");
            }
           
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is Playing.");
        }
    }
}
