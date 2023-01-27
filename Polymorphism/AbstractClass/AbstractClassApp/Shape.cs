using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassApp
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Volume();
    }
}
