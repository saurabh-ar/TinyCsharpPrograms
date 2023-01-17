using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasics
{
    class TV : ElectricalDevice
    {
        // TV Constructor : Inheriting from ElectricalDevice Class
        // As the constructor of TV doesn't contain any extra property. 
        // It is Identical to the Base Class i.e ElectricalDevice.
        // Thus, we pass the values to the Base Class directly whenever a 
        // TV class gets created. This is what is happening below.
        public TV(bool isOn, string brand) : base(isOn, brand)
        {

        }

        public void WatchTV()
        {
            if (isOn)
            {
                Console.WriteLine("Watching {0} TV!", this.Brand);
            }
            else
            {
                Console.WriteLine("TV is Switched Off, Switch On first");
            }
        }
    }
}
