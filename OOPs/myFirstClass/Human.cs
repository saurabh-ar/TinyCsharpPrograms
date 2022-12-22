using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstClass
{
    internal class Human
    {
        // member properties
        private string fname;
        private string lname;
        private string eyeColor;
        public int age;

        // Constructors with Different number of Parameters
        public Human(string fName, string lName, string eyeColor, int age)
        {
            this.fname = fName;
            this.lname = lName;
            this.eyeColor = eyeColor;
            this.age = age;
        }
        // Constructor | Parameters : 3
        public Human(string fName, string lName, string eyeColor)
        {
            this.fname = fName;
            this.lname = lName;
            this.eyeColor = eyeColor;
        }
        // Constructor | Parameters : 2
        public Human(string fName, string lName)
        {
            this.fname = fName;
            this.lname = lName;
        }
        // Constructor | Parameter : 1
        public Human(string fName)
        {
            this.fname = fName;
        }

        // member methods
        public void IntroduceYourself()
        {
            Console.WriteLine("Hello there!");
            if ((fname != null) && (lname != null) && (eyeColor != null) && (age > 0))
            {
                Console.WriteLine($"My name is {fname}  {lname}");
                Console.WriteLine($"My eyecolor is {eyeColor} and I am {age} yrs old." +
                    $" Chao!");
            }
            else if ((fname != null) && (lname != null) && (eyeColor != null))
            {
                Console.WriteLine($"My name is {fname}  {lname}");
                Console.WriteLine($"My eyecolor is {eyeColor}" +
                    $" Chao!");
            }
            else if ((fname != null) && (lname != null))
            {
                Console.WriteLine($"My name is {fname}  {lname}");
                Console.WriteLine(" Chao!");
            }
            else if (fname != null)
            {
                Console.WriteLine($"My name is {fname}  {lname}");
                Console.WriteLine(" Chao!");
            }
            else
            {
                Console.WriteLine("Please enter some value");
            }
        }
    }
}
