using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4_Ex_1
{
    internal class SavingAccount : Account
    {
        private double rate;

        public SavingAccount(double balance, double rate) : base(balance)
        {
            this.rate = rate;
        }

        public double GetInterest()
        {
            return balance * (rate / 100);
        }
    }
}