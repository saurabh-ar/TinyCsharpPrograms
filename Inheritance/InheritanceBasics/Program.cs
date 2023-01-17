using System;

namespace InheritanceBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio(false, "Phillips");
            radio.SwitchOn();
            radio.ListeningRadio();
            radio.SwitchOff();
            radio.ListeningRadio();

            TV tv = new TV(true, "Sony Bravia");
            tv.WatchTV();
        }
    }
}
