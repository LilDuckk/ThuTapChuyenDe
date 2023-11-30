using Lession4_Lab_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4_Lab_4
{
    internal class Rectangle : Shape
    {
        public void InputData()
        {
            Console.Write("Nhập chiêu dài: ");
            length = int.Parse(Console.ReadLine());
            Console.Write("Nhập chiêu rộng: ");
            width = int.Parse(Console.ReadLine());
        }
        public override float Area()
        {
            return length * width;
        }

        public override float Circumference()
        {
            return (length + width) / 2;
        }
    }
}
