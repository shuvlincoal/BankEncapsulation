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
        private double _balanace = 1000;

        //Property
        //public double balance { get; set; }
        

        public void Deposit(double deposit)
        {
            _balanace += deposit;
        }

        public double GetBalance()
        {
            //Console.WriteLine($"Your Balance is: {balanace}");
            return _balanace;
        }

        public void WithDraw(double deposit)
        {
            _balanace -= deposit;
        }

    }
}
