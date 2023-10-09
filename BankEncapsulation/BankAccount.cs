using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0.0;

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited ${amount}. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Amount must be greater than 0.");
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
