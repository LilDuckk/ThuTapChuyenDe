using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4_Lab_2
{
    internal class Window
    {
        protected int top;
        protected int left;

        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: drawing Window at {0}, {1}", top, left);
        }
    }
}
