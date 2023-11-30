using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession6_Ex_3
{
    internal class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return "\nName: " + Name + "\nColor: " + Color;
        }
    }
}
