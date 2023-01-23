using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPolymorphismApp
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public Car()
        {
            HP = 0;
            Color = "Default Color : White";
        }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public virtual void showDetails()
        {
            Console.WriteLine("Color of Car is " + Color);
            Console.WriteLine("HP of Car is " + HP);
        }


        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
    }
}
