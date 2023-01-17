using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasics
{
    class Radio : ElectricalDevice
    {
        // Radio Constructor : Inheriting from ElectricalDevice Class
        // As the constructor of Radio doesn't contain any extra property. 
        // It is Identical to the Base Class i.e ElectricalDevice.
        // Thus, we pass the values to the Base Class directly whenever a 
        // Radio class gets created. This is what is happening below.
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {

        }

        public void ListeningRadio()
        {
            if (isOn)
            {
                Console.WriteLine("Listening to {0} Radio!", this.Brand);
            }
            else
            {
                Console.WriteLine("Radio is Switched Off, Switch On first");
            }
        }


    }
}
