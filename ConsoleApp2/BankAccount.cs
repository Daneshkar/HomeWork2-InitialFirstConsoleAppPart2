using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class BankAccount
    {
        public BankAccount() { }

        public BankAccount(int init)
        {
            Balance = init;
        }

        private int balance = 0;

        public int Balance
        {
            get { return balance; }
            set
            {
                balance = value;
            }
        }

        public bool Deposit(double myvalue)
        {
            bool result = false;

            if (myvalue < 0)
            {
                return false;
            }

            if (balance + myvalue > int.MaxValue)
            {
                return false;
            }

            balance += (int)myvalue;
            return true;
        }

        public bool WithDraw(double amount)
        {
            if (amount <= 0)
            {
                return false;
            }

            if (balance < 0)
            {
                return false;
            }

            if (balance < amount)
            {
                return false;
            }

            balance -= (int)amount;
            return true;

        }

        public int GetBalance()
        {
            return balance;
        }

    }
}
