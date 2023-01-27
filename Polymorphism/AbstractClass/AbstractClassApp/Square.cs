using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassApp
{
    public class Square : Shape
    {
        private double volume;
        public override void Volume()
        {
            volume = Length * Length * Length;
            Console.WriteLine(volume);
        }
    }
}
