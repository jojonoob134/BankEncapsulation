using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double _balance = 100;
        public double GetBalance()
        {
            return _balance;
        }
        public double Deposet(double adding)
        {
            _balance += adding;
            return _balance;
        }

        public double Withdrawal(double taking)
        {
            _balance -= taking;
            return _balance;
        }
    }
}
