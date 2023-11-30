using Lession4_Lab_4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4_Lab_4
{
    internal class Circle : Shape
    {
        public void InputData()
        {
            Console.Write("Nhập bán kính: ");
            radius = int.Parse(Console.ReadLine());
        }
        public override float Area()
        {
            return 3.14F * radius * radius;
        }

        public override float Circumference()
        {
            return 2 * 3.14F * radius;
        }
    }
}
