using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPolymorphismApp
{
    internal class Audi : Car
    {


        private string Brand;
        public string Model { get; set; }


        public Audi()
        {
            Model = "Default A4-Class";
            Brand = "AUDI";
        }

        public Audi(int hp, string color, string model, string brand)
        {
            HP = hp;
            Color = color;
            Model = model;
            Brand = brand;
        }

        public override void showDetails()
        {
            Console.WriteLine("Color of Car is " + Color);
            Console.WriteLine("HP of Car is " + HP);
            Console.WriteLine("Model of Car is" + Model);
            Console.WriteLine("Brand of Car is" + Brand);
        }


        public override void Repair()
        {
            Console.WriteLine("AUDI was repaired");
        }

    }
}
