using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningProperties
{
    class Box
    {
        // member variables
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Volume
        {
            get
            {
                return this.Length * this.Width * this.Height;
            }
        }
        public int FrontSurface
        {
            get
            {
                return this.Length * this.Width;
            }
        }

        // constructor

        public Box(int length, int width, int height)
        {
            if ((length > 0) && (width > 0) && (height > 0))
            {
                this.Length = length;
                this.Width = width;
                this.Height = height;
            }

        }

        // member methods
        public void displayInfo()
        {
            Console.WriteLine("Here are the dimensions");
            Console.WriteLine($"Length is :{Length}");
            Console.WriteLine($"Width is :{Width}");
            Console.WriteLine($"Height is :{Height}");
            Console.WriteLine($"Volume is :{Volume}");
            Console.WriteLine($"FrontSurface is :{FrontSurface}");
        }

        // Destructor / Finalizer
        ~Box()
        {
            Console.WriteLine("Destructtion of the Bpx object");
            Debug.WriteLine("Destructtion of the Box object");
        }
    }
}
