using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession7_Lab_3
{
    internal class Cus
    {
        public class InvalidInputNumber : Exception
        {
            public InvalidInputNumber() :
                base("Hay nhap so lon hon 0")
            { }
        }
    }
}
