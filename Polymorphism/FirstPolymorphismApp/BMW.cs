using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPolymorphismApp
{
    internal class BMW : Car
    {
        private string Brand;
        public string Model { get; set; }


        public BMW()
        {
            Model = "Default C-Class";
            Brand = "BMW";
        }

        //if you want to use Base Color and HP the you can write | :base(hp,color)
        public BMW(int hp, string color, string model, string brand):base(hp,color)
        {
            Model = model;
            Brand = brand;
        }


        public override void showDetails()
        {
            Console.WriteLine("Color of Car is :" + Color);
            Console.WriteLine("HP of Car is :" + HP);
            Console.WriteLine("Model of Car is :" + Model);
            Console.WriteLine("Brand of Car is :" + Brand);
        }


        public override void Repair()
        {
            Console.WriteLine("BMW {0} was repaired", Model);
        }


    }
}
