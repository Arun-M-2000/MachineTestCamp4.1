using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTestCamp4._1
{
    class Employee : IPayable
        {
            private decimal balance;
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            
        public Employee()
            {
                balance = 0;
            }

            public void Deposit(decimal amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Deposited ${amount}. New balance: ${balance}");
                }
                else
                {
                    Console.WriteLine("Invalid deposit amount.");
                }
            }

            public void Withdraw(decimal amount)
            {
                if (amount > 0 && amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrawn ${amount}. New balance: ${balance}");
                }
                else
                {
                    Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
                }
            }

            public decimal CheckBalance()
            {
                return balance;
            }

        }

}
