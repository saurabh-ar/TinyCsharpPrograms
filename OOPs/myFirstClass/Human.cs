using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstClass
{
    internal class Human
    {
        //member properties
        private string fname;
        private string lname;
        private string eyeColor;
        public int age;

        //Constructor
        public Human(string fName, string lName, string eyeColor, int age)
        {
            this.fname = fName;
            this.lname = lName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        //member methods
        public void IntroduceYourself()
        {
            Console.WriteLine("Hello there!");
            Console.WriteLine($"My name is {fname}  {lname}");
            Console.WriteLine($"My eyecolor is {eyeColor} and I am {age} yrs old. Chao!");
        }
    }
}
