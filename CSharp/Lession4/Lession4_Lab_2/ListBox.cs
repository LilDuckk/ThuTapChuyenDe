using Lession4_Lab_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4_Lab_2
{
    internal class ListBox : Window
    {
        private string listBoxContents;

        public ListBox(int top, int left, string content) : base(top, left)
        {
            listBoxContents = content;
        }

        public override void DrawWindow()
        {
            Console.WriteLine("Writing string to the list box : " + listBoxContents);
        }
    }
}
