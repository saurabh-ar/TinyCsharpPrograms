using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasics
{
    internal class ElectricalDevice
    {
        // Boolean : Is the device ON?
        public bool isOn { get; set; }

        // String: Brand of the Device.
        public string Brand { get; set; }

        // Constructor.
        public ElectricalDevice(bool isOn, string brand)
        {
            this.isOn = isOn;
            this.Brand = brand;
        }

        // Switch ON the Device
        public void SwitchOn()
        {
            this.isOn = true;
        }
        // Switch OFF the Device
        public void SwitchOff()
        {
            this.isOn = false;
        }


    }
}
