using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0.0;

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Deposited ${amount}.");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Amount must be greater than 0.");
            }
        }

        public double GetBalance()
        {
            return _balance;
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && _balance >= amount)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}.");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount. Amount must be greater than 0.");
            }
            else
            {
                Console.WriteLine("Insufficient balance for withdrawal.");
            }
        }
    }
}
