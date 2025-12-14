using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Task2
{
    public class BankAccount
    {
        private int balance;

        public void Deposit(double amount)
        {
            balance += (int)amount;
            Console.WriteLine($"{amount} added to your account");
        }
        public void Withdraw(double amount)
        {

            if (balance >= (int)amount)
            {
                balance -= (int)amount;
                Console.WriteLine($"{amount} withdrawn from your account");
            }
            else
            {
                Console.WriteLine("Not Enough Balance");
            }
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Your current Balance: {balance}");
        }
    }
}
