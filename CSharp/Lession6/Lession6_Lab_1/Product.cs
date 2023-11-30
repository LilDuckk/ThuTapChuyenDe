using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession6_Lab_1
{
    internal class Product
    {
        string name;
        double price;
        int onHand;

        public Product(string name, double price, int onHand)
        {
            this.name = name;
            this.price = price;
            this.onHand = onHand;
        }

        public override string ToString()
        {
            return String.Format("{0,-10}Cost: {1,6:C}   On hand:{2}", name, price, onHand);
        }
    }
}
