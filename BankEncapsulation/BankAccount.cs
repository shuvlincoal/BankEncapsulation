using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {

        //Fields use camel casing
        private double balanace = 1000;

        //Property
        //public double balance { get; set; }
        

        public void Deposit(double deposit)
        {
            balanace += deposit;
        }

        public double GetBalance()
        {
            //Console.WriteLine($"Your Balance is: {balanace}");
            return balanace;
        }

        public void WithDraw(double deposit)
        {
            balanace -= deposit;
        }

    }
}
